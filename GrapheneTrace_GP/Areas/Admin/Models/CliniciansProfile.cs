namespace GrapheneTrace_GP.Areas.Admin.Models
{
    public class CliniciansProfile
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;
        public string ClinicianFirstName { get; set; } = null!;
        public string ClinicianLastName { get; set; } = null!;
        public string ClinicianAge { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public string Status { get; set; } = "Active";

        // Relationships
        public ClinicianProfessionalInfo? ProfessionalInfos { get; set; }
        public ClinicianAssignments? Assignments { get; set; }
    }
}

