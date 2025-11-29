using System;
using System.Collections.Generic;

namespace bbva.Models;

public partial class Servicio
{
    public int Id { get; set; }

    public string? NombreServicio { get; set; }

    public string? Proveedor { get; set; }

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();
}
