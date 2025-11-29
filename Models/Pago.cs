using System;
using System.Collections.Generic;

namespace bbva.Models;

public partial class Pago
{
    public int Id { get; set; }

    public int IdCuenta { get; set; }

    public int IdServicio { get; set; }

    public decimal? Monto { get; set; }

    public decimal? Comision { get; set; }

    public DateTime? FechaHora { get; set; }

    public string? NumeroOperacion { get; set; }

    public virtual Cuenta IdCuentaNavigation { get; set; } = null!;

    public virtual Servicio IdServicioNavigation { get; set; } = null!;
}
