using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IEntidad
    {
        IEnumerable<Entidad> ListarEntidades();
        List<Entidad> ListarEntidadesList();
        bool CreateEntidad(Entidad entidad); 
        Entidad ReadEntidad(string documento, string userName);       
        Entidad ReadEntidad(string documento);       
        Entidad FindByUserName(string _userName);       
        bool EditEntidad(Entidad entidad);        
        bool DeleteEntidad(string documento);        
    }
}