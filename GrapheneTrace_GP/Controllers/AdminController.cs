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
        // Added admin-related action methods
        public IActionResult Dashboard() => View();
        public IActionResult Clinicians() => View();
        public IActionResult Patients() => View();
        public IActionResult AddProfile() => View();
        public IActionResult Reports() => View();
        public IActionResult Alerts() => View();
        public IActionResult Settings() => View();
        public IActionResult Help() => View();
        public IActionResult Profile() => View();
    }
}
