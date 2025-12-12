namespace GrapheneTrace_GP.Areas.Admin.ViewModels
{
    public class AdminProfileVM
    {
        // Basic Info
        public string FullName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public string AdminId { get; set; } = "";
        public string Role { get; set; } = "Admin";

        // Profile Photo
        public string ProfileImagePath { get; set; } = "/images/profile/default.png";

        // Last Login Info
        public DateTime LastLogin { get; set; }
        public DateTime LastPasswordChange { get; set; }
        public DateTime LastProfileUpdate { get; set; }

        // Security Summary
        public bool Is2FAEnabled { get; set; }
        public string PasswordStrength { get; set; } = "Strong";
        public int ActiveSessions { get; set; }
        public string SuspiciousActivity { get; set; } = "None";

        // Admin Actions
        public bool CanResetPassword => true;
        public bool CanLockAccount => true;
        public bool CanViewLoginHistory => true;
        public bool CanDownloadLogs => true;

        // Permissions Matrix
        public bool EditProfiles { get; set; }
        public bool AddProfiles { get; set; }
        public bool ViewAlerts { get; set; }
        public bool ManageSettings { get; set; }
        public bool ViewReports { get; set; }
        public bool MessageClinician { get; set; }
        public bool ViewAppointments { get; set; }
    }
}
