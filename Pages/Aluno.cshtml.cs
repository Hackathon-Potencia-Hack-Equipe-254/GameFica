using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameFica.Pages
{
    public class AlunoViewModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public AlunoViewModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}