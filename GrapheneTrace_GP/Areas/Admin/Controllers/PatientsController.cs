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

        // -----------------------------
        // PATIENT LIST
        // -----------------------------
        [HttpGet("")]
        public async Task<IActionResult> Index(int page = 1)
        {
            int pageSize = 6;

            var query = _context.Patients.OrderBy(p => p.PatientId);

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

        // PATIENT DETAILS

        [HttpGet("Details/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var patient = await _context.Patients
                .Include(p => p.Clinician)
                .FirstOrDefaultAsync(p => p.PatientId == id);

            if (patient == null)
                return NotFound();

            // Load full heatmap
            var heatmapRaw = LoadHeatmapForPatient(id);

            // Crop to 40 × 40
            var heatmap = heatmapRaw
                .Take(40)
                .Select(r => r.Take(40).ToArray())
                .ToList();

            var vm = new PatientDetailsVM
            {
                Patient = patient,
                Heatmap = heatmap,
                AllAppointments = await LoadPatientAppointments(id),
                CompletedAppointments = await LoadCompletedAppointments(id)
            };

            return View(vm);
        }



        // PATIENT-SPECIFIC CSV LOADER

        private List<float[]> LoadHeatmapForPatient(int patientId)
        {
            var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Heatmapdata");

            if (!Directory.Exists(folder))
                return new List<float[]>();

            var patientFiles = Directory.GetFiles(folder, $"{patientId}_*.csv");

            string fileToRead = patientFiles.FirstOrDefault()
                ?? Directory.GetFiles(folder, "*.csv").OrderByDescending(f => f).FirstOrDefault();

            if (fileToRead == null)
                return new List<float[]>();

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

        // -----------------------------
        // APPOINTMENTS
        // -----------------------------
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
