using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend
{
    public class GENovedadModel : PageModel
    {
        
        private readonly INovedad _repositorioNovedad = new RepoNovedad(new Persistencia.AppContext());
        public IEnumerable<Novedad> Novedads { get; set; }
        public void OnGet()
        {
            Novedads = _repositorioNovedad.GetAllNovedad();
        }

    }
}
