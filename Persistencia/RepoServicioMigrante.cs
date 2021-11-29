using System;
using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepoServicioMigrante : IServicioMigrante
    {
        private readonly AppContext _context;

        public RepoServicioMigrante(AppContext context)
        {
            _context = context;
        }
        
        List<ServicioMigrante> IServicioMigrante.ListarServiciosMigrantesList()
        {
            return _context.ServiciosMigrantes.ToList();
        }
        int IServicioMigrante.Total(string id, string user_id, string estatus)
        {
            var total = _context.ServiciosMigrantes.Count(d => d.ServicioEntidadId == id && d.Status == estatus && d.UserId == user_id);
            return total;
        }

        

        bool IServicioMigrante.CreateServicioMigrante(ServicioMigrante servicioMigrante)
        {
            bool creado = false;
            try
            {
                _context.ServiciosMigrantes.Add(servicioMigrante) ;
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

        IEnumerable<ServicioMigrante> IServicioMigrante.ListarServiciosMigrantes()
        {
            var servicioEntidades = _context.ServiciosMigrantes;
            return servicioEntidades;
        }
        ServicioMigrante IServicioMigrante.ReadById(int id, string user_id)
        {
            var servicioMigrante = _context.ServiciosMigrantes.FirstOrDefault(d => d.Id == id && d.UserId == user_id);
            return servicioMigrante;
        }

        ServicioMigrante IServicioMigrante.Read(int id, string user_id, string estatus)
        {
            var servicioMigrante = _context.ServiciosMigrantes.FirstOrDefault(d => d.Id == id && d.UserId == user_id && d.Status == estatus);
            return servicioMigrante;
        }

        bool IServicioMigrante.EditServicioMigrante(ServicioMigrante servicioMigrante)
        {
            bool actualizado = false;
            try
            {
                 //var munEncontrado = _context.ServiciosMigrantes.Find(servicioMigrante.Id);
                 var seEncontrado = _context.ServiciosMigrantes.FirstOrDefault(a => a.Id == servicioMigrante.Id);
                 if(seEncontrado != null)
                 {
                    seEncontrado.UserId = servicioMigrante.UserId;
                    seEncontrado.ServicioEntidadId = servicioMigrante.ServicioEntidadId;
                    seEncontrado.Categoria = servicioMigrante.Categoria;
                    seEncontrado.Status= servicioMigrante.Status;
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
    }
}