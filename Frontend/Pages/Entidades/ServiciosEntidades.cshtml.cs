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
        public readonly IEntidad _repoEntidad;
        [BindProperty]
        public ServicioEntidad _servicioEntidad { get; set; }
        public IEnumerable<ServicioEntidad> _ListarServiciosEntidades { get; set;}
        public Entidad _entidad { get; set; }


        public List<SelectListItem> _listaEstatus { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "ACTIVOS", Text = "Activos" },
            new SelectListItem { Value = "CERRADOS", Text = "Cerrados" },
            new SelectListItem { Value = "CON_CUPO", Text = "Con Cupo" },
            new SelectListItem { Value = "SIN_CUPO", Text = "Sin Cupo" }
        };

        public ServiciosEntidadesModel(IServicioEntidad repoServicioEntidad, IEntidad repoEntidad)
        {
            this._repoServicioEntidad = repoServicioEntidad;
            this._repoEntidad = repoEntidad;
        }

        public ActionResult OnGet()
        {
            _ListarServiciosEntidades = _repoServicioEntidad.ListarServiciosEntidades();
            return Page();
        }
        // public List<SelectListItem> _listaServicios { get; } = new List<SelectListItem>
        // {
        //     new SelectListItem { Value = "SALUD", Text = "Salud" },
        //     new SelectListItem { Value = "JURIDICOS", Text = "Juridicos" },
        //     new SelectListItem { Value = "VIVERES", Text = "Vivires" },
        //     new SelectListItem { Value = "COMIDA_PREPARADA", Text = "Comida preparada" },
        //     new SelectListItem { Value = "EMPLEO", Text = "Empleo" },
        //     new SelectListItem { Value = "ALOJAMIENTO_TEMPORAL", Text = "Alojamiento temporal" },
        //     new SelectListItem { Value = "ALOJAMIENTO_PERMANENTE", Text = "Alojamiento permanente" },
        //     new SelectListItem { Value = "EDUCACION", Text = "Educacion" },
        //     new SelectListItem { Value = "OTROS", Text = "Otros" }
        // };
        // new SelectListItem { Value = "SALUD", Text = "Salud" },
        //     new SelectListItem { Value = "ALIMENTACION", Text = "Alimentacion" },
        //     new SelectListItem { Value = "EMPLEO", Text = "Empleo" },
        //     new SelectListItem { Value = "ALOJAMIENTO_TEMPORAL", Text = "Alojamiento Temporal" },
        //     new SelectListItem { Value = "ALOJAMIENTO_PERMANENTE", Text = "Alojamiento Permamente" },
        //     new SelectListItem { Value = "EDUCACION", Text = "Educacion" },
        //     new SelectListItem { Value = "AYUDA_LEGAL", Text = "Ayuda Legal" }
        public ActionResult OnPost()
        {
            _entidad = _repoEntidad.FindByUserName(_servicioEntidad.UserId);
            _servicioEntidad.Categoria = _entidad.Servicios;
            
            if(_entidad.Servicios == "JURIDICOS"){
                _servicioEntidad.Categoria = "AYUDA_LEGAL";
            }else if(_entidad.Servicios == "VIVERES" || _entidad.Servicios == "COMIDA_PREPARADA"){
                _servicioEntidad.Categoria = "ALIMENTACION";
            }
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
