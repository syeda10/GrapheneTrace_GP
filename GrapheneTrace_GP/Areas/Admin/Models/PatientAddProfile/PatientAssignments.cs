namespace GrapheneTrace_GP.Areas.Admin.Models.PatientAddProfile
{
    public class PatientAssignments
    {
        public int Id { get; set; }
        public int PatientId { get; set; }

        public string? AssignedDoctor { get; set; }
        public string? Department { get; set; }
        public string? EmergencyContact { get; set; }
        public string? Relationship { get; set; }
        public string? ContactNo { get; set; }
        public string? VaccinationStatus { get; set; }
        public DateTime AssignedAt { get; set; }
        public string? Purpose { get; set; }
        public string? Status { get; set; }
        public string? Ward { get; set; }

        public int ClinicianId { get; set; } // CL1234-CL5678-...

        public PatientProfile? Patient { get; set; }
    }
}
