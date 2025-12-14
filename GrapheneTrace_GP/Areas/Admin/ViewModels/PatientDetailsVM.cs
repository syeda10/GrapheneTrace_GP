using GrapheneTrace_GP.Areas.Admin.Models;

namespace GrapheneTrace_GP.Areas.Admin.ViewModels
{
    public class PatientDetailsVM
    {
        // Full Patient entity (best for view)
        public Patient Patient { get; set; }

        // Heatmap data (40x40 cropped matrix)
        public List<float[]> Heatmap { get; set; } = new();

        // Appointments
        public List<AppointmentVM> AllAppointments { get; set; } = new();
        public List<AppointmentVM> CompletedAppointments { get; set; } = new();
    }
}



