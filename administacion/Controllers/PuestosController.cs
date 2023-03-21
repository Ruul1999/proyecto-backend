using administacion.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace administacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PuestosController : ControllerBase
    {

        private readonly AdministacionEmpleadosContext _EmpleadosContext;
        public PuestosController(AdministacionEmpleadosContext empleadosContext)
        {
            _EmpleadosContext = empleadosContext;
        }

        // GET: api/<EmpleadosControler>
        [HttpGet("puestos")]
        public async Task<ActionResult<Tblpuesto>> ObtienePuestos()
        {
            var puestos = await _EmpleadosContext.Tblpuestos.ToListAsync();

            if (puestos == null || puestos.Count == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(puestos);
            }
        }

        //// GET: api/<PuestosController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<PuestosController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<PuestosController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<PuestosController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<PuestosController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
