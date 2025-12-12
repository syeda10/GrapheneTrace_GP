namespace GrapheneTrace_GP.Areas.Admin.Models.PatientAddProfile
{
    public class PatientVerification
    {
        public int Id { get; set; }
        public int PatientId { get; set; }

        public string? VerificationStatus { get; set; }
        public string? VerifiedBy { get; set; }
        public DateTime? DateReviewed { get; set; }
        public string? Remarks { get; set; }
        public string? ProfileStatus { get; set; }
        public string? Status { get; set; }
        public DateTime VerifiedDate { get; set; }

        public PatientProfile? Patient { get; set; }
    }
}
