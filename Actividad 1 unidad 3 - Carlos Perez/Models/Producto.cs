using System;
using System.Collections.Generic;

namespace Actividad_1_unidad_3___Carlos_Perez.Models;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string NombreProducto { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Precio { get; set; }

    public int Stock { get; set; }

    public int CategoriaId { get; set; }

    public virtual Categoria Categoria { get; set; } = null!;

    public virtual ICollection<DetallesCompra> DetallesCompras { get; set; } = new List<DetallesCompra>();

    public virtual ICollection<DetallesFactura> DetallesFacturas { get; set; } = new List<DetallesFactura>();
}
