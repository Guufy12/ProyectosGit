using System;
using System.Collections.Generic;

namespace Actividad_1_unidad_3___Carlos_Perez.Models;

public partial class Compra
{
    public int CompraId { get; set; }

    public int ProveedoresId { get; set; }

    public DateOnly FechaCompras { get; set; }

    public decimal Total { get; set; }

    public virtual ICollection<DetallesCompra> DetallesCompras { get; set; } = new List<DetallesCompra>();

    public virtual Proveedore Proveedores { get; set; } = null!;
}
