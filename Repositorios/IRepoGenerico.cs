namespace API_REST_Clase17_Vehiculos_Clientes_Ventas_.Repositorios
{
    public interface IRepoGenerico<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        TEntity Del(int id);
        TEntity Update(TEntity entity);
        TEntity Insert(TEntity entity);            
    }
}
