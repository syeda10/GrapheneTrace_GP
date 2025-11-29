using Microsoft.AspNetCore.Mvc;
using GrapheneTrace_GP.Areas.Admin.ViewModels;

namespace GrapheneTrace_GP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.UserEmail = "cat23hobson@admin.co.uk"; 

            var vm = new DashboardVM
            {
                ActiveClinicians = 15,
                ActivePatients = 30,
                NextDayAppointments = 180,

                TotalActivePatients = 300,
                TotalInactivePatients = 120,


                MonthlyNewPatients = new List<int> { 100, 120, 130, 140, 150, 160, 170, 180, 190, 200, 210, 220 },
                MonthLabels = new List<string> { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" },


                UpcomingAppointments = new List<AppointmentRow>
                {
                   new AppointmentRow
                   {
                       AppointmentId = 01,
                       Title = "Mr",
                       PatientLastName = "Comb",
                       PatientFirstName = "Henry",
                       PatientId = 1258,
                       ClinicianName = "Dr. Anderson",
                       Age = "41",
                       Status = "Active"
                   },

                    new AppointmentRow
                     {
                          AppointmentId = 02,
                          Title = "Mr",
                          PatientLastName = "Botton",
                          PatientFirstName = "Marco",
                          PatientId = 3885,
                          ClinicianName = "Dr. Stephen",
                          Age = "32",
                          Status = "Active"
                     },

                    new AppointmentRow
                     {
                          AppointmentId = 03,
                          Title = "Ms",
                          PatientLastName = "Maclachlan",
                          PatientFirstName = "Mariah",
                          PatientId = 2598,
                          ClinicianName = "Dr. Rose",
                          Age = "30",
                          Status = "Inactive"
                     },

                    new AppointmentRow
                     {
                          AppointmentId = 04,
                          Title = "Mrs",
                          PatientLastName = "Darling",
                          PatientFirstName = "Hanah",
                          PatientId = 4526,
                          ClinicianName = "Dr. Emily",
                          Age = "45",
                          Status = "Active"
                     },

                    new AppointmentRow
                     {
                          AppointmentId = 05,
                          Title = "Mr",
                          PatientLastName = "Acaster",
                          PatientFirstName = "David",
                          PatientId = 5236,
                          ClinicianName = "Dr. John",
                          Age = "58",
                          Status = "Inactive"
                     },

                    new AppointmentRow
                     {
                          AppointmentId = 06,
                          Title = "Mrs",
                          PatientLastName = "Sterling",
                          PatientFirstName = "Sarah",
                          PatientId = 2356,
                          ClinicianName = "Dr. Helen",
                          Age = "36",
                          Status = "Active"
                     },

                    new AppointmentRow
                     {
                          AppointmentId = 07,
                          Title = "Mr",
                          PatientLastName = "Star",
                          PatientFirstName = "Gille",
                          PatientId = 7894,
                          ClinicianName = "Dr. Peter",
                          Age = "71",
                          Status = "Active"
                    },

                    new AppointmentRow
                     {
                          AppointmentId = 08,
                          Title = "Mr",
                          PatientLastName = "Duncan",
                          PatientFirstName = "Peter",
                          PatientId = 6201,
                          ClinicianName = "Dr. Anderson",
                          Age = "42",
                          Status = "Inactive"
                    },

                    new AppointmentRow
                     {
                          AppointmentId = 09,
                          Title = "Ms",
                          PatientLastName = "Phillips",
                          PatientFirstName = "Mary",
                          PatientId = 9642,
                          ClinicianName = "Dr. Rose",
                          Age = "36",
                          Status = "Active"
                    },

                    new AppointmentRow
                     {
                          AppointmentId = 10,
                          Title = "Mr",
                          PatientLastName = "Stuart",
                          PatientFirstName = "Joe",
                          PatientId = 8956,
                          ClinicianName = "Dr. Stephen",
                          Age = "59",
                          Status = "Active"
                    },

                    new AppointmentRow
                     {
                          AppointmentId = 11,
                          Title = "Mr",
                          PatientLastName = "Good",
                          PatientFirstName = "Bake",
                          PatientId = 4569,
                          ClinicianName = "Dr. Peter",
                          Age = "40",
                          Status = "Inactive"
                    },

                    new AppointmentRow
                     {
                          AppointmentId = 12,
                          Title = "Mr",
                          PatientLastName = "Gibbs",
                          PatientFirstName = "Nicks",
                          PatientId = 1256,
                          ClinicianName = "Dr. John",
                          Age = "62",
                          Status = "Active"
                    }
                }
            };
            return View(vm); //inside the var vm
        }
    }
}
