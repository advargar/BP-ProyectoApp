using Microsoft.EntityFrameworkCore;
using BP_Proyecto.Models;

namespace BP_Proyecto.Models
{
    public class BPProyectoContext : DbContext
    {
        public BPProyectoContext(DbContextOptions<BPProyectoContext> options) : base(options)
        {
        }
        public DbSet<BP_Proyecto.Models.Client> Client { get; set; } = default!;
        public DbSet<BP_Proyecto.Models.Policy> Policy { get; set; } = default!;
        public DbSet<BP_Proyecto.Models.User> User { get; set; } = default!;

        public string Conexion { get; }

        public BPProyectoContext(string valor)
        {
            Conexion = valor;
        }
        // Define your DbSet properties here, for example:
        // public DbSet<YourEntity> YourEntities { get; set; }
    }
}
