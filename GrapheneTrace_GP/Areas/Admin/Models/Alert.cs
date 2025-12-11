using System;

namespace GrapheneTrace_GP.Areas.Admin.Models
{
    public class Alert
    {
        public int Id { get; set; }  // Auto identity

        public string AlertCode { get; set; } = "";  // e.g. ALT-01

        public string Type { get; set; } = "";  // Patient / Clinician / System

        public string Message { get; set; } = "";

        public string Priority { get; set; } = ""; // Low / Medium / High / Critical

        public string Status { get; set; } = ""; // Read / Unread

        public string? RelatedId { get; set; }  // e.g. patientId or clinicianId

        public DateTime CreatedAt { get; set; }
    }
}
