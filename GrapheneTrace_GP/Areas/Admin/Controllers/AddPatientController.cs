using GrapheneTrace_GP.Areas.Admin.Models.PatientAddProfile;
using GrapheneTrace_GP.Areas.Admin.ViewModels.AddPatient;
using GrapheneTrace_GP.Data;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Step01() => View();

        [HttpPost]
        public IActionResult Step01Post(Step01PersonalVM model)
        {
            HttpContext.Session.SetString("P_Step01", JsonSerializer.Serialize(model));
            return RedirectToAction("Step02");
        }

        // STEP 2
        public IActionResult Step02() => View();

        [HttpPost]
        public IActionResult Step02Post(Step02MedicalVM model)
        {
            HttpContext.Session.SetString("P_Step02", JsonSerializer.Serialize(model));
            return RedirectToAction("Step03");
        }

        // STEP 3
        public IActionResult Step03() => View();

        [HttpPost]
        public IActionResult Step03Post(Step03AssignmentsVM model)
        {
            HttpContext.Session.SetString("P_Step03", JsonSerializer.Serialize(model));
            return RedirectToAction("Step04");
        }

        // STEP 4
        public IActionResult Step04() => View();

        [HttpPost]
        public async Task<IActionResult> Save(Step04ReviewVM model)
        {
            // Read session
            var s1 = JsonSerializer.Deserialize<Step01PersonalVM>(HttpContext.Session.GetString("P_Step01"));
            var s2 = JsonSerializer.Deserialize<Step02MedicalVM>(HttpContext.Session.GetString("P_Step02"));
            var s3 = JsonSerializer.Deserialize<Step03AssignmentsVM>(HttpContext.Session.GetString("P_Step03"));

            // 1️⃣ Save Patient Basic Profile
            var patient = new PatientProfile
            {
                Title = s1.Title,
                FirstName = s1.FirstName,
                LastName = s1.LastName,
                DateOfBirth = s1.DateOfBirth,
                Gender = s1.Gender,
                Phone = s1.Phone,
                Email = s1.Email,
                Address = s1.Address,
                City = s1.City,
                PostCode = s1.PostCode,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _context.PatientProfile.Add(patient);
            await _context.SaveChangesAsync();

            // 2️⃣ Save Medical Info
            _context.PatientMedicalInfos.Add(new PatientMedicalInfo
            {
                PatientId = patient.Id,
                BloodGroup = s2.BloodGroup ?? "N/A",
                Allergies = s2.Allergies ?? "N/A",
                Weight = s2.Weight ?? "N/A",
                Height = s2.Height ?? "N/A",
                Conditions = s2.Conditions ?? "N/A",
                Medications = s2.Medications ?? "N/A",
                Smoking = s2.Smoking ?? "N/A",
                Notes = s2.Notes ?? "N/A"
            });

            // 3️⃣ Save Assignments
            _context.PatientAssignments.Add(new PatientAssignments
            {
                PatientId = patient.Id,
                ClinicianId = s3.ClinicianId ?? 0,
                AssignedDoctor = s3.AssignedDoctor ?? "N/A",
                Department = s3.Department ?? "N/A",
                EmergencyContact = s3.EmergencyContact ?? "N/A",
                Ward = s3.Ward ?? "N/A",
                Status = s3.Status ?? "Active",
                AssignedAt = DateTime.UtcNow
            });


            // 4️⃣ Save Verification
            _context.PatientVerifications.Add(new PatientVerification
            {
                PatientId = patient.Id,
                VerifiedBy = model.VerifiedBy ?? "N/A",
                Remarks = model.Remarks ?? "N/A",
                Status = "Verified",
                VerifiedDate = DateTime.UtcNow
            });

            await _context.SaveChangesAsync();
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Patients");
        }
    }
}
