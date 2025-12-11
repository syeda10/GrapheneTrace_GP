using Microsoft.AspNetCore.Mvc;

namespace GrapheneTrace_GP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HelpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
