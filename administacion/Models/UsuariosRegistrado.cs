using System;
using System.Collections.Generic;

namespace administacion.Models;

public partial class UsuariosRegistrado
{
    public int IdUsuario { get; set; }

    public string NombreCompleto { get; set; } = "";

    public string Alias { get; set; } = "";

    public string Correo { get; set; } = "";

    public int NumeroRegistro { get; set; }

    public string Contrasena { get; set; } = "";

    public int TipoUsuario { get; set; }
}
