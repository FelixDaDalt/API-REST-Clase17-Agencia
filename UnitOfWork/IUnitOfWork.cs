using API_REST_Clase17_Vehiculos_Clientes_Ventas_.Repositorios;

namespace API_REST_Clase17_Vehiculos_Clientes_Ventas_.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepoCliente RepoCliente { get; }
        IRepoVentas RepoVentas{ get; }
        IRepoVehiculo RepoVehiculo { get; }
        void save();

    }
}
