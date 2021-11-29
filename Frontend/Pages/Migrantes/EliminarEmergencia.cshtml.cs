using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.Migrantes
{
    public class EliminarEmergenciaModel : PageModel
    {
        public readonly IEmergencia _repoEmergencia;
        [BindProperty]
        public Emergencia _emergencia{ get; set; }
        public EliminarEmergenciaModel(IEmergencia repoEmergencia){
            this._repoEmergencia = repoEmergencia; 
        }
        public ActionResult OnGet(int emeId)
        {
            _emergencia = _repoEmergencia.ReadById(emeId, User.Identity.Name);
            if(_emergencia is null){
                ViewData["Existe"] = "La emergencia no existe por favor validar";
            }
            // ViewData["Titulo"] = _emergencia.Descripcion;
            return Page();
        }

        public ActionResult OnPost()
        {
            if(_repoEmergencia.ReadById(_emergencia.Id, User.Identity.Name) is null){
                ViewData["Existe"] = "La emergencia no existe por favor validar";
            }
            else if(_emergencia.Status != "PENDIENTE"){
                ViewData["Mensaje"] = "El estado de tu emergencia no puede modificarse";
            }else if(ModelState.IsValid){
                _emergencia.Status = "CANCELADA";
                bool _actualizado = _repoEmergencia.EditEmergencia(_emergencia);
                if(_actualizado)
                {
                    ViewData["mensajeCreado"] = "La emergencia " + _emergencia.Descripcion + " ha sido cancelada!";
                }
                else{
                    ViewData["Mensaje"] = "Hubo un problema";
                }
                // return Page();
            }
            // return RedirectToPage("./Emergencias");
            return Page();
        }
    }
}
