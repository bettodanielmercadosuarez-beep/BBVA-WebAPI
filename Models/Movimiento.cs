using System;
using System.Collections.Generic;

namespace bbva.Models;

public partial class Movimiento
{
    public int Id { get; set; }

    public int IdCuenta { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Monto { get; set; }

    public virtual Cuenta IdCuentaNavigation { get; set; } = null!;
}
