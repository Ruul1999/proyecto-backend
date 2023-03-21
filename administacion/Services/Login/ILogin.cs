using administacion.Models;
using administacion.Services.Login;


namespace administacion.Services.Login
{
    public interface ILogin
    {

        Task<UsuariosRegistrado?> ValidaUsuario(int numeroUsuario, string contrasena);


    }
}
