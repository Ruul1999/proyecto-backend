using System;
using System.Collections.Generic;

namespace administacion.Models;

public partial class Tblunidad
{
    public int ClaveUnidad { get; set; }

    public string? NombreUnidad { get; set; }

    public DateTime? FechaAlta { get; set; }
}
