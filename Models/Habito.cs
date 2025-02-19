using System;
using System.Collections.Generic;

namespace aplicacionproyect.Models;

public partial class Habito
{
    public int IdHabito { get; set; }

    public int IdUsuario { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Duracion { get; set; }

    public string? Tipo { get; set; }

    public string? Color { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string? Estado { get; set; }

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<RegistroHabito> RegistroHabitos { get; set; } = new List<RegistroHabito>();
}
