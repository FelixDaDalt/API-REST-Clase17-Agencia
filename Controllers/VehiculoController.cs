using API_REST_Clase17_Vehiculos_Clientes_Ventas_.Contexto;
using API_REST_Clase17_Vehiculos_Clientes_Ventas_.Model;
using API_REST_Clase17_Vehiculos_Clientes_Ventas_.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace API_REST_Clase17_Vehiculos_Clientes_Ventas_.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VehiculoController : Controller
    {
        private IUnitOfWork context;

        public VehiculoController(IUnitOfWork context)
        {
            this.context = context;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Vehiculo vehiculo)
        {
            context.RepoVehiculo.Insert(vehiculo);
            context.save();
            return Ok();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Vehiculo>> GetAll()
        {
            
            return Ok(context.RepoVehiculo.GetAll());
        }

        [HttpGet("{Id}")]
        public ActionResult Get(int Id)
        {
            
            return Ok(context.RepoVehiculo.Get(Id));
        }

        [HttpDelete("{Id}")]
        public ActionResult Del(int Id)
        {
            context.RepoVehiculo.Del(Id);
            return Ok();
        }

        [HttpPut("{Id}")]
        public ActionResult Update([FromBody] Vehiculo vehiculo,int Id)
        {
            context.RepoVehiculo.Update(vehiculo);
            context.save();
            return Ok();
        }
    }
}
