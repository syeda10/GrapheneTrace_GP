using GrapheneTrace_GP.Areas.Admin.Models;
using GrapheneTrace_GP.Areas.Admin.ViewModels;
using GrapheneTrace_GP.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GrapheneTrace_GP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CliniciansController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CliniciansController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int page = 1, int pageSize = 10)
        {
            var query = _context.Clinicians
                .OrderBy(c => c.Id)
                .AsQueryable();

            int totalCount = await query.CountAsync();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            var clinicians = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var vm = clinicians.Select(c => new ClinicianListVM
            {
                Id = c.Id,
                Title = c.Title ?? "N/A",
                ClinicianFirstName = c.ClinicianFirstName ?? "N/A",
                ClinicianLastName = c.ClinicianLastName ?? "N/A",
                ClinicianSpeciality = c.ClinicianSpeciality ?? "N/A",
                Age = c.DateOfBirth != DateTime.MinValue
                        ? (int)((DateTime.Now - c.DateOfBirth).TotalDays / 365.25)
                        : 0
            }).ToList();

            ViewBag.Page = page;
            ViewBag.TotalPages = totalPages;

            return View(vm);
        }

        // FIXED DETAILS PAGE
        public async Task<IActionResult> Details(int id)
        {
            var clinician = await _context.Clinicians
                .FirstOrDefaultAsync(c => c.Id == id);

            if (clinician == null)
                return NotFound();

            // FETCH ALERTS — FIXED
            var alerts = _context.ClinicianAlerts
                .Where(a => a.ClinicianId == id)
                .OrderByDescending(a => a.AlertDateTime)
                .AsEnumerable()      
                .Select((a, index) => new ClinicianAlertRow
                {
                    Sno = index + 1,
                    AlertType = a.AlertType,
                    AlertDateTime = a.AlertDateTime
                })
                .ToList();            // Not ToListAsync()

            //Assigned patients

            var rawPatients = _context.Patients
                .Where(p => p.ClinicianId == id)
                .OrderBy(p => p.PatientId)
                .ToList();


            var assignedPatients = rawPatients
            .Select((p, index) => new AssignedPatientRow
            {
                Sno = index + 1,
                PatientId = p.PatientId,
                PatientFirstName = p.FirstName,
                PatientLastName = p.LastName,

                Age = (p.DateOfBirth != DateTime.MinValue)
                ? (int)((DateTime.Now - p.DateOfBirth).Value.TotalDays / 365.25)
                : 0

            })
            .ToList();


            // not ToListAsync()


            // BUILD FINAL VIEW MODEL
            var vm = new ClinicianDetailsVM
            {
                ClinicianId = clinician.Id,
                ClinicianFirstName = clinician.ClinicianFirstName,
                ClinicianLastName = clinician.ClinicianLastName,
                Email = clinician.Email,
                Gender = clinician.Gender,
                DateOfBirth = clinician.DateOfBirth,
                City = clinician.City,
                Address = clinician.Address,
                PostCode = clinician.PostCode,
                Phone = clinician.Phone,
                Status = clinician.Status,

                Alerts = alerts,
                AssignedPatients = assignedPatients
            };

            return View(vm);
        }




    }
}
