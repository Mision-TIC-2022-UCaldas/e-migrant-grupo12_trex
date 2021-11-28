using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Frontend.Pages.Migrantes
{
    public class NecesidadesModel : PageModel
    {
         public readonly INecesidad _repoNecesidad;
        [BindProperty]
        public Necesidad _necesidad { get; set; }
        public IEnumerable<Necesidad> _ListarNecesidades { get; set;}


        public List<SelectListItem> _listaNecesidades { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "SALUD", Text = "Salud" },
            new SelectListItem { Value = "ALIMENTACION", Text = "Alimentacion" },
            new SelectListItem { Value = "EMPLEO", Text = "Empleo" },
            new SelectListItem { Value = "ALOJAMIENTO_TEMPORAL", Text = "Alojamiento Temporal" },
            new SelectListItem { Value = "ALOJAMIENTO_PERMANENTE", Text = "Alojamiento Permamente" },
            new SelectListItem { Value = "EDUCACION", Text = "Educacion" },
            new SelectListItem { Value = "AYUDA_LEGAL", Text = "Ayuda Legal" }
        };

        public List<SelectListItem> _listaPrioridad { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "BAJA", Text = "Baja" },
            new SelectListItem { Value = "MEDIA", Text = "Media" },
            new SelectListItem { Value = "ALTA", Text = "Alta" }
        };


        public NecesidadesModel(INecesidad repoNecesidad)
        {
            this._repoNecesidad = repoNecesidad;
        }

        public ActionResult OnGet()
        {
            _ListarNecesidades = _repoNecesidad.ListarNecesidades();
            return Page();
        }
    

        public ActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                bool _creado = _repoNecesidad.CreateNecesidad(_necesidad);
                if(_creado)
                {
                    ViewData["mensajeCreado"] = "La necesidad se ha asociada correctamente!";
                }
                else{
                    ViewData["Error"] = "Hubo un problema";
                }
                
            }
            _ListarNecesidades = _repoNecesidad.ListarNecesidades();
            return Page();
        }
    }
}
