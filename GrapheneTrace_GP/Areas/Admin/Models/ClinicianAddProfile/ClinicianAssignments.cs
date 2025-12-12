namespace GrapheneTrace_GP.Areas.Admin.Models.ClinicianAddProfile
{
    public class ClinicianAssignments
    {

        public int Id { get; set; }
        public int ClinicianId { get; set; }

        public string? AssignedPatients { get; set; } // PT4526-PT9658-...
        public int? CurrentAppointments { get; set; }
        public string? AssignedWard { get; set; }
        public string? Supervisor { get; set; }
        public string? Notes { get; set; }
        public DateTime? LastAssignmentUpdate { get; set; }

        public ClinicianProfile Clinician { get; set; }

    }
}
