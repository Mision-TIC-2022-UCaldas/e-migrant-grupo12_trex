using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;

namespace Frontend
{
    public class EvaluanosModel : PageModel
    {
        private readonly IRepositorioCalificacionApp _repoCalificacion;
        public CalificacionApp CalificacionApp {get;set;}
        public  EvaluanosModel(IRepositorioCalificacionApp _repoCalificacion){
            this._repoCalificacion = _repoCalificacion;
        }

        public void OnGet()
        {
            CalificacionApp = new CalificacionApp();

        }

        public IActionResult OnPost(CalificacionApp calificacionApp){
            _repoCalificacion.AddCalificacionApp(calificacionApp);
            return RedirectToPage("");

        }
    }
}

