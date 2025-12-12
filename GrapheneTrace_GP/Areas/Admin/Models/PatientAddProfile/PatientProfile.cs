namespace GrapheneTrace_GP.Areas.Admin.Models.PatientAddProfile
{
    public class PatientProfile
    {
        public int Id { get; set; }

        // Step 1
        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? NHSNumber { get; set; }
        public string? PhotoPath { get; set; }

        public string? Address { get; set; }
        public string? City { get; set; }
        public string? PostCode { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Navigation
        public PatientMedicalInfo? MedicalInfo { get; set; }
        public PatientAssignments? Assignments { get; set; }
        public PatientVerification? Verification { get; set; }
    }

}
