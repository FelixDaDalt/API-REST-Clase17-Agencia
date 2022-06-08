using API_REST_Clase17_Vehiculos_Clientes_Ventas_.Model;
using API_REST_Clase17_Vehiculos_Clientes_Ventas_.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.ModelBinding;
using API_REST_Clase17_Vehiculos_Clientes_Ventas_;

namespace API_REST_Clase17_Vehiculos_Clientes_Ventas_.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private IUnitOfWork context;

        public UsuarioController(IUnitOfWork context)
        {
            this.context = context;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Usuarios usuario)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            if(context.RepoUsuarios.Validar(usuario))
            {
                return BadRequest();
            }

            HashedPassword password = HashHelper.Hash(usuario.Clave);
            usuario.Clave = password.Password;
            usuario.sal = password.Salt;

            context.RepoUsuarios.Insert(usuario);
            context.save();
            return Ok();
        }

    }
}
