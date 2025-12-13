namespace GrapheneTrace_GP.Areas.Admin.Models.ClinicianAddProfile
{
    public class ClinicianAssignments
    {
        public int Id { get; set; }
        public int ClinicianId { get; set; }

        // assignment fields used by controller and view models
        public string? AssignedPatients { get; set; }
        public int? CurrentAppointments { get; set; }
        public string? AssignedWard { get; set; }
        public string? Supervisor { get; set; }
        public string? Notes { get; set; }
        public DateTime? LastAssignmentUpdate { get; set; }

        // optional/extra fields referenced elsewhere
        public string? Department { get; set; }
        public string? Status { get; set; }

        // navigation
        public ClinicianProfile? Clinician { get; set; }
    }
}