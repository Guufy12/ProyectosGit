using System;
using System.Collections.Generic;

namespace Actividad_1_unidad_3___Carlos_Perez.Models;

public partial class Proveedore
{
    public int ProveedoresId { get; set; }

    public string NombreProveedor { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? CorreoElectronico { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();
}
