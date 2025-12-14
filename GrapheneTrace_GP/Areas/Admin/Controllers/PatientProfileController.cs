using GrapheneTrace_GP.Areas.Admin.Models;
using GrapheneTrace_GP.Areas.Admin.ViewModels;
using GrapheneTrace_GP.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GrapheneTrace_GP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PatientProfileController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PatientProfileController(ApplicationDbContext db)
        {
            _db = db;
        }


        // ----------------------------------------------------------
        // STEP 01 — CREATE BASIC PATIENT ENTRY
        // ----------------------------------------------------------
        public IActionResult Step01()
        {
            return View(new PatientAddProfileVM());
        }

        [HttpPost]
        public IActionResult Step01(PatientAddProfileVM vm)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors)
                                              .Select(e => e.ErrorMessage)
                                              .ToList();
            }

            // 1. Create a new patient entry in DB
            var patient = new Patient
            {
                Title = vm.Title,
                FirstName = vm.FirstName,
                LastName = vm.LastName,
                DateOfBirth = vm.DateOfBirth,
                Gender = vm.Gender,
                Email = vm.Email,
                Phone = vm.Phone,
                Address = vm.Address,
                City = vm.City,
                PostCode = vm.PostCode,
                NHSNumber = vm.NHSNumber
            };

            _db.Patients.Add(patient);
            _db.SaveChanges();

            // 2. Must save generated PatientId back to VM
            vm.PatientId = patient.PatientId;

            return RedirectToAction("Step02", new { id = patient.PatientId });
            ;
        }



        // ----------------------------------------------------------
        // STEP 02 — MEDICAL INFO
        // ----------------------------------------------------------
        [HttpGet]
        public IActionResult Step02(int id)
        {
            var patient = _db.Patients.Find(id);
            if (patient == null) return NotFound();

            var vm = new PatientAddProfileVM
            {
                PatientId = patient.PatientId
            };


            return View(vm);
        }


        [HttpPost]
        public IActionResult Step02(PatientAddProfileVM vm)
        {
            var patient = _db.Patients.Find(vm.PatientId);

            if (patient == null) return NotFound();

            // Save Medical Info into existing table
            patient.BloodGroup = vm.BloodGroup;
            patient.Weight = vm.Weight;
            patient.Height = vm.Height;
            patient.Allergies = vm.Allergies;
            patient.ChronicConditions = vm.ChronicConditions;
            patient.CurrentMedication = vm.CurrentMedication;
            patient.Smoking = vm.Smoking;
            patient.PastSurgeries = vm.PastSurgeries;

            _db.SaveChanges();

            return RedirectToAction("Step03", new { id = patient.PatientId });
        }


        // ----------------------------------------------------------
        // STEP 03 — ASSIGNMENTS
        // ----------------------------------------------------------
        public IActionResult Step03(int id)
        {
            var patient = _db.Patients.Find(id);
            if (patient == null) return NotFound();

            return View(new PatientAddProfileVM { PatientId = id });
        }

        [HttpPost]
        public IActionResult Step03(PatientAddProfileVM vm)
        {
            var patient = _db.Patients.Find(vm.PatientId);

            if (patient == null) return NotFound();

            patient.Department = vm.Department;
            patient.EmergencyContactName = vm.EmergencyContactName;
            patient.Relationship = vm.Relationship;
            patient.EmergencyContactNo = vm.EmergencyContactNo;
            patient.VaccinationStatus = vm.VaccinationStatus;
            patient.LastMedicalCheckup = vm.LastMedicalCheckup;
            patient.Purpose = vm.Purpose;
            patient.ClinicianId = vm.ClinicianId;

            _db.SaveChanges();

            return RedirectToAction("Step04", new { id = patient.PatientId });
        }


        // STEP 04 — REVIEW PAGE
        public IActionResult Step04(int id)
        {
            var patient = _db.Patients
                .Include(p => p.Clinician)
                .FirstOrDefault(p => p.PatientId == id);

            if (patient == null)
                return NotFound();

            return View(patient);
        }
        public IActionResult Finish(int id)
        {
            return RedirectToAction("Index", "Patient", new { area = "Admin" });
        }

    }
}
