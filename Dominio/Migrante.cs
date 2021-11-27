using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Migrante
    {
        [Key]
        public int Id { get; set; }

        public String UserId { get; set; }

        [Required(ErrorMessage="El nombre es obligatorio")]
        [StringLength(25, ErrorMessage = "Por favor indicar un {0} válido de mínimo {2} caracteres", MinimumLength = 2)]
        [Display(Name = "Nombre", Prompt = "Digite el nombre")]
        public String Nombre { get; set; }

        
        [Required(ErrorMessage="Los apellidos son obligatorios")]
        [StringLength(25, ErrorMessage = "Por favor indicar un {0} válido de mínimo {2} caracteres", MinimumLength = 2)]
        [Display(Name = "Apellidos", Prompt = "Digite el apellido")]
        public String Apellidos { get; set; }

        [Required(ErrorMessage="El Tipo de Documento es obligatorio")]
        public String Tipo_Documento { get; set; }

        [Required(ErrorMessage="El Documento es obligatorio")]
        [StringLength(20, ErrorMessage = "Por favor indicar un {0} válido de mínimo {2} caracteres", MinimumLength = 2)]
        [Display(Name = "Documento", Prompt = "Digite el documento")]
        public String Documento { get; set; }

        [Required(ErrorMessage="El Pais es obligatorio")]
        [Display(Name = "Pais", Prompt = "Digite el Pais")]
        public String Pais { get; set; }

        [Required(ErrorMessage="La Fecha de Nacimiento es obligatoria")]
        public DateTime FechaNacimiento { get; set; }
        public String Direccion_Electronica { get; set; }
        public String Telefono { get; set; }
        public String Dir_Actual { get; set; }
        public String Ciudad { get; set; }
        public String SituacionLab { get; set; }
        public String userName { get; set; }

    }
}