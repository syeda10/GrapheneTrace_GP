using GrapheneTrace_GP.Areas.Admin.Models;

namespace GrapheneTrace_GP.Areas.Admin.ViewModels
{
    public class ClinicianDetailsVM
    {
        public int ClinicianId { get; set; }
        public string ClinicianLastName { get; set; } = "";
        public string ClinicianFirstName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Gender { get; set; } = "";
        public DateTime DateOfBirth { get; set; } = DateTime.MinValue;
        public string Phone { get; set; } = "";
        public string Address { get; set; } = "";
        public string City { get; set; } = "";
        public string PostCode { get; set; } = "";
        public string Status { get; set; } = "";

        public Clinicians Clinician { get; set; }
      
        //Clincian Alerts
        public List<ClinicianAlertRow> Alerts { get; set; } = new();

        //Assigned Patients
        public List<AssignedPatientRow> AssignedPatients { get; set; } = new();

    }

    public class ClinicianAlertRow
    {
        public int Sno { get; set; }
        public int AlertId { get; set; }
        public string AlertType { get; set; } = "";
        public DateTime AlertDateTime { get; set; }
    }

    public class AssignedPatientRow
    {

        public int Sno { get; set; }
        public string PatientLastName { get; set; } = "";
        public string PatientFirstName { get; set; } = "";
        public int PatientId { get; set; }
        public int Age { get; set; }



    }

}
