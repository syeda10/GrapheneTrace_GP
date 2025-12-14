namespace GrapheneTrace_GP.Areas.Admin.Models
{
    public class ClinicianAssignments
    {
        public int Id { get; set; }
        public int ClinicianId { get; set; }

        public string AssignedPatients { get; set; } = null!;
        public int CurrentAppointments { get; set; }
        public string AssignedWardUnit { get; set; } = null!;
        public string Supervisor { get; set; } = null!;
        public DateTime LastAssignmentUpdate { get; set; }

        public CliniciansProfile Clinician { get; set; }
    }
}
