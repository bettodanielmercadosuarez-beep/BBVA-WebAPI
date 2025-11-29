using System;
using System.Collections.Generic;

namespace bbva.Models;

public partial class Cuenta
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public string? NombreCuenta { get; set; }

    public string? UltimosCuatroDigitos { get; set; }

    public decimal? Saldo { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual ICollection<Movimiento> Movimientos { get; set; } = new List<Movimiento>();

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();

    public virtual ICollection<Transferencia> Transferencia { get; set; } = new List<Transferencia>();
}
