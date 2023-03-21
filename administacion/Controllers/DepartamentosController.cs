using administacion.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace administacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentosController : ControllerBase
    {

        private readonly AdministacionEmpleadosContext _EmpleadosContext;
        public DepartamentosController(AdministacionEmpleadosContext empleadosContext)
        {
            _EmpleadosContext = empleadosContext;
        }

        // GET: api/<EmpleadosControler>
        [HttpGet("departamentos")]
        public async Task<ActionResult<Tbldepartamento>> ObtieneDepartamentos()
        {
            var departamentos = await _EmpleadosContext.Tbldepartamentos.ToListAsync();

            if (departamentos == null || departamentos.Count == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(departamentos);
            }
        }

        //// GET: api/<DepartamentosController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<DepartamentosController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<DepartamentosController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<DepartamentosController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<DepartamentosController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
