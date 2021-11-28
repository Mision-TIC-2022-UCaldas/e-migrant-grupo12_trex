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
    public class EditarNecesidadModel : PageModel
    {
         public readonly INecesidad _repoNecesidad;
        [BindProperty]
        public Necesidad _necesidad{ get; set; }
        public EditarNecesidadModel(INecesidad repoNecesidad){
            this._repoNecesidad = repoNecesidad; 
        }
        public ActionResult OnGet(int emeId)
        {
            _necesidad = _repoNecesidad.ReadById(emeId, User.Identity.Name);
            if(_necesidad is null){
                ViewData["Existe"] = "La solicitud no existe por favor validar";
            }
            // ViewData["Titulo"] = _necesidad.Descripcion;
            return Page();
        }

        public ActionResult OnPost()
        {
            if(_repoNecesidad.ReadById(_necesidad.Id, User.Identity.Name) is null){
                ViewData["Existe"] = "La solicitud no existe por favor validar";
            }
            else if(_necesidad.Status != "PENDIENTE"){
                 ViewData["Mensaje"] = "El estado de tu solicitud no puede modificarse";
            }else if(ModelState.IsValid){
                _necesidad.Status = "ATENDIDA";
                bool _actualizado = _repoNecesidad.EditNecesidad(_necesidad);
                if(_actualizado)
                {
                    ViewData["mensajeCreado"] = "La solicitud marcada ha sido atendida!";
                }
                else{
                    ViewData["Mensaje"] = "Hubo un problema";
                }
                return Page();
            }
            // return RedirectToPage("./Emergencias");
            return Page();
        }
    }
}
