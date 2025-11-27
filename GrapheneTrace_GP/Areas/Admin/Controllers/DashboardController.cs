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
                       sno = 1,
                       Title = "Mr",
                       PatientName = "Henry, Comb",
                       PatientId = 1258,
                       ClinicianName = "Dr. Anderson",
                       Age = "41",
                       Status = "Active"
                   },

                    new AppointmentRow
                     {
                          sno = 2,
                          Title = "Mr",
                          PatientName = "Marco, Botton",
                          PatientId = 3885,
                          ClinicianName = "Dr. Stephen",
                          Age = "32",
                          Status = "Active"
                     },

                    new AppointmentRow
                     {
                          sno = 3,
                          Title = "Ms",
                          PatientName = "Mariah, Maclachlan",
                          PatientId = 2598,
                          ClinicianName = "Dr. Rose",
                          Age = "30",
                          Status = "Inactive"
                     },

                    new AppointmentRow
                     {
                          sno = 4,
                          Title = "Mrs",
                          PatientName = "Hanah, Darling",
                          PatientId = 4526,
                          ClinicianName = "Dr. Emily",
                          Age = "45",
                          Status = "Active"
                     },

                    new AppointmentRow
                     {
                          sno = 5,
                          Title = "Mr",
                          PatientName = "David, Acaster",
                          PatientId = 5236,
                          ClinicianName = "Dr. John",
                          Age = "58",
                          Status = "Inactive"
                     },

                    new AppointmentRow
                     {
                          sno = 6,
                          Title = "Mrs",
                          PatientName = "Sarah, Sterling",
                          PatientId = 2356,
                          ClinicianName = "Dr. Helen",
                          Age = "36",
                          Status = "Active"
                     },

                    new AppointmentRow
                     {
                          sno = 7,
                          Title = "Mr",
                          PatientName = "Gille, Star",
                          PatientId = 7894,
                          ClinicianName = "Dr. Peter",
                          Age = "71",
                          Status = "Active"
                    },

                    new AppointmentRow
                     {
                          sno = 8,
                          Title = "Mr",
                          PatientName = "Peter, Duncan",
                          PatientId = 6201,
                          ClinicianName = "Dr. Anderson",
                          Age = "42",
                          Status = "Inactive"
                    },

                    new AppointmentRow
                     {
                          sno = 9,
                          Title = "Ms",
                          PatientName = "Mary, Phillips",
                          PatientId = 9642,
                          ClinicianName = "Dr. Rose",
                          Age = "36",
                          Status = "Active"
                    },

                    new AppointmentRow
                     {
                          sno = 10,
                          Title = "Mr",
                          PatientName = "Joe, Stuart",
                          PatientId = 8956,
                          ClinicianName = "Dr. Stephen",
                          Age = "59",
                          Status = "Active"
                    },

                    new AppointmentRow
                     {
                          sno = 11,
                          Title = "Mr",
                          PatientName = "Bake, Good",
                          PatientId = 4569,
                          ClinicianName = "Dr. Peter",
                          Age = "40",
                          Status = "Inactive"
                    },

                    new AppointmentRow
                     {
                          sno = 12,
                          Title = "Mr",
                          PatientName = "Nicks, Gibbs",
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
