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
            int pageSize = 6; // number of cards per page

            var query = _context.Patients
                .OrderBy(p => p.PatientId)
                .AsQueryable();

            int totalItems = await query.CountAsync();

            var patients = await query
             .Skip((page - 1) * pageSize)
             .Take(pageSize)
             .Select(p => new PatientListVM
             {
                 PatientId = p.PatientId,
                 FirstName = p.FirstName,
                 LastName = p.LastName,
                 Status = p.Status,
                 Age = string.IsNullOrEmpty(p.PatientAge) ? "N/A" : p.PatientAge
             })
             .ToListAsync();


            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            return View(patients);
        }



        [HttpGet("Details/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var patient = await _context.Patients
                .Include(p => p.Clinician)
                .FirstOrDefaultAsync(p => p.PatientId == id);

            if (patient == null) return NotFound();

            var vm = new PatientDetailsVM
            {
                Id = patient.PatientId,
                FirstName = patient.FirstName,
                LastName = patient.LastName,
                Gender = patient.Gender,
                Email = patient.Email,
                Phone = patient.Phone,
                City = patient.City,
                Address = patient.Address,
                PostCode = patient.PostCode,
                Status = patient.Status,
                Age = patient.PatientAge, // <-- FIXED (string)
                AssignedDoctor = patient.Clinician != null
                    ? patient.Clinician.ClinicianFirstName + " " + patient.Clinician.ClinicianLastName
                    : "N/A"
            };

            vm.HeatMapData = LoadHeatmapForPatient(id);
            vm.AllAppointments = new List<AppointmentVM>();
            vm.CompletedAppointments = new List<AppointmentVM>();



            return View(vm);
        }



        //CSV Loader for Heatmap Data
        private List<float[]> LoadHeatmapForPatient(int patientId)
        {
            var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Heatmapdata");

            if (!Directory.Exists(folder))
                return new List<float[]>();

            // Try to find CSVs for this specific patient (e.g. "1257_20250101.csv")
            var patientFiles = Directory.GetFiles(folder, $"{patientId}_*.csv");

            string fileToRead = patientFiles.FirstOrDefault();

            // If no patient-specific file, load latest available
            if (fileToRead == null)
                fileToRead = Directory.GetFiles(folder, "*.csv")
                                      .OrderByDescending(f => f)
                                      .FirstOrDefault();

            if (fileToRead == null)
                return new List<float[]>();

            // Parse CSV → return float[][]
            var lines = System.IO.File.ReadAllLines(fileToRead);
            List<float[]> values = new();

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                float[] row = parts.Select(v => float.TryParse(v, out float parsed) ? parsed : 0).ToArray();
                values.Add(row);
            }

            return values;
        }


        //Appointments Table Loader
        private async Task<List<AppointmentVM>> LoadPatientAppointments(int patientId)
        {
            return await _context.Appointments
                .Where(a => a.PatientId == patientId)
                .OrderBy(a => a.AppointmentDate)
                .Select(a => new AppointmentVM
                {
                    AppointmentDate = a.AppointmentDate,
                    TreatmentType = a.TreatmentType,
                    Comments = a.Comments,
                    NextAppointment = a.NextAppointment.HasValue
                                        ? a.NextAppointment.Value.ToString("dd/MM/yyyy")
                                        : "N/A"
                })
                .ToListAsync();
        }


        //Completed Appointments Table Loader

        private async Task<List<AppointmentVM>> LoadCompletedAppointments(int patientId)
        {
            return await _context.Appointments
                .Where(a => a.PatientId == patientId && a.IsCompleted == true)
                .OrderByDescending(a => a.AppointmentDate)
                .Select(a => new AppointmentVM
                {
                    AppointmentDate = a.AppointmentDate,
                    TreatmentType = a.TreatmentType,
                    Comments = a.Comments,
                    NextAppointment = "N/A"
                })
                .ToListAsync();
        }


    }
}
