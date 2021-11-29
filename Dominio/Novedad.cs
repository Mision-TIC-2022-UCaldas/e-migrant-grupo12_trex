using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Novedad
    {
        public int Id {get;set;}
        [Range(typeof(DateTime), "1/1/2021", "31/12/2100", ErrorMessage = "La fecha debe estar {1} entre {2}")]
        public DateTime FechaInicio {get;set;}
        [Range(0, 365, ErrorMessage = "El valor debe estar {1} entre {2}")]
        public int DiasNovedad {get;set;} 
        [Required (ErrorMessage = "La descripción es obligatoria.")]
        public string Descripcion {get;set;}
    }
}