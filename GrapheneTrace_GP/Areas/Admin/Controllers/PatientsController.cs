using GrapheneTrace_GP.Areas.Admin.ViewModels;
using GrapheneTrace_GP.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GrapheneTrace_GP.Services;

namespace GrapheneTrace_GP.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class PatientsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly CsvLoader _csvLoader;

        public PatientsController(ApplicationDbContext context, CsvLoader csvLoader)
        {
            _context = context;
            _csvLoader = csvLoader;
        }

        [HttpGet("")]
        public async Task<IActionResult> Index(int page = 1)
        {
            int pageSize = 6; // 6 cards per page

            var patients = await _context.Patients
                .OrderBy(p => p.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(p => new PatientListVM
                {
                    PatientId = p.PatientId,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    Status = p.Status,
                    Age = p.PatientAge
                })
                .ToListAsync();

            int totalItems = await _context.Patients.CountAsync();

            ViewBag.TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize);
            ViewBag.CurrentPage = page;

            return View(patients);
        }

        [HttpGet ("Details/{id}")]
        public IActionResult Details(int id)
        {
            var patient = _context.Patients.FirstOrDefault(p => p.PatientId == id);
            if (patient == null) return NotFound();

            var vm = new PatientDetailsVM
            {
                Id = patient.PatientId,
                Title = patient.Title,
                FirstName = patient.FirstName,
                LastName = patient.LastName,
                Status = patient.Status,
                Gender = patient.Gender,
                DateOfBirth = patient.DateOfBirth,
                Phone = patient.Phone,
                Email = patient.Email,
                Address = patient.Address,
                City = patient.City,
                PostCode = patient.PostCode,

                //CSV DATA
                HeatMapData = LoadPatientsCSV(),

                //Appointments Table
                AllAppointments = LoadAppointments(id),
                CompletedAppointments = LoadCompletedAppointments(id)


            };

            return View(vm);

        }

        //CSV Loader for Heatmap Data
        private List<float[]> LoadPatientsCSV()
        {
            string? csvPath = _csvLoader.GetLatestCsvPath();
            if (string.IsNullOrEmpty(csvPath)) return new List<float[]>();

            return _csvLoader.LoadCsvHeatmap(csvPath);

        }

        //Appointments Table Loader
        private List<AppointmentsRow> LoadAppointments(int patientId)
        {
            return new List<AppointmentsRow>
            {
                new AppointmentsRow
                {
                    AppointmentId = 1,
                    AppointmentDate = DateTime.Now.AddDays(7),
                    TreatmentType = "General Checkup",
                    Comments = "Regular 6-month checkup.",
                    NextAppointment = "N/A"
                },

                new AppointmentsRow
                {
                    AppointmentId = 2,
                    AppointmentDate = DateTime.Now.AddDays(30),
                    TreatmentType = "Dental Cleaning",
                    Comments = "Scheduled for routine cleaning.",
                    NextAppointment = "N/A"
                },

                new AppointmentsRow
                {
                    AppointmentId = 3,
                    AppointmentDate = DateTime.Now.AddDays(60),
                    TreatmentType = "Cavity Filling",
                    Comments = "Filling for cavity on molar.",
                    NextAppointment = "N/A"
                },

                new AppointmentsRow
                {
                    AppointmentId = 4,
                    AppointmentDate = DateTime.Now.AddDays(90),
                    TreatmentType = "Orthodontic Consultation",
                    Comments = "Consultation for braces.",
                    NextAppointment = "N/A"
                },

                new AppointmentsRow
                {
                    AppointmentId = 5,
                    AppointmentDate = DateTime.Now.AddDays(120),
                    TreatmentType = "Eye Exam",
                    Comments = "Annual vision check.",
                    NextAppointment = "N/A"
                }
            };
             
        }

        //Completed Appointments Table Loader

        private List<AppointmentsRow> LoadCompletedAppointments(int patientId)
        {
            return new List<AppointmentsRow>
            {
                new AppointmentsRow
                {
                    AppointmentId = 101,
                    AppointmentDate = DateTime.Now.AddDays(-30),
                    TreatmentType = "Flu Vaccination",
                    Comments = "Administered seasonal flu vaccine.",
                    NextAppointment = "N/A"
                },
                new AppointmentsRow
                {
                    AppointmentId = 102,
                    AppointmentDate = DateTime.Now.AddDays(-60),
                    TreatmentType = "Blood Test",
                    Comments = "Routine blood work completed.",
                    NextAppointment = "N/A"
                },

                new AppointmentsRow
                {
                    AppointmentId = 103,
                    AppointmentDate = DateTime.Now.AddDays(-90),
                    TreatmentType = "X-Ray",
                    Comments = "Chest X-Ray for cough evaluation.",
                    NextAppointment = "N/A"
                },

                new AppointmentsRow
                {
                    AppointmentId = 104,
                    AppointmentDate = DateTime.Now.AddDays(-120),
                    TreatmentType = "Physical Exam",
                    Comments = "Annual physical examination.",
                    NextAppointment = "N/A"
                },      

                new AppointmentsRow
                {
                    AppointmentId = 105,
                    AppointmentDate = DateTime.Now.AddDays(-150),
                    TreatmentType = "Allergy Test",
                    Comments = "Tested for common allergens.",
                    NextAppointment = "N/A"
                }
            };
        }

    }
}
