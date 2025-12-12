namespace GrapheneTrace_GP.Areas.Admin.ViewModels.AddClinician
{
    public class Step01PersonalVM
    {

        public string ClinicianFirstName { get; set; }
        public string ClinicianLastName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }

        // You MUST add these because controller uses them
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }

        // For Photo upload (optional for now)
        public string PhotoPath { get; set; }

    }
}
