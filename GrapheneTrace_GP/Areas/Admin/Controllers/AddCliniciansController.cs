using GrapheneTrace_GP.Areas.Admin.Models;
using GrapheneTrace_GP.Areas.Admin.Models.ClinicianAddProfile;
using GrapheneTrace_GP.Areas.Admin.ViewModels.AddClinician;
using GrapheneTrace_GP.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;



namespace GrapheneTrace_GP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AddCliniciansController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;

        public AddCliniciansController(ApplicationDbContext ctx, IWebHostEnvironment env)
        {
            _context = ctx;
            _env = env;
        }

        // ---------------- STEP 01 ----------------
        public IActionResult Step01()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Step01Post(Step01PersonalVM model)
        {
            HttpContext.Session.SetString("Step01", JsonSerializer.Serialize(model));
            return RedirectToAction("Step02");
        }


        // ---------------- STEP 02 ----------------
        public IActionResult Step02()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Step02(Step02ProfessionalVM model)
        {
            HttpContext.Session.SetString("Step02", JsonSerializer.Serialize(model));
            return RedirectToAction("Step03");
        }

        // ---------------- STEP 03 ----------------
        public IActionResult Step03()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Step03(Step03AssignmentsVM model)
        {
            HttpContext.Session.SetString("Step03", JsonSerializer.Serialize(model));
            return RedirectToAction("Step04");
        }

        // ---------------- STEP 04 ----------------
        public IActionResult Step04()
        {
            return View();
        }

        // ---------------- SAVE ALL STEPS ----------------
        [HttpPost]
        public async Task<IActionResult> Save(Step04ReviewVM model)
        {
            var step1 = JsonSerializer.Deserialize<Step01PersonalVM>(HttpContext.Session.GetString("Step01"));
            var step2 = JsonSerializer.Deserialize<Step02ProfessionalVM>(HttpContext.Session.GetString("Step02"));
            var step3 = JsonSerializer.Deserialize<Step03AssignmentsVM>(HttpContext.Session.GetString("Step03"));

            // 1️⃣ Save Clinician Basic Info
            var newClinician = new Clinicians
            {
                Title = step1.Title,
                ClinicianFirstName = step1.ClinicianFirstName,
                ClinicianLastName = step1.ClinicianLastName,
                Email = step1.Email,
                Phone = step1.Phone,
                Gender = step1.Gender,
                DateOfBirth = step1.DateOfBirth,
                Address = step1.Address,
                City = step1.City,
                PostCode = step1.PostCode,
                Status = "Active",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _context.Clinicians.Add(newClinician);
            await _context.SaveChangesAsync();
            // generates newClinician.Id

            // 2️⃣ Save Professional Info
            _context.ClinicianProfessionalInfos.Add(new ClinicianProfessionalInfo
            {
                ClinicianId = newClinician.Id,
                Department = step2.Department?? "N/A",
                Speciality = step2.Speciality?? "N/A",
                ExperienceYears = step2.ExperienceYears?? "N/A",
                LicenceNo = step2.LicenceNo?? "N/A",
                WorkSchedule = step2.WorkSchedule?? "N/A"
            });

            // 3️⃣ Save Assignments
            _context.ClinicianAssignments.Add(new ClinicianAssignments
            {
                ClinicianId = newClinician.Id,
                AssignedPatients = step3.AssignedPatients?? "N/A",
                CurrentAppointments = step3.CurrentAppointments,
                AssignedWard = step3.AssignedWard?? "N/A",
                Supervisor = step3.Supervisor?? "N/A",
                Notes = step3.Notes?? "N/A",
                LastAssignmentUpdate = DateTime.UtcNow
            });

            // 4️⃣ Save Verification
            _context.ClinicianVerifications.Add(new ClinicianVerification
            {
                ClinicianId = newClinician.Id,
                VerificationStatus = "Verified" ?? "N/A",
                VerifiedBy = model.VerifiedBy ?? "N/A",
                DateReviewed = DateTime.UtcNow,
                Remarks = model.Remarks ?? "N/A",
                ProfileStatus = "Active" ?? "N/A"
            });

            await _context.SaveChangesAsync();

            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Clinicians");
        }
    }
}
