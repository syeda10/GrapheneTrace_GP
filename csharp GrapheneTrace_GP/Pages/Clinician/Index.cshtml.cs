using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrapheneTrace_GP.Pages.Clinician
{
    [Authorize(Roles = "Clinician")]
    public class IndexModel : PageModel
    {
        public void OnGet() { }
    }
}