using API_REST_Clase17_Vehiculos_Clientes_Ventas_.Model;

namespace API_REST_Clase17_Vehiculos_Clientes_Ventas_.Repositorios
{
    public interface IRepoVentas : IRepoGenerico<Ventas>
    {
        List<Ventas> GetTabla();
        Ventas GetId(int id);
    }
}
