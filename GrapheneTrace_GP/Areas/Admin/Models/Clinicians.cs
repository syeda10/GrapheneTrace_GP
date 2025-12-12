namespace GrapheneTrace_GP.Areas.Admin.Models
{
    public class Clinicians
    {
        public int Id { get; set; }

        public string Title { get; set; } = "";
        public string ClinicianLastName { get; set; } = "";
        public string ClinicianFirstName { get; set; } = "";

        // Legacy system fields
        public int ClinicianId { get; set; }  // KEEP IT
        public string ClinicianSpeciality { get; set; } = "";
        public string ClinicianAge { get; set; } = "";

        // Common fields
        public string Email { get; set; } = "";
        public string Gender { get; set; } = "";
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; } = "";
        public string Address { get; set; } = "";
        public string City { get; set; } = "";
        public string PostCode { get; set; } = "";
        public string Status { get; set; } = "";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public List<ClinicianAlert> Alerts { get; set; } = new();
        public List<Patient> Patients { get; set; } = new();
    }
}

