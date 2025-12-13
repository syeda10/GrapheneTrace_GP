namespace GrapheneTrace_GP.Areas.Admin.ViewModels
{
    public class ClinicianAddProfileVM
    {

        // Step 01 — Personal Details
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClinicianAge { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string PhotoPath { get; set; }

        // Step 02 — Professional Details
        public string Department { get; set; }
        public string Speciality { get; set; }
        public string Experience { get; set; }
        public string Status { get; set; }
        public string LicenceNo { get; set; }
        public string WorkSchedule { get; set; }
        public string RoomAssigned { get; set; }
        public string Qualifications { get; set; }

        // Step 03 — Assignments
        public string AssignedPatients { get; set; }
        public int CurrentAppointments { get; set; }
        public string AssignedWardUnit { get; set; }
        public string Supervisor { get; set; }
        public string Notes { get; set; }
        public DateTime? LastAssignmentUpdate { get; set; }

        // Step 04 — Review & Save
        public string VerificationStatus { get; set; }
        public string VerifiedBy { get; set; }
        public DateTime? DateReviewed { get; set; }
        public string Remarks { get; set; }

    }
}
