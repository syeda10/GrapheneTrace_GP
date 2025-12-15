using GrapheneTrace_GP.Areas.Admin.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Appointment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]  
    public int AppointmentId { get; set; }

    public int PatientId { get; set; }
    public Patient Patient { get; set; }

    public DateTime AppointmentDate { get; set; }
    public string TreatmentType { get; set; }
    public string Comments { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime? NextAppointment { get; set; }
}

