using System.Collections.Generic;

namespace GrapheneTrace_GP.Areas.Admin.ViewModels
{
    public class DashboardVM
    {
        //This for stats card on admin dashboard
        public int ActiveClinicians { get; set; }
        public int ActivePatients { get; set; }
        public int NextDayAppointments { get; set; }

        //This is for Donut chart on admin dashboard
        public int TotalActivePatients { get; set; }
        public int TotalInactivePatients { get; set; }

        //This is for Bar chart on admin dashboard
        public List<int> MonthlyNewPatients { get; set; } = new();
        public List<string> MonthLabels { get; set; } = new();

        //Appointments table data
        public List<AppointmentRow> UpcomingAppointments { get; set; } = new();
    }

    public class AppointmentRow
    {
        public int sno { get; set; }
        public string Title { get; set; } = "";
        public string PatientName { get; set; } = "";
        public int PatientId { get; set; } 
        public string ClinicianName { get; set; } = "";
        public string Age { get; set; } = "";
        public string Status { get; set; } = "";
    }
}
