using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface INecesidad
    {
        IEnumerable<Necesidad> ListarNecesidades();
        List<Necesidad> ListarNecesidadesList();
        bool CreateNecesidad(Necesidad necesidad); 
        // int ReadNecesidad(string user_id, string estatus);       
        Necesidad ReadById(int id, string user_id);       
        bool EditNecesidad(Necesidad necesidad);
        // bool InhabilitarNecesidad(Necesidad necesidad);
    }
}