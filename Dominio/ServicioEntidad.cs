using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class ServicioEntidad
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="El campo es obligatorio")]
        [Display(Name = "Nombre", Prompt = "Digite el nombre")]
        public String Nombre { get; set; }

        [Required(ErrorMessage="El campo es obligatorio")]
        [Display(Name = "CapacidadMAX", Prompt = "Digite Capacidad")]
        public int CapacidadMAX { get; set; }

        [Required(ErrorMessage="El campo es obligatorio")]
        [Display(Name = "FechaIni", Prompt = "Digite Fecha Inicial")]
        public DateTime FechaIni { get; set; }

        // public String Categoria { get; set; }

        [Required(ErrorMessage="El campo es obligatorio")]
        [Display(Name = "FechaFin", Prompt = "Digite Fecha Final")]
        public DateTime FechaFin { get; set; }
        
        [Required(ErrorMessage="El campo es obligatorio")]
        [Display(Name = "Status", Prompt = "Digite el estado")]
        public String Status { get; set; }
        
        public String Categoria { get; set; }
        
        public String UserId { get; set; }
    }
}