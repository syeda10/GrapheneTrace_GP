using GrapheneTrace_GP.Areas.Admin.Models;
using GrapheneTrace_GP.Areas.Admin.Models.PatientAddProfile;
using GrapheneTrace_GP.Areas.Admin.ViewModels.AddPatient;
using GrapheneTrace_GP.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace GrapheneTrace_GP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AddPatientController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AddPatientController(ApplicationDbContext context)
        {
            _context = context;
        }

        // STEP 1
        [HttpPost]
        public async Task<IActionResult> Save(Step04ReviewVM model)
        {
            var s1 = JsonSerializer.Deserialize<
             GrapheneTrace_GP.Areas.Admin.ViewModels.AddPatient.Step01PersonalVM
            >(HttpContext.Session.GetString("P_Step01"));

            var s2 = JsonSerializer.Deserialize<
                GrapheneTrace_GP.Areas.Admin.ViewModels.AddPatient.Step02MedicalVM
            >(HttpContext.Session.GetString("P_Step02"));

            var s3 = JsonSerializer.Deserialize<
                GrapheneTrace_GP.Areas.Admin.ViewModels.AddPatient.Step03AssignmentsVM
            >(HttpContext.Session.GetString("P_Step03"));


            // ================================================================
            // 2️⃣ SAVE INTO OLD PATIENT TABLE (the one your UI uses)
            // ================================================================
            var oldPatient = new Patient
            {
                Title = s1.Title ?? "N/A",
                FirstName = s1.FirstName ?? "N/A",
                LastName = s1.LastName ?? "N/A",
                Email = s1.Email ?? "N/A",
                Phone = s1.Phone ?? "N/A",
                Gender = s1.Gender ?? "N/A",
                DateOfBirth = s1.DateOfBirth ?? DateTime.UtcNow,
                Address = s1.Address ?? "N/A",
                City = s1.City ?? "N/A",
                PostCode = s1.PostCode ?? "N/A",

                Status = "Active",

                PatientAge = s1.DateOfBirth.HasValue
         ? ((int)((DateTime.UtcNow - s1.DateOfBirth.Value).TotalDays / 365.25)).ToString()
         : "N/A",

                ClinicianId = s3.ClinicianId ?? 0
            };

            // ⭐ MUST BE OUTSIDE THE OBJECT ⭐
            oldPatient.PatientId = await _context.Patients.AnyAsync()
                ? await _context.Patients.MaxAsync(p => p.PatientId) + 1
                : 1;

            _context.Patients.Add(oldPatient);
            await _context.SaveChangesAsync();


            // ================================================================
            // 3️⃣ SAVE NEW PROFILE TABLES (optional, separate)
            // ================================================================
            var profile = new PatientProfile
            {
                Title = s1.Title,
                FirstName = s1.FirstName,
                LastName = s1.LastName,
                Email = s1.Email,
                Phone = s1.Phone,
                Gender = s1.Gender,
                DateOfBirth = s1.DateOfBirth,
                NHSNumber = s1.NHSNumber,
                Address = s1.Address,
                City = s1.City,
                PostCode = s1.PostCode,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _context.PatientProfile.Add(profile);
            await _context.SaveChangesAsync();

            _context.PatientMedicalInfos.Add(new PatientMedicalInfo
            {
                PatientId = profile.Id,
                BloodGroup = s2.BloodGroup ?? "N/A",
                Allergies = s2.Allergies ?? "N/A",
                Conditions = s2.Conditions ?? "N/A",
                Medications = s2.Medications ?? "N/A",
                Weight = s2.Weight ?? "N/A",
                Height = s2.Height ?? "N/A",
                Smoking = s2.Smoking ?? "N/A",
                PastSurgeries = s2.PastSurgeries ?? "N/A",
                Notes = s2.Notes ?? "N/A"
            });

            _context.PatientAssignments.Add(new PatientAssignments
            {
                PatientId = profile.Id,
                ClinicianId = s3.ClinicianId ?? 0,
                AssignedDoctor = s3.AssignedDoctor ?? "N/A",
                Ward = s3.Ward ?? "N/A",
                Status = s3.Status ?? "Active",
                AssignedAt = DateTime.UtcNow,
                EmergencyContact = s3.EmergencyContact ?? "N/A"
            });

            _context.PatientVerifications.Add(new PatientVerification
            {
                PatientId = profile.Id,
                VerificationStatus = "Verified",
                VerifiedBy = model.VerifiedBy ?? "Admin",
                DateReviewed = DateTime.UtcNow,
                Remarks = model.Remarks ?? "",
                ProfileStatus = "Active"
            });

            await _context.SaveChangesAsync();
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Patients");
        }



    }
}

