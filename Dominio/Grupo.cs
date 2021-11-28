using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Grupo
    {
        public int Id { get; set; }
        public String UserId { get; set; }
        public String RelacionId { get; set; }
        public String Tipo { get; set; }
    }
}