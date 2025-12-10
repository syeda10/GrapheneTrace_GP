using Microsoft.CodeAnalysis.Scripting;
using System;

namespace GrapheneTrace_GP.Areas.Admin.ViewModels
{
    public class PatientDetailsVM
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string LastName { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Gender { get; set; } = "";
        public DateTime DateOfBirth { get; set; } = DateTime.MinValue;
        public string Phone { get; set; } = "";
        public string Address { get; set; } = "";
        public string City { get; set; } = "";
        public string PostCode { get; set; } = "";
        public string Status { get; set; } = "";


        //Heat Map Table
        public List<float[]> HeatMapData { get; set; } = new();

        //Appointment Table
        public List<AppointmentsRow> AllAppointments { get; set; } = new();
        public List<AppointmentsRow> CompletedAppointments { get; set; } = new();
    }

    public class AppointmentsRow
    {
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; } = DateTime.MinValue;
        public string TreatmentType { get; set; } = "";
        public string Comments { get; set; } = "";
        public string NextAppointment { get; set; } = "";
    }
}


