using Microsoft.AspNetCore.Mvc;

namespace GrapheneTrace_GP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Redirect root URL → Admin Dashboard
            return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
        }
    }
}
