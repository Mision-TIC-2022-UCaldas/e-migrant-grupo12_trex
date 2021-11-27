using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="El nombre es obligatorio")]
        [StringLength(25, ErrorMessage = "Por favor indicar un {0} válido de mínimo {2} caracteres", MinimumLength = 2)]
        [Display(Name = "Nombre", Prompt = "Digite el nombre")]
        public String Nombre { get; set; }

        
        [Required(ErrorMessage="Los apellidos son obligatorios")]
        [StringLength(25, ErrorMessage = "Por favor indicar un {0} válido de mínimo {2} caracteres", MinimumLength = 2)]
        [Display(Name = "Apellidos", Prompt = "Digite el apellido")]
        public String Apellidos { get; set; }

        [Required(ErrorMessage="El Tipo de Documento son obligatorios")]
        public String Tipo_Documento { get; set; }

        [Required(ErrorMessage="El Documento es obligatorio")]
        [StringLength(20, ErrorMessage = "Por favor indicar un {0} válido de mínimo {8} caracteres", MinimumLength = 8)]
        [Display(Name = "Documento", Prompt = "Digite el documento")]
        public String Documento { get; set; }

        [Required(ErrorMessage="El pais es obligatorio")]
        [StringLength(15, ErrorMessage = "Por favor indicar un {0} válido de mínimo {4} caracteres", MinimumLength = 4)]
        [Display(Name = "Pais", Prompt = "Digite el Pais")]
        public String Pais { get; set; }

        [Required(ErrorMessage="La Fecha de Nacimiento es obligatoria")]
        public String FechaNacimiento { get; set; }
        public String Email { get; set; }
        public String Telefono { get; set; }
        public String Ciudad { get; set; }
        public String SituacionLab { get; set; }

        
    }
}