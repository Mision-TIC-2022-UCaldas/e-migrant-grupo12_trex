using System;
using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepoEmergencia : IEmergencia
    {
        private readonly AppContext _context;

        public RepoEmergencia(AppContext context)
        {
            _context = context;
        }

        bool IEmergencia.CreateEmergencia(Emergencia emergencia)
        {
            bool creado = false;
            try
            {
                _context.Emergencias.Add(emergencia) ;
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

        List<Emergencia> IEmergencia.ListarEmergenciasList()
        {
            return _context.Emergencias.ToList();
        }
        bool IEmergencia.EditEmergencia(Emergencia emergencia)
        {
            bool actualizado = false;
            try
            {
                 //var munEncontrado = _context.Emergencias.Find(emergencia.Id);
                 var emeEncontrado = _context.Emergencias.FirstOrDefault(a => a.Id == emergencia.Id);
                 if(emeEncontrado != null)
                 {
                    emeEncontrado.Status= emergencia.Status;
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
        int IEmergencia.ReadEmergencia(string user_id, string estatus, string code)
        {
            var emergencias = _context.Emergencias.Count(d => d.MigranteId == user_id && d.Status == estatus && d.Codigo == code);
            return emergencias;
        }

        Emergencia IEmergencia.ReadById(int id, string user_id)
        {
            var emergencia = _context.Emergencias.FirstOrDefault(d => d.Id == id && d.MigranteId == user_id);
            return emergencia;
        }

        IEnumerable<Emergencia> IEmergencia.ListarEmergencias()
        {
            var emergencias = _context.Emergencias;
            return emergencias;
        }
    }
}