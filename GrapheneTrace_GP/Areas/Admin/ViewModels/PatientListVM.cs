namespace GrapheneTrace_GP.Areas.Admin.ViewModels
{
    public class PatientListVM
    {
        public int PatientId { get; set; }
        public string? Title { get; set; } = "";
        public string? LastName { get; set; } = "";
        public string? FirstName { get; set; } = "";
        public string? Status { get; set; } = "";
        public string? Gender { get; set; } = "";
        public string? Age { get; set; }

   
    }
}
