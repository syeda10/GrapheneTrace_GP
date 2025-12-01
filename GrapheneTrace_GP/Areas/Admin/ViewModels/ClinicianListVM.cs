using System.Collections.Generic;

namespace GrapheneTrace_GP.Areas.Admin.ViewModels
{
    public class ClinicianListVM
    {
        public int ClinicianId { get; set; }
        public string Title { get; set; } = "";
        public string ClinicianLastName { get; set; } = "";
        public string ClinicianFirstName { get; set; } = "";
        public string Speciality { get; set; } = "";
        public string ClinicianAge { get; set; } = "";
        
    }
}

