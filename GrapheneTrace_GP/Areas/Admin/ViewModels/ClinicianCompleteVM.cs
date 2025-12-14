using GrapheneTrace_GP.Areas.Admin.Models;

namespace GrapheneTrace_GP.Areas.Admin.ViewModels
{
    public class ClinicianCompleteVM
    {
        public CliniciansProfile Profile { get; set; }
        public ClinicianProfessionalInfo ProfessionalInfo { get; set; }
        public ClinicianAssignments Assignments { get; set; }
    }
}
