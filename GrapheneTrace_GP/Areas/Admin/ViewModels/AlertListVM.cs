using GrapheneTrace_GP.Areas.Admin.Models;

namespace GrapheneTrace_GP.Areas.Admin.ViewModels
{
    public class AlertsListVM
    {
        public List<Alert> Alerts { get; set; } = new();
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }

        public string SelectedPriority { get; set; } = "";      
    }

}
