using administacion.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace administacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnidadesController : ControllerBase
    {

        private readonly AdministacionEmpleadosContext _EmpleadosContext;
        public UnidadesController(AdministacionEmpleadosContext empleadosContext)
        {
            _EmpleadosContext = empleadosContext;
        }

        // GET: api/<EmpleadosControler>
        [HttpGet("unidades")]
        public async Task<ActionResult<Tblunidad>> ObtieneUnidades()
        {
            var unidades = await _EmpleadosContext.Tblunidads.ToListAsync();

            if (unidades == null || unidades.Count == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(unidades);
            }
        }

        //// GET: api/<UnidadesController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<UnidadesController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<UnidadesController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<UnidadesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<UnidadesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
