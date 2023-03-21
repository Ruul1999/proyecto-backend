using System;
using System.Collections.Generic;

namespace administacion.Models;

public partial class Tblpuesto
{
    public int ClavePuesto { get; set; }

    public string? NombrePuesto { get; set; }

    public int? ClaveDepartamento { get; set; }

    public int? ClaveUnidad { get; set; }

    public DateTime? FechaAlta { get; set; }
}
