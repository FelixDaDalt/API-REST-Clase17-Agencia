using API_REST_Clase17_Vehiculos_Clientes_Ventas_.Contexto;
using API_REST_Clase17_Vehiculos_Clientes_Ventas_.Model;

namespace API_REST_Clase17_Vehiculos_Clientes_Ventas_.Repositorios.Implementaciones
{
    public class RepoUsuarios : RepoGenerico<Usuarios>, IRepoUsuarios
    {
        private Context _context;
        public RepoUsuarios(Context context):base(context)
        {
            _context = context;
        }

        public bool Validar(Usuarios usuario)
        {   

                if(_context.Usuarios.Where(x => x.Usuario == usuario.Usuario).Any())
                {
                    return true;
                }

            return false;
        }
    }
}
