using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Entidad
    {
        [Key]
        public int Id { get; set; }

        public String UserId { get; set; }

        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(25, ErrorMessage = "Por favor indicar un {0} válido de mínimo {2} caracteres", MinimumLength = 2)]
        [Display(Name = "RazonSocial", Prompt = "Digite Razon Social")]
        public String RazonSocial { get; set; }

        
        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(25, ErrorMessage = "Por favor indicar un {0} válido de mínimo {2} caracteres", MinimumLength = 2)]
        [Display(Name = "NIT", Prompt = "Digite NIT")]
        public String NIT { get; set; }

        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(20, ErrorMessage = "Por favor indicar un {0} válido de mínimo {2} caracteres", MinimumLength = 2)]
        [Display(Name = "Direccion", Prompt = "Digite Direccion")]
        public String Direccion { get; set; }

        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(20, ErrorMessage = "Por favor indicar un {0} válido de mínimo {2} caracteres", MinimumLength = 2)]
        [Display(Name = "Telefono", Prompt = "Digite Telefono")]
        public String Telefono { get; set; }

        [Display(Name = "Direccion_Electronica", Prompt = "Digite Direccion Electronica")]
        public String Direccion_Electronica { get; set; }

        [Display(Name = "Pagina_Web", Prompt = "Digite Pagina Web")]
        public String Pagina_Web { get; set; }

        [Required(ErrorMessage="El campo es obligatorio")]
        public String Sector { get; set; }

        [Required(ErrorMessage="El campo es obligatorio")]
        public String Servicios { get; set; }

        [Required(ErrorMessage="El campo es obligatorio")]
        [StringLength(20, ErrorMessage = "Por favor indicar un {0} válido de mínimo {2} caracteres", MinimumLength = 2)]
        [Display(Name = "Ciudad", Prompt = "Digite el Ciudad")]
        public String Ciudad { get; set; }
        public String userName { get; set; }

    }
}