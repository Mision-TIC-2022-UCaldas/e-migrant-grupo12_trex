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
    public class SolicitarServiciosModel : PageModel
    {
        public readonly IServicioMigrante _repoServicioMigrante;
        public readonly IServicioEntidad _repoServicioEntidad;
        [BindProperty]
        public ServicioMigrante _servicioMigrante{ get; set; }
        public ServicioEntidad _servicioEntidad{ get; set; }     
        public SolicitarServiciosModel(IServicioMigrante repoServicioMigrante, IServicioEntidad repoServicioEntidad){
            this._repoServicioMigrante = repoServicioMigrante; 
            this._repoServicioEntidad = repoServicioEntidad; 
        }
        public ActionResult OnGet(int emeId)
        {
            _servicioEntidad = _repoServicioEntidad.ReadByOnlyId(emeId);
            _servicioMigrante = _repoServicioMigrante.ReadById(40, "test@gmail.com");
            if(_servicioMigrante!=null){
                _servicioMigrante.ServicioEntidadId = _servicioEntidad.Id.ToString();
                _servicioMigrante.Status = "PENDIENTE";
                _servicioMigrante.UserId = User.Identity.Name;
                _servicioMigrante.Categoria = _servicioEntidad.Categoria;

            }
            return Page();
        }

        public ActionResult OnPost()
        {
            if(_repoServicioMigrante.Read(Convert.ToInt32(_servicioMigrante.ServicioEntidadId), _servicioMigrante.UserId, _servicioMigrante.Status) != null){
                    ViewData["Existe"] = "Ya tiene una solicitud para este servicio";

            }else if(ModelState.IsValid){

                bool _actualizado = _repoServicioMigrante.CreateServicioMigrante(_servicioMigrante);

                if(_actualizado)
                {
                    ViewData["mensajeCreado"] = "La solicitud ha sido creada!";
                }
                else{
                    ViewData["Error"] = "Hubo un problema";
                }
                return Page();
            }
            // return RedirectToPage("./Emergencias");
            return Page();
        }
    }
}
