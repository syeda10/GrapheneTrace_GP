namespace GrapheneTrace_GP.Areas.Admin.Models
{
    public class ClinicianProfessionalInfo
    {
        public int Id { get; set; }
        public int ClinicianId { get; set; }

        public string Department { get; set; } = null!;
        public string Speciality { get; set; } = null!;
        public string Experience { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string LicenceNo { get; set; } = null!;
        public string WorkSchedule { get; set; } = null!;
        public string RoomAssigned { get; set; } = null!;
        public string Qualifications { get; set; } = null!;

        public CliniciansProfile Clinician { get; set; }
    }
}
