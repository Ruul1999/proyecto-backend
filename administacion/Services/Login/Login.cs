using administacion.Models;
using Microsoft.EntityFrameworkCore;

namespace administacion.Services.Login
{
    public class Login : ILogin
    {
        private readonly AdministacionEmpleadosContext _userLogin;

        public Login(AdministacionEmpleadosContext administracionEmpleados)
        {
            _userLogin = administracionEmpleados;
        }

        public async Task<UsuariosRegistrado?> ValidaUsuario(int numeroUsuario, string contrasena)
        {
            var usuario = await _userLogin.UsuariosRegistrados.Where(e => 
                e.NumeroRegistro == numeroUsuario && e.Contrasena == contrasena
            ).FirstOrDefaultAsync();

            if(usuario == null)
            {
                return null;
            }
            else
            {
                return usuario;
            }
        }

    }
}
