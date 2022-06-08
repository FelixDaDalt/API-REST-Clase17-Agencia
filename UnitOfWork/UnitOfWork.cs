using API_REST_Clase17_Vehiculos_Clientes_Ventas_.Contexto;
using API_REST_Clase17_Vehiculos_Clientes_Ventas_.Repositorios;
using API_REST_Clase17_Vehiculos_Clientes_Ventas_.Repositorios.Implementaciones;

namespace API_REST_Clase17_Vehiculos_Clientes_Ventas_.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        public IRepoCliente RepoCliente { get; private set; }
        public IRepoVentas RepoVentas { get; private set; }
        public IRepoVehiculo RepoVehiculo { get; private set; }
        public IRepoUsuarios RepoUsuarios { get; private set; }
        private readonly Context _Context;

        public UnitOfWork(Context Context)
        {
            this._Context = Context;
            this.RepoCliente = new RepoCliente(Context);
            this.RepoVentas = new RepoVentas(Context);
            this.RepoVehiculo = new RepoVehiculo(Context);
            this.RepoUsuarios = new RepoUsuarios(Context);
        }

        public void save()
        {
            _Context.SaveChanges();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
