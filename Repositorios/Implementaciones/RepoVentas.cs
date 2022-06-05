using API_REST_Clase17_Vehiculos_Clientes_Ventas_.Contexto;
using API_REST_Clase17_Vehiculos_Clientes_Ventas_.Model;
using Microsoft.EntityFrameworkCore;

namespace API_REST_Clase17_Vehiculos_Clientes_Ventas_.Repositorios.Implementaciones
{
    public class RepoVentas : RepoGenerico<Ventas>, IRepoVentas
    {
        private Context context;

        public RepoVentas(Context context) : base(context)
        {
            this.context = context;
        }

        public List<Ventas> GetTabla()
        {
            var aux = context.Ventas
                      .Include(cli => cli.Cliente)
                      .Include(vehi => vehi.Vehiculo)
                      .ToList();
            return aux;
        }

        public Ventas GetId(int id)
        {
            var aux = context.Ventas
                      .Include(cli => cli.Cliente)
                      .Include(vehi => vehi.Vehiculo)
                      .Where(x=>x.VentasId==id)
                      .FirstOrDefault();
            return aux;
        }
    }
}
