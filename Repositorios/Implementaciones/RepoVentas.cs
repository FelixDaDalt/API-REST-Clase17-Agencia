using API_REST_Clase17_Vehiculos_Clientes_Ventas_.Contexto;
using API_REST_Clase17_Vehiculos_Clientes_Ventas_.Model;

namespace API_REST_Clase17_Vehiculos_Clientes_Ventas_.Repositorios.Implementaciones
{
    public class RepoVentas : RepoGenerico<Ventas>, IRepoVentas
    {
        public RepoVentas(Context context) : base(context)
        {

        }
    }
}
