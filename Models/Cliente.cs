using System;
using System.Collections.Generic;

namespace bbva.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public int IdUsuario { get; set; }

    public string Nombre { get; set; } = null!;

    public int ScoreCrediticio { get; set; }

    public virtual ICollection<Cuenta> Cuenta { get; set; } = new List<Cuenta>();

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
