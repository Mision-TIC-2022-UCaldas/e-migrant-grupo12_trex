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
    public class ListarServiciosModel : PageModel
    {
         public readonly IServicioEntidad _repoServicioEntidad;
         public readonly IEntidad _repoEntidad;
         public Entidad entidad{ get; set;}


        public List<ServicioEntidad> _ListarServicesEntidades2 { get; set;}
        public IEnumerable<ServicioEntidad> _ListarServicesEntidades { get; set;}

        public List<Entidad> _ListarEntidades { get; set;}

        // List<ServicioEntidad> ListarServiciosEntidadesList();


        public ListarServiciosModel(IServicioEntidad repoServicioEntidad, IEntidad repoEntidad)
        {
            this._repoServicioEntidad = repoServicioEntidad;
            this._repoEntidad = repoEntidad;
        }

        public void OnGet()
        {
            //query = "asdasdasd";
            _ListarServicesEntidades = _repoServicioEntidad.ListarServiciosEntidades();
            _ListarServicesEntidades2 = _repoServicioEntidad.ListarServiciosEntidadesList();
            _ListarEntidades = _repoEntidad.ListarEntidadesList();
            
                // var query = from person in people
                // join pet in pets on person equals pet.Owner
                // select new { OwnerName = person.FirstName, PetName = pet.Name };

                
        }
    }
}
