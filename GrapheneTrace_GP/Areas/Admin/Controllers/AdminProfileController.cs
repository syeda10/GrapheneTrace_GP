using Microsoft.AspNetCore.Mvc;
using GrapheneTrace_GP.Areas.Admin.ViewModels;

namespace GrapheneTrace_GP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminProfileController : Controller
    {
        public IActionResult Index()
        {
            var vm = new AdminProfileVM
            {
                FullName = "Catherine Hobson",
                Email = "cat23hobson@admin.co.uk",
                Phone = "+44 7894 223366",
                AdminId = "CH0823",
                Role = "Admin",
                ProfileImagePath = "/images/profile/catherine.png",

                // Last Login Info
                LastLogin = DateTime.Now.AddHours(-5),
                LastPasswordChange = DateTime.Now.AddDays(-30),
                LastProfileUpdate = DateTime.Now.AddDays(-2),

                // Security Summary
                Is2FAEnabled = false,
                PasswordStrength = "Strong",
                ActiveSessions = 2,
                SuspiciousActivity = "None",

                // Permissions
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
