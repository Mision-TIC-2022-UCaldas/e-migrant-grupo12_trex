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
    public class ServiciosXCatModel : PageModel
    {
        public readonly IServicioEntidad _repoServicioEntidad;
        public readonly IEntidad _repoEntidad;
        public Entidad entidad{ get; set;}

        public IEnumerable<ServicioEntidad> _ListarServicesEntidades { get; set;}

        // List<ServicioEntidad> ListarServiciosEntidadesList();


        public ServiciosXCatModel(IServicioEntidad repoServicioEntidad, IEntidad repoEntidad)
        {
            this._repoServicioEntidad = repoServicioEntidad;
            this._repoEntidad = repoEntidad;
        }

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
        public void OnGet(string cat)
        {
            _ListarServicesEntidades = _repoServicioEntidad.ListarServiciosEntidades().Where(o => o.Categoria == cat);
            
                // var query = from person in people
                // join pet in pets on person equals pet.Owner
                // select new { OwnerName = person.FirstName, PetName = pet.Name };
        }
    }
}
