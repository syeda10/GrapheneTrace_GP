using Microsoft.AspNetCore.Mvc;

namespace GrapheneTrace_GP.Areas.Admin.Controllers
{
    public class AlertsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
