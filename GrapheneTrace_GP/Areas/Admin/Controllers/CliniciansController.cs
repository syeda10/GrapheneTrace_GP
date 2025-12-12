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




        // DETAILS PAGE - for NEW AddProfile clinicians
        public async Task<IActionResult> Details(int id)
        {
            var clinician = await _context.ClinicianProfile
                .Include(c => c.ProfessionalInfo)
                .Include(c => c.Assignments)
                .Include(c => c.Verification)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (clinician == null)
                return NotFound();

            return View(clinician);
        }
    }
}
