namespace GrapheneTrace_GP.Areas.Admin.Models
{
    public class Clinicians
    {
        public int Id { get; set; }
            public string Title { get; set; } = "";
            public string ClinicianLastName { get; set; } = "";
            public int ClinicianId { get; set; }
            public string ClinicianFirstName { get; set; } = "";
            public string ClinicianSpeciality { get; set; } = "";
            public string ClinicianAge { get; set; } = "";

     
            public string Email { get; set; } = "";
            public string Gender { get; set; } = "";
            public DateTime DateOfBirth { get; set; } = DateTime.MinValue;
            public string Phone { get; set; } = "";
            public string Address { get; set; } = "";
            public string City { get; set; } = "";
            public string PostCode { get; set; } = "";
            public string Status { get; set; } = "";

    }
}
