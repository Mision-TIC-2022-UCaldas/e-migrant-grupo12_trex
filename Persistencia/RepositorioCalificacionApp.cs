using Dominio;
using System.Linq;
using Persistencia;


namespace Persistencia{

    public class RepositorioCalificacionApp: IRepositorioCalificacionApp{
        private readonly AppContext _appContext = new AppContext();

        public CalificacionApp AddCalificacionApp(CalificacionApp calificacionApp)
        {
            var CalificacionAdicionada= _appContext.CalificacionApp.Add(calificacionApp);
            _appContext.SaveChanges();
           return CalificacionAdicionada.Entity;
        }
    }
}