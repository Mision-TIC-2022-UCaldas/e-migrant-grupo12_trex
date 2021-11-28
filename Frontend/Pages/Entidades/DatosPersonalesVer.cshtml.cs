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
    public class DatosPersonalesVerModel : PageModel
    {
        public readonly IEntidad _repoEntidad;
        [BindProperty]
        public Entidad _entidad { get; set; }
        public List<SelectListItem> _listaServicios { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "SALUD", Text = "Salud" },
            new SelectListItem { Value = "JURIDICOS", Text = "Juridicos" },
            new SelectListItem { Value = "VIVERES", Text = "Vivires" },
            new SelectListItem { Value = "COMIDA_PREPARADA", Text = "Comida preparada" },
            new SelectListItem { Value = "EMPLEO", Text = "Empleo" },
            new SelectListItem { Value = "ALOJAMIENTO_TEMPORAL", Text = "Alojamiento temporal" },
            new SelectListItem { Value = "ALOJAMIENTO_PERMANENTE", Text = "Alojamiento permanente" },
            new SelectListItem { Value = "EDUCACION", Text = "Educacion" },
            new SelectListItem { Value = "OTROS", Text = "Otros" }
        };

        public List<SelectListItem> _listaSector { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "PUBLICO", Text = "Publico" },
            new SelectListItem { Value = "PRIVADO", Text = "Privado" },
            new SelectListItem { Value = "SIN_ANIMO_DE_LUCRO", Text = "Sin animo de lucho" },
            new SelectListItem { Value = "NO_GUBERNAMENTAL", Text = "No Gubernamental" },
            new SelectListItem { Value = "OTROS", Text = "Otros" }

        };
        public DatosPersonalesVerModel(IEntidad repoEntidad)
        {
            this._repoEntidad = repoEntidad;
        }
        public void OnGet(string userNameA)
        {
            _entidad = _repoEntidad.FindByUserName(userNameA);
        }

        public ActionResult OnPost(){
            if(_repoEntidad.ReadEntidad(_entidad.NIT) != null && _repoEntidad.FindByUserName(_entidad.userName).NIT != _entidad.NIT){
                    ViewData["Error"] = "ErrorCreate";
                    return Page();
                }
            else 
            if(ModelState.IsValid)
            {
                
                bool _actualizado = _repoEntidad.EditEntidad(_entidad);
                if(_actualizado)
                {
                    TempData["mensajeCreado"] = _entidad.userName + " se ha actualizado correctamente!";
                }
                else{

                    ViewData["Mensaje"] = "Hubo un problema";
                }
            }
            return Page();
        }
    }
}
