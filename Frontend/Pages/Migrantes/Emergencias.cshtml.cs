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
    public class EmergenciasModel : PageModel
    {
        private readonly IEmergencia _repoEmergencia;
        public readonly IMigrante _repoMigrante;
        [BindProperty]
        public Emergencia _emergencia{ get; set; }
        public Migrante _migrante { get; set; }
        public IEnumerable<Emergencia> _ListarEmergencias { get; set;}

        public EmergenciasModel(IEmergencia repoEmergencia, IMigrante repoMigrante)
        {
            this._repoEmergencia = repoEmergencia;
            this._repoMigrante = repoMigrante;
        }

        public ActionResult OnGet(string userNameA)
        {
            _ListarEmergencias = _repoEmergencia.ListarEmergencias();
            return Page();
        }

        public ActionResult OnPost()
        {
            if(_emergencia.Codigo!="915" && _emergencia.Codigo!="916")
            {
                ViewData["Error"] = "Debe ingresar el codigo correcto 915 = Emergencia policial, 916 = Emergencia de Salud ";
            }
            else if(ModelState.IsValid)
            {
                var valor = _repoEmergencia.ReadEmergencia(_emergencia.MigranteId,"PENDIENTE",_emergencia.Codigo);
                if(valor > 0){
                    ViewData["Error"] = "Ya tiene una emergencia pendiente de este tipo";
                    _ListarEmergencias = _repoEmergencia.ListarEmergencias();
                    return Page();
                }
                // _migrante = _repoMigrante.FindByUserName(userNameA);
                // _migrante = _repoMigrante.FindByUserName(_emergencia.MigranteId);ReadEmergencia
                // _emergencia.MigranteId = _migrante.Id.ToString();

                _emergencia.Status = "PENDIENTE";
                _emergencia.Descripcion = _emergencia.Codigo == "915"? "Emergencia policial" : "Emergencia de Salud";

                bool _creado = _repoEmergencia.CreateEmergencia(_emergencia);
                if(_creado)
                {
                    TempData["mensajeCreado"] = "La emergencia " + _emergencia.Descripcion + " se ha creado correctamente y sera atendida a brevedad!";
                }
                else{
                    ViewData["Mensaje"] = "Hubo un problema";
                }
            }
            _ListarEmergencias = _repoEmergencia.ListarEmergencias();
            return Page();
        }
    }
}
