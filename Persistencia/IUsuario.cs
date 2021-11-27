using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IUsuario
    {
        IEnumerable<Usuario> ListarUsuarios();
        bool CreateUsuario(Usuario usuario); 
        Usuario ReadUsuario(string documento);       
        bool EditUsuario(Usuario usuario);        
        bool DeleteUsuario(string documento);        
    }
}