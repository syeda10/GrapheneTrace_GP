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
        public async Task<IActionResult> Index()
        {
            var clinicians = await _context.Clinicians
                .Select(c => new ClinicianListVM
                {
                    ClinicianId = c.ClinicianId,
                    Title = c.Title,
                    ClinicianLastName = c.ClinicianLastName,
                    ClinicianFirstName = c.ClinicianFirstName,
                    Speciality = c.ClinicianSpeciality,
                    ClinicianAge = c.ClinicianAge
                })
                .ToListAsync();

            return View(clinicians);
        }

        //Details Action
        public async Task<IActionResult> Details(int id)
        {
            var c = await _context.Clinicians.FindAsync(id);
            if (c == null) return NotFound();

            var vm = new ClinicianDetailsVM
            {
                ClinicianId = c.ClinicianId,
                ClinicianLastName = c.ClinicianLastName,
                ClinicianFirstName = c.ClinicianFirstName,
                Email = c.Email,
                Gender = c.Gender,
                DateOfBirth = c.DateOfBirth,
                Phone = c.Phone,
                Address = c.Address,
                City = c.City,
                PostCode = c.PostCode,
                Status = c.Status
            };

            return View(vm);
        }


        // Edit Action

        public async Task<IActionResult> Edit(int id)
        {
            var c = await _context.Clinicians.FindAsync(id);
            if (c == null) return NotFound();

            return View(c);
        }

        // POST: Admin/Clinicians/Edit
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Clinicians model)
        {
            if (id != model.Id)
                return BadRequest();
            if (!ModelState.IsValid)
                return View(model);
            _context.Clinicians.Update(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

        }

    }
}
