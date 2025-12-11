namespace GrapheneTrace_GP.Areas.Admin.ViewModels
{
    public class AdminProfileVM
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AdminId { get; set; }
        public string Role { get; set; }

        // account settings
        public bool PasswordChange { get; set; }
        public bool NotificationPreferences { get; set; }
        public bool LanguageTimezone { get; set; }
        public bool TwoFactorAuth { get; set; }
        public bool SecurityPrivacy { get; set; }

        // privileges
        public bool EditProfiles { get; set; }
        public bool AddProfiles { get; set; }
        public bool ViewAlerts { get; set; }
        public bool ManageSettings { get; set; }
        public bool ViewReports { get; set; }
        public bool MessageClinician { get; set; }
        public bool ViewAppointments { get; set; }
    }
}

