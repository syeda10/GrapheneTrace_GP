using Microsoft.CodeAnalysis.Scripting;
using System;

namespace GrapheneTrace_GP.Areas.Admin.ViewModels
{
    public class PatientDetailsVM
    {
      
            public int Id { get; set; }
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public string? DateOfBirth { get; set; }
            public string? Gender { get; set; }
            public string? Email { get; set; }
            public string? Phone { get; set; }
            public string? Address { get; set; }
            public string? City { get; set; }
            public string? PostCode { get; set; }
            public string? Status { get; set; }
            public string? Age { get; set; }                // <--- REQUIRED
            public string? AssignedDoctor { get; set; }     // <--- REQUIRED




            //Heat Map Table
            public List<float[]> HeatMapData { get; set; } = new();

            //Appointment Table
            public List<AppointmentVM> AllAppointments { get; set; } = new();
            public List<AppointmentVM> CompletedAppointments { get; set; } = new();


        
    }

    
}


