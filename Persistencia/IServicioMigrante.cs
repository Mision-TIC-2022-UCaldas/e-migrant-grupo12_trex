using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IServicioMigrante
    {
        IEnumerable<ServicioMigrante> ListarServiciosMigrantes();
        List<ServicioMigrante> ListarServiciosMigrantesList();
        bool CreateServicioMigrante(ServicioMigrante servicioMigrante);
        // bool CreateServicioMigrante(int id, string entId, string cat);
        // int ReadNecesidad(string user_id, string estatus);       
        ServicioMigrante ReadById(int id, string user_id);       
        ServicioMigrante Read(int id, string user_id, string estatus);       
        bool EditServicioMigrante(ServicioMigrante servicioMigrante);
        // bool InhabilitarNecesidad(ServicioMigrante servicioMigrante);
        int Total(string id, string userId, string status);

        
    }
}