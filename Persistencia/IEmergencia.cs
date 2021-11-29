using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IEmergencia
    {
        IEnumerable<Emergencia> ListarEmergencias();
        List<Emergencia> ListarEmergenciasList();
        bool CreateEmergencia(Emergencia emergencia); 
        int ReadEmergencia(string user_id, string estatus, string code);       
        Emergencia ReadById(int id, string user_id);       
        bool EditEmergencia(Emergencia emergencia);
    }
}