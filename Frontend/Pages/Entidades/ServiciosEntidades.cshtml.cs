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
    public class ServiciosEntidadesModel : PageModel
    {
        public readonly IServicioEntidad _repoServicioEntidad;
        [BindProperty]
        public ServicioEntidad _servicioEntidad { get; set; }
        public IEnumerable<ServicioEntidad> _ListarServiciosEntidades { get; set;}


        public List<SelectListItem> _listaEstatus { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "ACTIVOS", Text = "Activos" },
            new SelectListItem { Value = "CERRADOS", Text = "Cerrados" },
            new SelectListItem { Value = "CON_CUPO", Text = "Con Cupo" },
            new SelectListItem { Value = "SIN_CUPO", Text = "Sin Cupo" }
        };

        public ServiciosEntidadesModel(IServicioEntidad repoServicioEntidad)
        {
            this._repoServicioEntidad = repoServicioEntidad;
        }

        public ActionResult OnGet()
        {
            _ListarServiciosEntidades = _repoServicioEntidad.ListarServiciosEntidades();
            return Page();
        }
        // public ActionResult OnGet(string userNameA)
        // {
        //     _ListarEmergencias = _repoEmergencia.ListarEmergencias();
        //     return Page();
        // }

        public ActionResult OnPost()
        {
            if(_servicioEntidad.FechaIni > _servicioEntidad.FechaFin)
            {
                ViewData["Error"] = "La fecha final no puede ser menor a la de inicio ";
                _ListarServiciosEntidades = _repoServicioEntidad.ListarServiciosEntidades();
                return Page();
            }else if(_servicioEntidad.FechaIni < DateTime.Now)
            {
                ViewData["Error"] = "La fecha inicial no puede ser menor a la fecha actual ";
                _ListarServiciosEntidades = _repoServicioEntidad.ListarServiciosEntidades();
                return Page();
            }
            else if(ModelState.IsValid)
            {
                bool _creado = _repoServicioEntidad.CreateServicioEntidad(_servicioEntidad);
                if(_creado)
                {
                    ViewData["mensajeCreado"] = "El servicio se ha creado correctamente!";
                }
                else{
                    ViewData["Error"] = "Hubo un problema";
                }
                
            }
            _ListarServiciosEntidades = _repoServicioEntidad.ListarServiciosEntidades();
            return Page();
        }
    }
}
