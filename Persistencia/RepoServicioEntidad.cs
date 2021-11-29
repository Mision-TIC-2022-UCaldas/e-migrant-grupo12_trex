using System;
using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{

    //  public class NewClass
    // {
    //     public int Id { get; set; }
    //     public string UserId { get; set; }
    // }

    public class RepoServicioEntidad : IServicioEntidad
    {
        private readonly AppContext _context;

        public RepoServicioEntidad(AppContext context)
        {
            _context = context;
        }
        
        List<ServicioEntidad> IServicioEntidad.ListarServiciosEntidadesList()
        {
            return _context.ServiciosEntidades.ToList();
        }

        bool IServicioEntidad.CreateServicioEntidad(ServicioEntidad servicioEntidad)
        {
            bool creado = false;
            try
            {
                _context.ServiciosEntidades.Add(servicioEntidad) ;
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

        IEnumerable<ServicioEntidad> IServicioEntidad.ListarServiciosEntidades()
        {
            var servicioEntidades = _context.ServiciosEntidades;
            return servicioEntidades;
        }
        ServicioEntidad IServicioEntidad.ReadById(int id, string user_id)
        {
            var servicioEntidad = _context.ServiciosEntidades.FirstOrDefault(d => d.Id == id && d.UserId == user_id);
            return servicioEntidad;
        }
        ServicioEntidad IServicioEntidad.ReadByOnlyId(int id)
        {
            var servicioEntidad = _context.ServiciosEntidades.FirstOrDefault(d => d.Id == id);
            return servicioEntidad;
        }

        bool IServicioEntidad.EditServicioEntidad(ServicioEntidad servicioEntidad)
        {
            bool actualizado = false;
            try
            {
                 //var munEncontrado = _context.ServiciosEntidades.Find(servicioEntidad.Id);
                 var seEncontrado = _context.ServiciosEntidades.FirstOrDefault(a => a.Id == servicioEntidad.Id);
                 if(seEncontrado != null)
                 {
                    seEncontrado.Categoria = servicioEntidad.Categoria;
                    seEncontrado.Nombre = servicioEntidad.Nombre;
                    seEncontrado.CapacidadMAX = servicioEntidad.CapacidadMAX;
                    seEncontrado.FechaIni = servicioEntidad.FechaIni;
                    seEncontrado.FechaFin = servicioEntidad.FechaFin;
                    seEncontrado.Status= servicioEntidad.Status;
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

        bool IServicioEntidad.InhabilitarServicioEntidad(ServicioEntidad servicioEntidad)
        {
            bool actualizado = false;
            try
            {
                 //var munEncontrado = _context.ServiciosEntidades.Find(servicioEntidad.Id);
                 var seEncontrado = _context.ServiciosEntidades.FirstOrDefault(a => a.Id == servicioEntidad.Id);
                 if(seEncontrado != null)
                 {
                    seEncontrado.Status= servicioEntidad.Status;
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

        // public IQueryable<NewClass> FindAllServicios()
        // {
        //     return from n in db.ServicioEntidad
        //            join c in db.Entidad on n.UserId equals c.UserName
        //            select new NewClass() 
        //            { 
        //               Id = n.Id, 
        //               UserId = c.UserName                 
        //            };
        // }


        


    }
}


// using System;
// using System.Collections.Generic;
// using Dominio;
// using System.Linq;

// namespace Persistencia
// {
//     public class RepoServicioEntidad : IServicioEntidad
//     {
        
//         List<ServicioEntidad> IServicioEntidad.ListarServiciosEntidadesList()
//         {
//             return _context.ServiciosEntidades.ToList();
//         }
//         bool IServicioEntidad.EditServicioEntidad(ServicioEntidad servicioEntidad)
//         {
//             bool actualizado = false;
//             try
//             {
//                  //var munEncontrado = _context.ServiciosEntidades.Find(servicioEntidad.Id);
//                  var seEncontrado = _context.ServiciosEntidades.FirstOrDefault(a => a.Id == servicioEntidad.Id && a.UserId == servicioEntidad.UserId);
//                  if(seEncontrado != null)
//                  {
//                     seEncontrado.Nombre = servicioEntidad.Nombre;
//                     seEncontrado.CapacidadMAX = servicioEntidad.CapacidadMAX;
//                     seEncontrado.FechaIni = servicioEntidad.FechaIni;
//                     seEncontrado.FechaFin = servicioEntidad.FechaFin;
//                     seEncontrado.Status= servicioEntidad.Status;
//                     _context.SaveChanges();
//                     actualizado = true;
//                  }
//             }
//             catch (System.Exception)
//             {
//                 return actualizado;
//             }
//             return actualizado;
//         }
//         int IServicioEntidad.ReadServicioEntidad(string user_id, string estatus)
//         {
//             var servicioEntidades = _context.ServiciosEntidades.Count(d => d.UserId == user_id && d.Status == estatus);
//             return servicioEntidades;
//         }

//         ServicioEntidad IServicioEntidad.ReadById(int id, string user_id)
//         {
//             var servicioEntidad = _context.ServiciosEntidades.FirstOrDefault(d => d.Id == id && d.UserId == user_id);
//             return servicioEntidad;
//         }

//         IEnumerable<ServicioEntidad> IServicioEntidad.ListarServiciosEntidades()
//         {
//             var servicioEntidades = _context.ServiciosEntidades;
//             return servicioEntidades;
//         }
//     }
// }