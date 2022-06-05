using API_REST_Clase17_Vehiculos_Clientes_Ventas_.Model;
using API_REST_Clase17_Vehiculos_Clientes_Ventas_.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace API_REST_Clase17_Vehiculos_Clientes_Ventas_.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClienteController : Controller
    {
        private IUnitOfWork context;

        public ClienteController(IUnitOfWork context)
        {
            this.context = context;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cliente cliente)
        {
            context.RepoCliente.Insert(cliente);
            context.save();
            return Ok();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> GetAll()
        {

            return Ok(context.RepoCliente.GetAll());
        }

        [HttpGet("{Id}")]
        public ActionResult Get(int Id)
        {

            return Ok(context.RepoCliente.Get(Id));
        }

        [HttpDelete("{Id}")]
        public ActionResult Del(int Id)
        {
            context.RepoCliente.Del(Id);
            return Ok();
        }

        [HttpPut("{Id}")]
        public ActionResult Update([FromBody] Cliente cliente, int Id)
        {
            context.RepoCliente.Update(cliente);
            context.save();
            return Ok();
        }
    }
}
