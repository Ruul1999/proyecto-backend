using System;
using System.Collections.Generic;

namespace administacion.Models;

public partial class Tblempleado
{
    public int ClaveEmpleado { get; set; }

    public string? Nombre { get; set; }

    public string? ApellidoPaterno { get; set; }

    public string? ApellidoMaterno { get; set; }

    public string? Rfc { get; set; }

    public int? IdUnidad { get; set; }

    public int? IdDepartamento { get; set; }

    public int? IdPuesto { get; set; }

    public decimal? Sueldo { get; set; }

    public int? EstadoCivil { get; set; }

    public int? NivelEstudios { get; set; }

    public DateTime? FechaInicio { get; set; }
}
