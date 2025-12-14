using GrapheneTrace_GP.Areas.Admin.Models;
using GrapheneTrace_GP.Areas.Admin.ViewModels;
using GrapheneTrace_GP.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GrapheneTrace_GP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ClinicianProfileController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ClinicianProfileController(ApplicationDbContext db)
        {
            _db = db;
        }

        private List<SelectListItem> GetDepartmentList()
        {
            return new List<SelectListItem>
    {
        new SelectListItem { Value = "Cardiology", Text = "Cardiology" },
        new SelectListItem { Value = "Neurology", Text = "Neurology" },
        new SelectListItem { Value = "Orthopaedics", Text = "Orthopaedics" },
        new SelectListItem { Value = "Radiology", Text = "Radiology" },
        new SelectListItem { Value = "General Medicine", Text = "General Medicine" }
        // add more as needed
    };
        }


        // ----------------------------
        // STEP 01 - PERSONAL INFO
        // ----------------------------
        public IActionResult Step01()
        {
            return View(new ClinicianAddProfileVM());
        }

        [HttpPost]
        public IActionResult Step01(ClinicianAddProfileVM vm)
        {
            var clinician = new Clinicians
            {
                Title = vm.Title ?? "",
                ClinicianFirstName = vm.ClinicianFirstName ?? "",
                ClinicianLastName = vm.ClinicianLastName ?? "",

                ClinicianId = new Random().Next(10000, 99999),

                // FIXED — handle nulls safely
                ClinicianSpeciality = vm.ClinicianSpeciality ?? "",
                ClinicianAge = vm.ClinicianAge ?? "",

                DateOfBirth = vm.DateOfBirth ?? DateTime.UtcNow,
                Gender = vm.Gender ?? "",
                Email = vm.Email ?? "",
                Phone = vm.Phone ?? "",
                Address = vm.Address ?? "",
                City = vm.City ?? "",
                PostCode = vm.PostCode ?? "",
                Status = "Active",

                AssignedWardUnit = "",
                Supervisor = "",

                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };


            _db.Clinicians.Add(clinician);
            _db.SaveChanges();   // THIS WILL NOW SUCCEED

            return RedirectToAction("Step02", new { id = clinician.Id });
        }


        // ----------------------------
        // STEP 02 - PROFESSIONAL INFO
        // ----------------------------
        [HttpGet]
        public IActionResult Step02(int id)
        {
            var vm = new ClinicianAddProfileVM
            {
                Id = id,
                DepartmentList = new List<SelectListItem>
                {
                    new SelectListItem { Value = "Cardiology", Text = "Cardiology" },
                    new SelectListItem { Value = "Neurology", Text = "Neurology" },
                    new SelectListItem { Value = "Pediatrics", Text = "Pediatrics" },
                    new SelectListItem { Value = "Surgery", Text = "Surgery" },
                    new SelectListItem { Value = "Psychiatry", Text = "Psychiatry" },
                    new SelectListItem { Value = "Gynaecology", Text = "Gynaecology" },
                    new SelectListItem { Value = "Orthopaedics", Text = "Orthopaedics" },
                    new SelectListItem { Value = "Dermatology", Text = "Dermatology" },
                    new SelectListItem { Value = "General Medicine", Text = "General Medicine" }
                }
            };

            return View(vm);
        }

        


        [HttpPost]
        public IActionResult Step02(ClinicianAddProfileVM vm)
        {
            var clinician = _db.Clinicians.Find(vm.Id);
            if (clinician == null) return NotFound();

            clinician.ClinicianSpeciality = vm.ClinicianSpeciality;
            clinician.Status = vm.Status;

            _db.SaveChanges();

            return RedirectToAction("Step03", new { id = clinician.Id });
        }

        // ----------------------------
        // STEP 03 - ASSIGNMENTS
        // ----------------------------
        public IActionResult Step03(int id)
        {
            return View(new ClinicianAddProfileVM { Id = id });
        }

        [HttpPost]
        public IActionResult Step03(ClinicianAddProfileVM vm)
        {
            var clinician = _db.Clinicians.Find(vm.Id);
            if (clinician == null) return NotFound();

            clinician.AssignedWardUnit = vm.AssignedWardUnit;
            clinician.Supervisor = vm.Supervisor;

            _db.SaveChanges();

            return RedirectToAction("Step04", new { id = clinician.Id });
        }

        // ----------------------------
        // STEP 04 - REVIEW
        // ----------------------------
        public IActionResult Step04(int id)
        {
            var clinician = _db.Clinicians.Find(id);
            if (clinician == null) return NotFound();

            var vm = new ClinicianAddProfileVM
            {
                Id = clinician.Id,
                ClinicianFirstName = clinician.ClinicianFirstName,
                ClinicianLastName = clinician.ClinicianLastName,
                Title = clinician.Title,
                Email = clinician.Email,
                Phone = clinician.Phone,
                Gender = clinician.Gender,
                DateOfBirth = clinician.DateOfBirth,
                Address = clinician.Address,
                City = clinician.City,
                PostCode = clinician.PostCode,

                // Step 02 fields
                DepartmentList = GetDepartmentList(),
                ClinicianSpeciality = clinician.ClinicianSpeciality,
                Status = clinician.Status,

                // Step 03 fields
                AssignedWardUnit = clinician.AssignedWardUnit,
                Supervisor = clinician.Supervisor
            };

            return View(vm);  
        }
        public IActionResult SaveFinal(ClinicianAddProfileVM vm)
        {
            return RedirectToAction("Index", "Clinicians", new { area = "Admin" });
        }


    }

}
