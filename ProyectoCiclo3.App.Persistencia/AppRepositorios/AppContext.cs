using Microsoft.EntityFrameworkCore;
using ProyectoCiclo3.App.Dominio;
//Crear conexión con base de datos
namespace ProyectoCiclo3.App.Persistencia
{
    public class AppContext: DbContext{
        public DbSet<Encomienda> Encomiendas { get; set; } //Hacer DbSets de las otras clases
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = misiontic2022equipo0327.database.windows.net; Initial Catalog = ProyectoCiclo3; User ID=admin_equipo3_grupo27;Password=qWGmg8MWG9Q3qbK7");
            }
        } 
    }
}
