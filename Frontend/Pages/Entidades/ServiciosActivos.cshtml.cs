using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Frontend.Pages.Entidades
{
    public class ServiciosActivosModel : PageModel
    {
        public readonly IServicioEntidad _repoServicioEntidad;
        [BindProperty]
        public IEnumerable<ServicioEntidad> _ListarServiciosEntidades { get; set;}
        public ServiciosActivosModel(IServicioEntidad repoServicioEntidad)
        {
            this._repoServicioEntidad = repoServicioEntidad;
        }
        public ActionResult OnGet()
        {
            _ListarServiciosEntidades = _repoServicioEntidad.ListarServiciosEntidades();
            return Page();
        }
    }
}
