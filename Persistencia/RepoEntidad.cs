using System;
using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepoEntidad : IEntidad
    {
        private readonly AppContext _context;

        public RepoEntidad(AppContext context)
        {
            _context = context;
        }

        bool IEntidad.CreateEntidad(Entidad entidad)
        {
            bool creado = false;
            try
            {
                _context.Entidades.Add(entidad) ;
                _context.SaveChanges();
                creado = true;
            }
            catch (System.Exception _ex)
            {
                Console.WriteLine("ERROR USUARIO: " + _ex.Message);
                return creado;
            }
            return creado;
        }

        List<Entidad> IEntidad.ListarEntidadesList()
        {
            return _context.Entidades.ToList();
        }
        bool IEntidad.EditEntidad(Entidad entidad)
        {
            bool actualizado = false;
            try
            {
                 //var munEncontrado = _context.Entidades.Find(entidad.Id);
                 var ntEncontrado = _context.Entidades.FirstOrDefault(a => a.userName == entidad.userName);
                 if(ntEncontrado != null)
                 {
                    ntEncontrado.RazonSocial = entidad.RazonSocial;
                    ntEncontrado.NIT= entidad.NIT;
                    ntEncontrado.Direccion= entidad.Direccion;
                    ntEncontrado.Ciudad= entidad.Ciudad;
                    ntEncontrado.Telefono= entidad.Telefono;
                    ntEncontrado.Direccion_Electronica= entidad.Direccion_Electronica;
                    ntEncontrado.Pagina_Web= entidad.Pagina_Web;
                    ntEncontrado.Sector= entidad.Sector;
                    ntEncontrado.Servicios= entidad.Servicios;
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
        bool IEntidad.DeleteEntidad(string Nit)
        {
            bool eliminado = false;
            try
            {
                 var entidad = _context.Entidades.FirstOrDefault(d => d.NIT == Nit);
                 if(entidad != null)
                 {
                     _context.Entidades.Remove(entidad);
                     _context.SaveChanges();
                     eliminado = true;
                 }
            }
            catch (System.Exception)
            {
                return eliminado;
            }
            return eliminado;
        }
        Entidad IEntidad.ReadEntidad(string Nit, string userName)
        {
            Entidad entidad = _context.Entidades.FirstOrDefault(d => d.NIT == Nit || d.userName == userName);
            return entidad;
        }

        Entidad IEntidad.ReadEntidad(string Nit)
        {
            Entidad entidad = _context.Entidades.FirstOrDefault(d => d.NIT == Nit);
            return entidad;
        }

        Entidad IEntidad.FindByUserName(string _userName)
        {
            Entidad entidad = _context.Entidades.FirstOrDefault(d => d.userName == _userName);
            return entidad;
        }

        IEnumerable<Entidad> IEntidad.ListarEntidades()
        {
            return _context.Entidades;
        }
    }
}