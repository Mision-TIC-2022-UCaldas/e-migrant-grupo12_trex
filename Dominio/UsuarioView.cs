using System;
using System.Collections.Generic;

namespace Dominio
{
    public class UsuarioView
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public String Tipo_Documento { get; set; }
        public String Documento { get; set; }
        public String Pais { get; set; }
        public String FechaNacimiento { get; set; }
        public String Email { get; set; }
        public String Telefono { get; set; }
        public String Ciudad { get; set; }
        public String SituacionLab { get; set; }
    }
}