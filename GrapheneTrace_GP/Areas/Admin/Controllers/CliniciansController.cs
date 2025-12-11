using GrapheneTrace_GP.Areas.Admin.ViewModels;
using GrapheneTrace_GP.Areas.Admin.Models;
using GrapheneTrace_GP.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GrapheneTrace_GP.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class CliniciansController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CliniciansController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ========== INDEX ==========
        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var clinicians = await _context.Clinicians
                .Select(c => new ClinicianListVM
                {
                    ClinicianId = c.ClinicianId,
                    Title = c.Title,
                    ClinicianLastName = c.ClinicianLastName,
                    ClinicianFirstName = c.ClinicianFirstName,
                    ClinicianSpeciality = c.ClinicianSpeciality,
                    ClinicianAge = c.ClinicianAge
                })
                .ToListAsync();

            return View(clinicians);
        }

        // ========== DETAILS ==========
        [HttpGet("Details/{id:int}")]
        public async Task<IActionResult> Details(int id)
        {
            var clinician = await _context.Clinicians
            .Include(c => c.Patients) // <- LOAD ASSIGNED PATIENTS
            .Include(c => c.Alerts)
            .FirstOrDefaultAsync(c => c.ClinicianId == id);


            if (clinician == null) return NotFound();

            var vm = new ClinicianDetailsVM
            {
                ClinicianId = clinician.ClinicianId,
                ClinicianLastName = clinician.ClinicianLastName,
                ClinicianFirstName = clinician.ClinicianFirstName,
                Email = clinician.Email,
                Gender = clinician.Gender,
                DateOfBirth = clinician.DateOfBirth,
                Phone = clinician.Phone,
                Address = clinician.Address,
                City = clinician.City,
                PostCode = clinician.PostCode,
                Status = clinician.Status,
                Clinician = clinician,

                //Alerts

                Alerts = clinician.Alerts?
                .OrderByDescending(a => a.AlertDateTime)
                .Select((a, index) => new ClinicianAlertRow
                {
                    AlertId = index + 1,
                    AlertType = a.AlertType,
                    AlertDateTime = a.AlertDateTime
                })
                .ToList() ?? new List<ClinicianAlertRow>(),


                //AssignedPatients
                AssignedPatients = clinician.Patients?
                .Select((p, index) => new AssignedPatientRow
                {
                  Sno = index + 1,
                  PatientLastName = p.LastName,
                  PatientFirstName = p.FirstName,
                  PatientId = p.PatientId,
                  Age = p.PatientAge
                })
                .ToList() ?? new List<AssignedPatientRow>(),

            };

            return View(vm);
        }

        // ========== EDIT (GET) ==========
        [HttpGet("Edit/{id:int}")]
        public async Task<IActionResult> Edit(int id)
        {
            var c = await _context.Clinicians
                                 .FirstOrDefaultAsync(x => x.ClinicianId == id);

            if (c == null) return NotFound();

            return View(c);
        }

        // ========== EDIT (POST) ==========
        [HttpPost("Edit/{id:int}")]
        public async Task<IActionResult> Edit(int id, Clinicians model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var existing = await _context.Clinicians
                                         .FirstOrDefaultAsync(x => x.ClinicianId == id);

            if (existing == null) return NotFound();

            _context.Entry(existing).CurrentValues.SetValues(model);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
