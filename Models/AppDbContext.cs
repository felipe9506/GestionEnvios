using Microsoft.EntityFrameworkCore;
namespace GestionEnvios.Models
{
    //clase para representar el contexto de la base de datos
        public class AppDbContext : DbContext
        {
            //constructor para configurar la conexión a la base de datos
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }
            //propiedades para representar las tablas de la base de datos

            public DbSet<Shipment> Shipments { get; set; }

            public DbSet<Usuario> Usuarios { get; set; }
        }
    }

