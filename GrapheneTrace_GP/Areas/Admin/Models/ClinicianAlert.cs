using System;
using System.ComponentModel.DataAnnotations;

namespace GrapheneTrace_GP.Areas.Admin.Models
{
    public class ClinicianAlert
    {
        [Key] public int AlertId { get; set; }   // PRIMARY KEY
        public int ClinicianId { get; set; }  // Foreign Key

        public string AlertType { get; set; } = "";
        public DateTime AlertDateTime { get; set; }

        public Clinicians Clinician { get; set; }
    }
}
