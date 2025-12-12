namespace GrapheneTrace_GP.Areas.Admin.Models.ClinicianAddProfile
{
    public class ClinicianProfessionalInfo
    {

        public int Id { get; set; }
        public int ClinicianId { get; set; }

        public string? Department { get; set; }
        public string? Speciality { get; set; }
        public string? ExperienceYears { get; set; }
        public string? LicenceNo { get; set; }
        public string? WorkSchedule { get; set; }
        public string? RoomAssigned { get; set; }
        public string? Qualifications { get; set; }

        public ClinicianProfile Clinician { get; set; }

    }
}
