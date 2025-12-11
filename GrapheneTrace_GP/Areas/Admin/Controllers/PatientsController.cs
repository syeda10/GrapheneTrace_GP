using GrapheneTrace_GP.Areas.Admin.ViewModels;
using GrapheneTrace_GP.Models;
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
        public async Task <IActionResult> Details(int id)
        {
            var patient = _context.Patients.FirstOrDefault(p => p.PatientId == id);
            if (patient == null) return NotFound();


            var allAppointments = await _context.Appointments
            .Where(a => a.PatientId == id)
             .OrderByDescending(a => a.AppointmentDate)
            .ToListAsync();

            var completedAppointments = allAppointments
                .Where(a => a.IsCompleted == true)
                .ToList();


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
                AllAppointments = allAppointments.Select(a => new AppointmentVM
                {
                    AppointmentDate = a.AppointmentDate,
                    TreatmentType = a.TreatmentType,
                    Comments = a.Comments,
                    NextAppointment = a.NextAppointment?.ToString("dd/MM/yyyy")
                }).ToList(),

                CompletedAppointments = completedAppointments.Select(a => new AppointmentVM
                {
                    AppointmentDate = a.AppointmentDate,
                    TreatmentType = a.TreatmentType,
                    Comments = a.Comments
                }).ToList(),


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
        private List<AppointmentVM> LoadAppointments(int patientId)
        {
            return new List<AppointmentVM>
            {
                new AppointmentVM
                {
                    AppointmentId = 1,
                    AppointmentDate = DateTime.Now.AddDays(7),
                    TreatmentType = "General Checkup",
                    Comments = "Regular 6-month checkup.",
                    NextAppointment = "N/A"
                },

                new AppointmentVM
                {
                    AppointmentId = 2,
                    AppointmentDate = DateTime.Now.AddDays(30),
                    TreatmentType = "Dental Cleaning",
                    Comments = "Scheduled for routine cleaning.",
                    NextAppointment = "N/A"
                },

                new AppointmentVM
                {
                    AppointmentId = 3,
                    AppointmentDate = DateTime.Now.AddDays(60),
                    TreatmentType = "Cavity Filling",
                    Comments = "Filling for cavity on molar.",
                    NextAppointment = "N/A"
                },

                new AppointmentVM
                {
                    AppointmentId = 4,
                    AppointmentDate = DateTime.Now.AddDays(90),
                    TreatmentType = "Orthodontic Consultation",
                    Comments = "Consultation for braces.",
                    NextAppointment = "N/A"
                },

                new AppointmentVM
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

        private List<AppointmentVM> LoadCompletedAppointments(int patientId)
        {
            return new List<AppointmentVM>
            {
                new AppointmentVM
                {
                    AppointmentId = 101,
                    AppointmentDate = DateTime.Now.AddDays(-30),
                    TreatmentType = "Flu Vaccination",
                    Comments = "Administered seasonal flu vaccine.",
                    NextAppointment = "N/A"
                },
                new AppointmentVM
                {
                    AppointmentId = 102,
                    AppointmentDate = DateTime.Now.AddDays(-60),
                    TreatmentType = "Blood Test",
                    Comments = "Routine blood work completed.",
                    NextAppointment = "N/A"
                },

                new AppointmentVM
                {
                    AppointmentId = 103,
                    AppointmentDate = DateTime.Now.AddDays(-90),
                    TreatmentType = "X-Ray",
                    Comments = "Chest X-Ray for cough evaluation.",
                    NextAppointment = "N/A"
                },

                new AppointmentVM
                {
                    AppointmentId = 104,
                    AppointmentDate = DateTime.Now.AddDays(-120),
                    TreatmentType = "Physical Exam",
                    Comments = "Annual physical examination.",
                    NextAppointment = "N/A"
                },      

                new AppointmentVM
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
