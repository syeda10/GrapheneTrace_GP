using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GrapheneTrace_GP.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        } //laiba's comment

        public IActionResult Index()
        {
            return View();
        }
        // Added admin main page options
        public IActionResult Dashboard() 
            {
            return View();
        }

        public IActionResult Clinicians()
            {
            return View();
        }

        public IActionResult Patients()
            {
            return View();
        }

        public IActionResult AddProfile()
            {
            return View();
        }

        public IActionResult Alerts() 
            {
            return View();
        }

        public IActionResult Settings() 
            {
            return View();
        }

        public IActionResult Help() 
            {
            return View();
        }

        public IActionResult Profile() 
            {
            return View();
        }
    }
}
