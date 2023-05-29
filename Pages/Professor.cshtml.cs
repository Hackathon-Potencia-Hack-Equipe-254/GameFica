using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameFica.Pages
{
    public class ProfessorViewModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public ProfessorViewModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}