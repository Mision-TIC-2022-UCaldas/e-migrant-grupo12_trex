using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IMigrante
    {
        IEnumerable<Migrante> ListarMigrantes();
        List<Migrante> ListarMigrantesList();
        bool CreateMigrante(Migrante migrante); 
        Migrante ReadMigrante(string documento);       
        Migrante FindByUserName(string _userName);       
        bool EditMigrante(Migrante migrante);        
        bool DeleteMigrante(string documento);        
    }
}