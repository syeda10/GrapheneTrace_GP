using System.ComponentModel.DataAnnotations;

namespace GrapheneTrace_GP.Areas.Admin.Models
{
    public class Patient
    {
        public int PatientId { get; set; }

        // Step 01 — Personal Details
        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PatientAge { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? PostCode { get; set; }
        public string? NHSNumber { get; set; }
        public string? Status { get; set; }


        // Step 02 — Medical Info
        public string? BloodGroup { get; set; }
        public string? Weight { get; set; }
        public string? Height { get; set; }
        public string? Allergies { get; set; }
        public string? ChronicConditions { get; set; }
        public string? CurrentMedication { get; set; }
        public string? Smoking { get; set; }
        public string? PastSurgeries { get; set; }

        // Step 03 — Assignments
        public string? Department { get; set; }
        public string? EmergencyContactName { get; set; }
        public string? Relationship { get; set; }
        public string? EmergencyContactNo { get; set; }
        public string? VaccinationStatus { get; set; }
        public DateTime? LastMedicalCheckup { get; set; }
        public string? Purpose { get; set; }
        public int? ClinicianId { get; set; }

        // Navigation
        public Clinicians? Clinician { get; set; }

        // Step 04 — Review Info
        public string? VerificationStatus { get; set; }
        public string? VerifiedBy { get; set; }
        public DateTime? DateReviewed { get; set; }
        public string? Remarks { get; set; } 

    }

}
