namespace GrapheneTrace_GP.Areas.Admin.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int PatientId { get; set; }
        public string Status { get; set; } = "Active"; // Active / Not Active / Alert
    }

}
