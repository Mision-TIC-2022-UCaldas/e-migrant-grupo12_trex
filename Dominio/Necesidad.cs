using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Necesidad
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="El campo es obligatorio")]
        public String Categoria { get; set; }

        [Required(ErrorMessage="El campo es obligatorio")]
        [Display(Name = "Descripcion", Prompt = "Digite una descripcion")]
        public String Descripcion { get; set; }

        [Required(ErrorMessage="El campo es obligatorio")]
        public String Prioridad { get; set; }
        
        [Required(ErrorMessage="El campo es obligatorio")]
        [Display(Name = "Status", Prompt = "Digite el estado")]
        public String Status { get; set; }
        
        public String UserId { get; set; }
    }
}