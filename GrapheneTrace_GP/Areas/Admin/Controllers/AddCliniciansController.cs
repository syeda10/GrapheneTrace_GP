 using GrapheneTrace_GP.Areas.Admin.ViewModels.AddClinician;
        using GrapheneTrace_GP.Data;
        using Microsoft.AspNetCore.Mvc;
        using Microsoft.Extensions.Logging;
        using System.Text.Json;

        namespace GrapheneTrace_GP.Areas.Admin.Controllers
        {
            [Area("Admin")]
            public class AddCliniciansController : Controller
            {
                private readonly ApplicationDbContext _context;
                private readonly ILogger<AddCliniciansController> _logger;
                private static readonly JsonSerializerOptions _jsonOpts = new() { PropertyNameCaseInsensitive = true };

                // session keys centralized
                private const string S_STEP01 = "C_Step01";
                private const string S_STEP02 = "C_Step02";
                private const string S_STEP03 = "C_Step03";
                private const string S_STEP04 = "C_Step04";

                public AddCliniciansController(ApplicationDbContext context, ILogger<AddCliniciansController> logger)
                {
                    _context = context;
                    _logger = logger;
                }

                // ===========================
                // STEP 01 - PERSONAL DETAILS
                // ===========================

                [HttpGet]
                public IActionResult Step01() => View(new Step01PersonalVM());

                [HttpPost]
                [ValidateAntiForgeryToken]
                public IActionResult Step01(Step01PersonalVM model)
                {
                    if (!ModelState.IsValid) return View(model);

                    HttpContext.Session.SetString(S_STEP01, JsonSerializer.Serialize(model, _jsonOpts));
                    return RedirectToAction(nameof(Step02));
                }



                // ===========================
                // STEP 02 - PROFESSIONAL
                // ===========================

                [HttpGet]
                public IActionResult Step02() => View(new Step02ProfessionalVM());

                [HttpPost]
                [ValidateAntiForgeryToken]
                public IActionResult Step02(Step02ProfessionalVM model)
                {
                    if (!ModelState.IsValid) return View(model);

                    HttpContext.Session.SetString(S_STEP02, JsonSerializer.Serialize(model, _jsonOpts));
                    return RedirectToAction(nameof(Step03));
                }

                // ===========================
                // STEP 03 - ASSIGNMENTS
                // ===========================

                [HttpGet]
                public IActionResult Step03() => View(new Step03AssignmentsVM());

                [HttpPost]
                [ValidateAntiForgeryToken]
                public IActionResult Step03(Step03AssignmentsVM model)
                {
                    if (!ModelState.IsValid) return View(model);

                    HttpContext.Session.SetString(S_STEP03, JsonSerializer.Serialize(model, _jsonOpts));
                    return RedirectToAction("Step04"); // consistent naming
                }

                // STEP 04 - REVIEW

                [HttpGet]
                public IActionResult Step04()
                {
                    // Load session values from Step 01–03
                    if (HttpContext.Session.GetString(S_STEP01) is null ||
                        HttpContext.Session.GetString(S_STEP02) is null ||
                        HttpContext.Session.GetString(S_STEP03) is null)
                    {
                        return RedirectToAction(nameof(Step01));
                    }

                    return View(new Step04ReviewVM());
                }

                // FINAL SAVE
                [HttpPost]
                [ValidateAntiForgeryToken]
                public async Task<IActionResult> Step04(Step04ReviewVM model)
                {
                    if (!ModelState.IsValid) return View(model);

                    // read session steps (null-checked above)
                    var s1 = JsonSerializer.Deserialize<Step01PersonalVM>(HttpContext.Session.GetString(S_STEP01)!, _jsonOpts);
                    var s2 = JsonSerializer.Deserialize<Step02ProfessionalVM>(HttpContext.Session.GetString(S_STEP02)!, _jsonOpts);
                    var s3 = JsonSerializer.Deserialize<Step03AssignmentsVM>(HttpContext.Session.GetString(S_STEP03)!, _jsonOpts);

                    if (s1 == null || s2 == null || s3 == null)
                    {
                        _logger.LogWarning("One or more clinician onboarding steps are missing from session.");
                        return RedirectToAction(nameof(Step01));
                    }

                    // Use a transaction and single SaveChanges for atomicity / performance
                    using var tx = await _context.Database.BeginTransactionAsync();

                    try
                    {
                        var profile = new ClinicianProfile
                        {
                            Title = s1.Title,
                            ClinicianFirstName = s1.FirstName,
                            ClinicianLastName = s1.LastName,
                            Email = s1.Email,
                            Phone = s1.Phone,
                            Gender = s1.Gender,
                            DateOfBirth = s1.DateOfBirth,
                            Address = s1.Address,
                            City = s1.City,
                            PostCode = s1.PostCode,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow
                        };

                        await _context.ClinicianProfile.AddAsync(profile);
                        await _context.SaveChangesAsync(); // save to populate profile.Id

                // Add professional info
                        _context.ClinicianProfessional.Add(new ClinicianProfessional
                        {
                            ClinicianId = profile.Id,
                            ClinicianSpeciality = s2.Speciality,
                            Qualification = s2.Qualifications,
                            ExperienceYears = s2.ExperienceYears,
                            Department = s2.Department,
                            LicenceNo = s2.LicenceNo
                        });


                // Add assignments
                        _context.ClinicianAssignments.Add(new ClinicianAssignments
                        {
                            ClinicianId = profile.Id,
                            AssignedWard = s3.AssignedWard ?? s3.AssignedWard,
                            AssignedPatients = s3.AssignedPatients,
                            CurrentAppointments = s3.CurrentAppointments,
                            Supervisor = s3.Supervisor,
                            Notes = s3.Notes,
                            LastAssignmentUpdate = DateTime.UtcNow
                        });

                        // Add verification
                       _context.ClinicianVerification.AddAsync(new ClinicianVerification
                        {
                            ClinicianId = profile.Id,
                            VerifiedBy = model.VerifiedBy ?? "Admin",
                            Remarks = model.Remarks ?? string.Empty,
                            VerificationStatus = "Verified",
                            DateReviewed = DateTime.UtcNow
                        });

                        // Persist all remaining changes in a single call
                        await _context.SaveChangesAsync();
                        await tx.CommitAsync();

                        // clear session
                        HttpContext.Session.Remove(S_STEP01);
                        HttpContext.Session.Remove(S_STEP02);
                        HttpContext.Session.Remove(S_STEP03);
                        HttpContext.Session.Remove(S_STEP04);

                        return RedirectToAction("Index", "Clinicians");
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Error saving clinician onboarding data; rolling back.");
                        await tx.RollbackAsync();
                        ModelState.AddModelError(string.Empty, "Unable to save clinician. Try again later.");
                        return View(model);
                    }
                }
            }
        }
