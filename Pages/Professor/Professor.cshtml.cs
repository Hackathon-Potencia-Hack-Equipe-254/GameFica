using Microsoft.AspNetCore.Identity; 
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameFica.Pages.Professor
{
    public class ProfessorModel : PageModel
    {
        private readonly ILogger<ProfessorModel> _logger;
        private readonly UserManager<IdentityUser> UserManager;

        public ProfessorModel(ILogger<ProfessorModel> logger)
        {
            _logger = logger;
             
        }

        public void OnGet()
        {

        }
    }
}