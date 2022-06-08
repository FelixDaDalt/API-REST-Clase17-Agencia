using API_REST_Clase17_Vehiculos_Clientes_Ventas_.Model;
using Microsoft.EntityFrameworkCore;

namespace API_REST_Clase17_Vehiculos_Clientes_Ventas_.Contexto
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { 
        
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
