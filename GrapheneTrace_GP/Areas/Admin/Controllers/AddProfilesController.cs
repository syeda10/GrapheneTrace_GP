using GrapheneTrace_GP.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GrapheneTrace_GP.Areas.Admin.Controllers
{
    public class AddProfilesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        //Create
        // GET: Admin/Clinicians/Details/
       /* [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Clinicians/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Clinicians model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _context.Clinicians.Add(model);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }*/

    }
}
