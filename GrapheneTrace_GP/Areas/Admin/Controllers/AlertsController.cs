using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GrapheneTrace_GP.Areas.Admin.Models;
using GrapheneTrace_GP.Areas.Admin.ViewModels;
using GrapheneTrace_GP.Data;
using System.Linq;

namespace GrapheneTrace_GP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AlertsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AlertsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int page = 1, string priority = "")
        {
            int pageSize = 10;

            // Base query
            IQueryable<Alert> alertsQuery = _context.Alerts;

            // Apply priority filter (if selected)
            if (!string.IsNullOrEmpty(priority))
            {
                alertsQuery = alertsQuery.Where(a => a.Priority == priority);
            }

            // Priority sort order
            alertsQuery = alertsQuery
                .OrderBy(a => a.Priority == "Critical" ? 0 :
                              a.Priority == "High" ? 1 :
                              a.Priority == "Medium" ? 2 :
                              a.Priority == "Low" ? 3 : 4)
                .ThenByDescending(a => a.CreatedAt);

            // Pagination
            var totalAlerts = await alertsQuery.CountAsync();

            var alerts = await alertsQuery
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            // ViewModel
            var vm = new AlertsListVM
            {
                Alerts = alerts,
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalAlerts / (double)pageSize),
                SelectedPriority = priority
            };

            return View(vm);
        }

    }
}
