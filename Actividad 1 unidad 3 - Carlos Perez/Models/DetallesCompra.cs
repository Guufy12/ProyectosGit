using System;
using System.Collections.Generic;

namespace Actividad_1_unidad_3___Carlos_Perez.Models;

public partial class DetallesCompra
{
    public int DetalleCompraId { get; set; }

    public int CompraId { get; set; }

    public int ProductoId { get; set; }

    public int Cantidad { get; set; }

    public decimal CostoUnitario { get; set; }

    public decimal Impuesto { get; set; }

    public decimal Subtotal { get; set; }

    public virtual Compra Compra { get; set; } = null!;

    public virtual Producto Producto { get; set; } = null!;
}
