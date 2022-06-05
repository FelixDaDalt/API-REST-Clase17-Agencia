using API_REST_Clase17_Vehiculos_Clientes_Ventas_.Contexto;
using API_REST_Clase17_Vehiculos_Clientes_Ventas_.Model;

namespace API_REST_Clase17_Vehiculos_Clientes_Ventas_.Repositorios.Implementaciones
{
    public class RepoVehiculo : RepoGenerico<Vehiculo>, IRepoVehiculo
    {
        public RepoVehiculo(Context context) : base(context)
        {

        }
    }
}
