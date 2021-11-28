using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Migrante> Migrantes { get; set; }
        public DbSet<Entidad> Entidades { get; set; }
        public DbSet<Emergencia> Emergencias { get; set; }
        public DbSet<ServicioEntidad> ServiciosEntidades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if(!optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = E-Migrant");
            }
        }

        // Manejo de Tablas Intermedias
        //  protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<TablaIntermedia>().HasKey(x=> new{x.Tabla1,x.Tabla2});
        // }
    }
}
