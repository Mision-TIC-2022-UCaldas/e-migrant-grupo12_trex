using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Emergencia
    {
        public int Id { get; set; }
        public String Codigo { get; set; }
        public String Descripcion { get; set; }
        public String MigranteId { get; set; }
        public String Status { get; set; }
    }
}