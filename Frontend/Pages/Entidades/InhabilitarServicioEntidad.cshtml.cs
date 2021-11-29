using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;

namespace Frontend.Pages.Entidades
{
    public class InhabilitarServicioEntidadModel : PageModel
    {
        public readonly IServicioEntidad _repoServicioEntidad;
        [BindProperty]
        public ServicioEntidad _servicioEntidad{ get; set; }
        public InhabilitarServicioEntidadModel(IServicioEntidad repoServicioEntidad){
            this._repoServicioEntidad = repoServicioEntidad; 
        }
        public ActionResult OnGet(int emeId)
        {
            _servicioEntidad = _repoServicioEntidad.ReadById(emeId, User.Identity.Name);
            if(_servicioEntidad is null){
                ViewData["Existe"] = "El servicio no existe por favor validar";
            }
            // ViewData["Titulo"] = _emergencia.Descripcion;
            return Page();
        }

        public ActionResult OnPost()
        {
            if(_repoServicioEntidad.ReadById(_servicioEntidad.Id, User.Identity.Name) is null){
                ViewData["Existe"] = "El servicio no existe por favor validar";
            }
            else if(_servicioEntidad.Status == "CERRADOS"){
                 ViewData["Mensaje"] = "El estado de tu servicio no puede modificarse";
            }else if(ModelState.IsValid){
                _servicioEntidad.Status = "CERRADOS";
                bool _actualizado = _repoServicioEntidad.InhabilitarServicioEntidad(_servicioEntidad);
                if(_actualizado)
                {
                    ViewData["mensajeCreado"] = "El servicio " + _servicioEntidad.Nombre + " ha sido inhabilitado!";
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
