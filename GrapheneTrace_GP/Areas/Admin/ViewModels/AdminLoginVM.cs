using System.ComponentModel.DataAnnotations;

namespace GrapheneTrace_GP.Areas.Admin.ViewModels
{
    public class AdminLoginVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
