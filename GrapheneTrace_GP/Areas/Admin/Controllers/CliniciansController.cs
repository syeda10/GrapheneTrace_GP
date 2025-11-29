using Microsoft.AspNetCore.Mvc;

namespace GrapheneTrace_GP.Areas.Admin.Controllers
{
    public class CliniciansController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
