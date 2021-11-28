using System;
using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepoNecesidad : INecesidad
    {
        private readonly AppContext _context;

        public RepoNecesidad(AppContext context)
        {
            _context = context;
        }
        
        List<Necesidad> INecesidad.ListarNecesidadesList()
        {
            return _context.Necesidades.ToList();
        }

        bool INecesidad.CreateNecesidad(Necesidad necesidad)
        {
            bool creado = false;
            try
            {
                _context.Necesidades.Add(necesidad) ;
                _context.SaveChanges();
                creado = true;
            }
            catch (System.Exception _ex)
            {
                Console.WriteLine("ERROR EMERGENCIA: " + _ex.Message);
                return creado;
            }
            return creado;
        }

        IEnumerable<Necesidad> INecesidad.ListarNecesidades()
        {
            var servicioEntidades = _context.Necesidades;
            return servicioEntidades;
        }
        Necesidad INecesidad.ReadById(int id, string user_id)
        {
            var necesidad = _context.Necesidades.FirstOrDefault(d => d.Id == id && d.UserId == user_id);
            return necesidad;
        }

        bool INecesidad.EditNecesidad(Necesidad necesidad)
        {
            bool actualizado = false;
            try
            {
                 //var munEncontrado = _context.Necesidades.Find(necesidad.Id);
                 var seEncontrado = _context.Necesidades.FirstOrDefault(a => a.Id == necesidad.Id);
                 if(seEncontrado != null)
                 {
                    seEncontrado.Categoria = necesidad.Categoria;
                    seEncontrado.Descripcion = necesidad.Descripcion;
                    seEncontrado.Prioridad = necesidad.Prioridad;
                    seEncontrado.Status= necesidad.Status;
                    _context.SaveChanges();
                    actualizado = true;
                 }
            }
            catch (System.Exception)
            {
                return actualizado;
            }
            return actualizado;
        }

        // bool INecesidad.InhabilitarNecesidad(Necesidad necesidad)
        // {
        //     bool actualizado = false;
        //     try
        //     {
        //          //var munEncontrado = _context.Necesidades.Find(necesidad.Id);
        //          var seEncontrado = _context.Necesidades.FirstOrDefault(a => a.Id == necesidad.Id);
        //          if(seEncontrado != null)
        //          {
        //             seEncontrado.Status= necesidad.Status;
        //             _context.SaveChanges();
        //             actualizado = true;
        //          }
        //     }
        //     catch (System.Exception)
        //     {
        //         return actualizado;
        //     }
        //     return actualizado;
        // }

    }
}