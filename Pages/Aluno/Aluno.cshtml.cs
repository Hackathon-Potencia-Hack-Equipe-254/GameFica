using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace GameFica.Pages.Aluno
{
    public class AlunoModel : PageModel
    {
        private readonly ILogger<AlunoModel> _logger;
        private readonly UserManager<IdentityUser> UserManager;

        public AlunoModel(ILogger<AlunoModel> logger)
        {
            _logger = logger;
        }

        public ActionResult MinhaAcao()
        {
            System.Security.Principal.IIdentity? identity = User.Identity;
            var usuario = identity.Name;
            if (usuario == null)
            {
                return RedirectToAction("/");
            }

            return null;

        }

        public void OnGet()
        {
            MinhaAcao();
        }
    }
}