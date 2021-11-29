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
    public class ServiciosXNecesidadModel : PageModel
    {
        public readonly IServicioEntidad _repoServicioEntidad;
        public readonly IEntidad _repoEntidad;
        public readonly INecesidad _repoNecesidad;
        public Entidad entidad{ get; set;}

        public IEnumerable<ServicioEntidad> _ListarServicesEntidades { get; set;}
        public IEnumerable<Necesidad> _ListarNecesidades{ get; set; }

        // List<ServicioEntidad> ListarServiciosEntidadesList();


        public ServiciosXNecesidadModel(IServicioEntidad repoServicioEntidad, IEntidad repoEntidad, INecesidad repoNecesidad)
        {
            this._repoServicioEntidad = repoServicioEntidad;
            this._repoEntidad = repoEntidad;
            this._repoNecesidad = repoNecesidad;
        }

        public void OnGet(string cat)
        {
            _ListarServicesEntidades = _repoServicioEntidad.ListarServiciosEntidades().Where(o => o.Categoria == cat);
            _ListarNecesidades = _repoNecesidad.ListarNecesidades().Where(n => n.UserId == User.Identity.Name);
            
                // var query = from person in people
                // join pet in pets on person equals pet.Owner
                // select new { OwnerName = person.FirstName, PetName = pet.Name };
        }
    }
}
