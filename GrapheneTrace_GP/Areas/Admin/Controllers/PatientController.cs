using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GrapheneTrace_GP.Data;

namespace GrapheneTrace_GP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PatientsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PatientsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var patients = await _context.Patients.ToListAsync();
            return View(patients);
        }
    }
}
