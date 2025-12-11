using Microsoft.AspNetCore.Mvc;
using GrapheneTrace_GP.Areas.Admin.ViewModels;

namespace GrapheneTrace_GP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminProfileController : Controller
    {
        public IActionResult Index()
        {
            // TEMP STATIC DATA — replace with database values later
            var vm = new AdminProfileVM
            {
                FullName = "Catherine Hobson",
                Email = "cat23hobson@admin.co.uk",
                Phone = "+44 7894 223366",
                AdminId = "CH0823",
                Role = "Admin",

                PasswordChange = true,
                NotificationPreferences = false,
                LanguageTimezone = true,
                TwoFactorAuth = false,
                SecurityPrivacy = true,

                EditProfiles = true,
                AddProfiles = true,
                ViewAlerts = true,
                ManageSettings = true,
                ViewReports = false,
                MessageClinician = false,
                ViewAppointments = true
            };

            return View(vm);
        }
    }
}
