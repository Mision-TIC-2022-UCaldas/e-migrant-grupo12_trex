using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend
{
    public class RegistroNovedadModel : PageModel
    {
        private static INovedad _repositorioNovedad = new RepoNovedad(new Persistencia.AppContext());
        [BindProperty]
        public Novedad novedad { get; set; }
        public IActionResult OnGet(int? idNovedad)
        {
            if (idNovedad.HasValue)
            {
                novedad = _repositorioNovedad.GetNovedad(idNovedad.Value);
            }
            else
            {
                novedad = new Novedad();
            }
            if (novedad == null)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                if (novedad.Id > 0)
                {
                    _repositorioNovedad.UpdateNovedad(novedad);
                }
                else
                {
                    _repositorioNovedad.AddNovedad(novedad);
                }
            }
            return RedirectToPage("./Index");
        }
    }
}
