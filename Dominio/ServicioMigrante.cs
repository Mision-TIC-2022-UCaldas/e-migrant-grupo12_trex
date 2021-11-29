using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class ServicioMigrante
    {
        [Key]
        public int Id {get;set;}
        public String UserId {get;set;}

        [Required(ErrorMessage="El campo es obligatorio")]
        public String ServicioEntidadId {get;set;}

        [Required(ErrorMessage="El campo es obligatorio")]
        public String Categoria {get;set;}
                
        [Required(ErrorMessage="El campo es obligatorio")]
        [Display(Name = "Status", Prompt = "Digite el estado")]
        public String Status {get;set;}
    }
}