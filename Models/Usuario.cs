using System;
using System.Collections.Generic;

namespace bbva.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string NumeroDocumento { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public int? IntentosFallidos { get; set; }

    public bool? Bloqueado { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
}
