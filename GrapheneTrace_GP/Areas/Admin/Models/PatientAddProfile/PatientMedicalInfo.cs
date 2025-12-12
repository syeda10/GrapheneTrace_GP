namespace GrapheneTrace_GP.Areas.Admin.Models.PatientAddProfile
{
    public class PatientMedicalInfo
    {
        public int Id { get; set; }
        public int PatientId { get; set; }

        public string? BloodGroup { get; set; }
        public string? Weight { get; set; }
        public string? Height { get; set; }
        public string? Allergies { get; set; }
        public string? Conditions { get; set; }
        public string? Medications { get; set; }
        public string? Smoking { get; set; }
        public string? PastSurgeries { get; set; }

        public string? Notes { get; set; }

        public PatientProfile? Patient { get; set; }


    }
}
