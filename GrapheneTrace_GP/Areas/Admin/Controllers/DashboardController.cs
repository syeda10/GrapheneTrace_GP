using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GrapheneTrace_GP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.UserEmail = "username@gmail.com"; // later: set from auth
            return View();
        }
    }
}
