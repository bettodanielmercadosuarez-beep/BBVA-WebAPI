using System;
using System.Collections.Generic;

namespace bbva.Models;

public partial class Transferencia
{
    public int Id { get; set; }

    public int IdCuentaOrigen { get; set; }

    public string? CodigoInterbancario { get; set; }

    public decimal? Monto { get; set; }

    public decimal? Comision { get; set; }

    public decimal? Itf { get; set; }

    public string? TipoTransferencia { get; set; }

    public DateTime? FechaHora { get; set; }

    public string? NumeroOperacion { get; set; }

    public virtual Cuenta IdCuentaOrigenNavigation { get; set; } = null!;
}
