using GrapheneTrace_GP.Areas.Admin.Models.ClinicianAddProfile;

public class ClinicianProfile
{
    public int Id { get; set; }

    public string? Title { get; set; }
    public string? ClinicianFirstName { get; set; }
    public string? ClinicianLastName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Gender { get; set; }
    public DateTime? DateOfBirth { get; set; }

    public string? PhotoPath { get; set; }

    public string? Address { get; set; }
    public string? City { get; set; }
    public string? PostCode { get; set; }

    public string? Status { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;


    public ClinicianProfessionalInfo? ProfessionalInfo { get; set; }
    public ClinicianAssignments? Assignments { get; set; }
    public ClinicianVerification? Verification { get; set; }
}
