namespace GrapheneTrace_GP.Areas.Admin.Models.ClinicianAddProfile
{
    public class ClinicianVerification
    {

        public int Id { get; set; }
        public int ClinicianId { get; set; }

        public string? VerificationStatus { get; set; }
        public string? VerifiedBy { get; set; }
        public DateTime? DateReviewed { get; set; }
        public string? Remarks { get; set; }
        public string? ProfileStatus { get; set; }

        public ClinicianProfile Clinician { get; set; }

    }
}
