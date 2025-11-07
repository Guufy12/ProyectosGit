using System;
using System.Collections.Generic;

namespace Actividad_1_unidad_3___Carlos_Perez.Models;

public partial class Cliente
{
    public int ClienteId { get; set; }

    public string NombreCompleto { get; set; } = null!;

    public string CorreoElectronico { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}
