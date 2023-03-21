using administacion.Models;
using administacion.Services.Login;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace administacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {

        private readonly ILogin _loginUser;
        private readonly AdministacionEmpleadosContext _context;
        public UserLoginController(AdministacionEmpleadosContext context, ILogin login)
        {
            _loginUser = login;
            _context = context;
        }

        // GET: api/<UserLoginController>
        [HttpGet]
        public async Task<ActionResult<UsuariosRegistrado>> ValidaUsuario(int numeroRegistro, string contrasena)
        {

            var usuario = await _loginUser.ValidaUsuario(numeroRegistro, contrasena);

            if (usuario == null)
            {
                return null;
            }
            else
            {
                return Ok(usuario);
            }

        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UsuariosRegistrado persona)
        {
            try
            {
                _context.UsuariosRegistrados.Add(persona);

                await _context.SaveChangesAsync();

                return Ok(persona);


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //// GET api/<UserLoginController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<UserLoginController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<UserLoginController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<UserLoginController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
