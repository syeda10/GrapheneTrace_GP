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
        public string PatientAge { get; set; } = "";


        public string Email { get; set; } = "";
        public string Gender { get; set; } = "";
        public DateTime DateOfBirth { get; set; } = DateTime.MinValue;
        public string Phone { get; set; } = "";
        public string Address { get; set; } = "";
        public string City { get; set; } = "";
        public string PostCode { get; set; } = "";

    }

}
