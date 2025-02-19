using System;
using System.Collections.Generic;

namespace aplicacionproyect.Models;

public partial class RegistroHabito
{
    public int IdRegistro { get; set; }

    public int IdHabito { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Estado { get; set; }

    public virtual Habito IdHabitoNavigation { get; set; } = null!;
}
