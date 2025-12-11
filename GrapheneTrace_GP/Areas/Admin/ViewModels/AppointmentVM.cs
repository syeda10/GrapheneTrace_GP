namespace GrapheneTrace_GP.Areas.Admin.ViewModels
{
    public class AppointmentVM
    {
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string TreatmentType { get; set; }
        public string Comments { get; set; }
        public string NextAppointment { get; set; }
    }

}
