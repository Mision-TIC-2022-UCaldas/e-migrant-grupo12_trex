using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IServicioEntidad
    {
        IEnumerable<ServicioEntidad> ListarServiciosEntidades();
        List<ServicioEntidad> ListarServiciosEntidadesList();
        bool CreateServicioEntidad(ServicioEntidad servicioEntidad); 
        // int ReadServicioEntidad(string user_id, string estatus);       
        ServicioEntidad ReadById(int id, string user_id);       
        ServicioEntidad ReadByOnlyId(int id);       
        bool EditServicioEntidad(ServicioEntidad servicioEntidad);
        bool InhabilitarServicioEntidad(ServicioEntidad servicioEntidad);
    }
}
