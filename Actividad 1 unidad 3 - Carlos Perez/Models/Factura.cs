using System;
using System.Collections.Generic;

namespace Actividad_1_unidad_3___Carlos_Perez.Models;

public partial class Factura
{
    public int FacturaId { get; set; }

    public int ClienteId { get; set; }

    public DateOnly FechaFactura { get; set; }

    public decimal Total { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual ICollection<DetallesFactura> DetallesFacturas { get; set; } = new List<DetallesFactura>();
}
