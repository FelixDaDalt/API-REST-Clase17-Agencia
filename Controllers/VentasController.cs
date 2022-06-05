using API_REST_Clase17_Vehiculos_Clientes_Ventas_.Model;
using API_REST_Clase17_Vehiculos_Clientes_Ventas_.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_REST_Clase17_Vehiculos_Clientes_Ventas_.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VentasController : Controller
    {
        private IUnitOfWork context;

        public VentasController(IUnitOfWork context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<List<Ventas>> GetAll()
        {
            return Ok(context.RepoVentas.GetTabla());
        }

        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            return Ok(context.RepoVentas.GetId(Id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Ventas venta)
        {
            return Ok(context.RepoVentas.Insert(venta));
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            return Ok(context.RepoVentas.Del(Id));
        }

        [HttpPut("{Id}"]
        public IActionResult Update(Ventas update, int Id)
        {
            return Ok(context.RepoVentas.Update(update));
        }
    }
}
