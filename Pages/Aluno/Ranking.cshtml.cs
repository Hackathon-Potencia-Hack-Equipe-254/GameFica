using Microsoft.AspNetCore.Identity; 
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameFica.Pages.Aluno
{
    public class RankingModel : PageModel
    {
        private readonly ILogger<RankingModel> _logger;
        private readonly UserManager<IdentityUser> UserManager;

        public RankingModel(ILogger<RankingModel> logger)
        {
            _logger = logger; 
        }

        public void OnGet()
        {

        }
    }
}