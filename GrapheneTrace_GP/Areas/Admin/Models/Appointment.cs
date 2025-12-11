using GrapheneTrace_GP.Areas.Admin.Models;
using System;

namespace GrapheneTrace_GP.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }

        public int PatientId { get; set; }   // FK to Patient table

        public DateTime AppointmentDate { get; set; }

        public string TreatmentType { get; set; }
        public string Comments { get; set; }

        public DateTime? NextAppointment { get; set; }
        public bool IsCompleted { get; set; }

        // Navigation property
        public Patient Patient { get; set; }
    }
}
