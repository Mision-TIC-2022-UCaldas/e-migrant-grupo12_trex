using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public class RepoNovedad : INovedad
    {
        /// <summary>
        /// Referencia al contexto de Diagostico
        /// </summary>

        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="AppContext"></param>//
        public RepoNovedad (AppContext AppContext)
        {
            _appContext=AppContext;
        }
        Novedad INovedad.AddNovedad(Novedad novedad)
        {
            var novedadAdicionado= _appContext.Novedad.Add(novedad);
            _appContext.SaveChanges();
            return novedadAdicionado.Entity;
        }


        bool INovedad.DeleteNovedad(int idNovedad)
        {
            var NovedadEncontrado= _appContext.Novedad.FirstOrDefault(m=>m.Id == idNovedad);
            if(NovedadEncontrado==null)
                return false;
            _appContext.Novedad.Remove(NovedadEncontrado);
            _appContext.SaveChanges();
            return true;
        }

        IEnumerable<Novedad> INovedad.GetAllNovedad()
        {
            return _appContext.Novedad;
        }

        Novedad INovedad.GetNovedad(int idNovedad)
        {
            return _appContext.Novedad.FirstOrDefault(m=>m.Id == idNovedad);
        }

        Novedad INovedad.UpdateNovedad(Novedad novedad)
        {
            var novedadEncontrada = _appContext.Novedad.FirstOrDefault(m=>m.Id == novedad.Id);
            if (novedadEncontrada!=null)
            {
                novedadEncontrada.FechaInicio = novedad.FechaInicio;
                novedadEncontrada.DiasNovedad = novedad.DiasNovedad;
                novedadEncontrada.Descripcion = novedad.Descripcion;
                
                _appContext.SaveChanges();
            }
            return novedadEncontrada;
        }
        
    }
}