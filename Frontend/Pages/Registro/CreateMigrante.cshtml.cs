using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Frontend.Pages.Registro
{
    public class CreateMigranteModel : PageModel
    {
        private readonly IMigrante _repoMigrante;
        [BindProperty]
        public Migrante _migrante{ get; set; }
        public List<SelectListItem> _tipoDoc { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "CEDULA", Text = "Cedula" },
            new SelectListItem { Value = "PASAPORTE", Text = "Pasaporte" }
        };

        public List<SelectListItem> _listaPais { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "VENEZUELA", Text = "Venezuela" },
            new SelectListItem { Value = "REPUBLICA DOMINICANA", Text = "Republica Dominicana" },
            new SelectListItem { Value = "PERU", Text = "Peru" },
            new SelectListItem { Value = "ECUADOR", Text = "Ecuador" },
            new SelectListItem { Value = "CHILE", Text = "Chile" },
            new SelectListItem { Value = "BRASIL", Text = "Brasil" }
        };

        public List<SelectListItem> _listaLab { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "EMPLEADO", Text = "Empleado" },
            new SelectListItem { Value = "DESEMPLEADO", Text = "Desempleado" },
            new SelectListItem { Value = "ESTUDIANTE", Text = "Estudiante" }
        };
        public CreateMigranteModel(IMigrante repoMigrante)
        {
            this._repoMigrante = repoMigrante;
        }

        public ActionResult OnGet()
        {
            return Page();
        }
        public ActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                bool _creado = _repoMigrante.CreateMigrante(_migrante);
                if(_creado)
                {
                    TempData["mensajeCreado"] = "El migrante " + _migrante.Nombre + " se ha creado correctamente!";
                }
                else{
                    ViewData["Mensaje"] = "Hubo un problema";
                }
            }
            return RedirectToPage("../Migrantes/Index");
        }
    }
}
