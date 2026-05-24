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
<<<<<<< HEAD
            public DbSet<Shipment> Shipments { get; set; }
=======
            public DbSet<shipment> Shipments { get; set; }
>>>>>>> 52c012a4f7a60ed63a4c1e2f4a27768957515cc4
            public DbSet<Usuario> Usuarios { get; set; }
        }
    }

