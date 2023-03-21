using administacion.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace administacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosControler : ControllerBase
    {

        private readonly AdministacionEmpleadosContext _EmpleadosContext;
        public EmpleadosControler(AdministacionEmpleadosContext empleadosContext)
        {
            _EmpleadosContext = empleadosContext;
        }

        // GET: api/<EmpleadosControler>
        [HttpGet("empleados")]
        public async Task<ActionResult<Tblempleado>> ObtieneEmpleados()
        {
            var empleados = await _EmpleadosContext.Tblempleados.ToListAsync();

            if (empleados == null || empleados.Count == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(empleados); 
            }

            //return new string[] { "value1", "value2" };
        }

        //// GET: api/<EmpleadosControler>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<EmpleadosControler>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<EmpleadosControler>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<EmpleadosControler>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<EmpleadosControler>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
