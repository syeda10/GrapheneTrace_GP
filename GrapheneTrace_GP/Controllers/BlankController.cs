using Microsoft.AspNetCore.Mvc;

namespace GrapheneTrace_GP.Controllers
{
    public class BlankController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.UserEmail = "username@gmail.com"; // later: set from auth
            return View();
        }
    }
}
