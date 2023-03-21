using System;
using System.Collections.Generic;

namespace administacion.Models;

public partial class Tbldepartamento
{
    public int ClaveDepartamento { get; set; }

    public string? NombreDepartamento { get; set; }

    public int? ClaveUnidad { get; set; }

    public DateTime? FechaAlta { get; set; }
}
