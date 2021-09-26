using Microsoft.EntityFrameworkCore;
using GranjaAvicolaD.app.Dominio;

namespace GranjaAvicolaD.app.Persistencia{

    public class AppContext:DbContext{
        public DbSet<Usuario> Usuarios{get; set; }
        public DbSet<Sugerencias> Sugerencia{get; set; }
        //public DbSet<Roles> Rol{get; set; }
        public DbSet<Registro> Registros{get; set; }
        public DbSet<Historia> Historias{get; set; }
        public DbSet<Galpon> Galpones{get; set; }
        public DbSet<DatosInicioSesion> DatosInicioSesiones{get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if (!optionsBuilder.IsConfigured){
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = GranjaAvicolaDData");

            }
        }
    }
}