using API_REST_Clase17_Vehiculos_Clientes_Ventas_.Contexto;

namespace API_REST_Clase17_Vehiculos_Clientes_Ventas_.Repositorios
{
    public class RepoGenerico<TEntity> : IRepoGenerico<TEntity> where TEntity : class
    {
        private Context _context;

        public RepoGenerico(Context context)
        {
            this._context = context;
        }

        public TEntity Del(int id)
        {
            var entity = Get(id);
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
            return entity;
        }

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity Insert(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
