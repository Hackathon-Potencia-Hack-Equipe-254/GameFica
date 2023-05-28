using Microsoft.AspNetCore.Identity; 
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameFica.Pages.Professor
{
    public class TurmaModel : PageModel
    {
        private readonly ILogger<TurmaModel> _logger;
        private readonly UserManager<IdentityUser> UserManager;

        public TurmaModel(ILogger<TurmaModel> logger)
        {
            _logger = logger;
             
        }

        public void OnGet()
        {

        }
    }
}