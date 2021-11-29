using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public interface INovedad 
    {
        IEnumerable<Novedad> GetAllNovedad();

        // Añadir
        Novedad AddNovedad(Novedad novedad);

        // Actualizar
        Novedad UpdateNovedad(Novedad novedad);

        // Borrar
        bool DeleteNovedad(int idNovedad);

        // ver
        Novedad GetNovedad(int idNovedad);

    }
}