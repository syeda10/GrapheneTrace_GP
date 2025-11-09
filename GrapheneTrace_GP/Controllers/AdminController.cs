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
    }
}
