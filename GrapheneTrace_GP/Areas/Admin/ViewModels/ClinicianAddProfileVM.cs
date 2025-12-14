using Microsoft.AspNetCore.Mvc.Rendering;

namespace GrapheneTrace_GP.Areas.Admin.ViewModels
{
    public class ClinicianAddProfileVM
    {
        public int Id { get; set; }

        // Step 01 - Personal Info
        public string? Title { get; set; }
        public string? ClinicianFirstName { get; set; }
        public string? ClinicianLastName { get; set; }
        public string? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? ClinicianAge { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? PostCode { get; set; }

        // Step 02 - Professional Info
        public string Department { get; set; }
        public List<SelectListItem> DepartmentList { get; set; } = new();
        public string? ClinicianSpeciality { get; set; }
        public string? Experience { get; set; }
        public string? Status { get; set; }
        public string? LicenceNo { get; set; }
        public string? Qualifications { get; set; }

        // Step 03 - Assignments
        public string? AssignedWardUnit { get; set; }
        public string? Supervisor { get; set; }
        public string? Notes { get; set; }

    }
}
