using System;
using System.Collections.Generic;

namespace ProyectoProgramacionEv4.git.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Proyectos = new HashSet<Proyecto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Empresa { get; set; } = null!;
        public string? Telefono { get; set; }
        public string Correo { get; set; } = null!;
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaHoraAtencionOficina { get; set; }

        public virtual ICollection<Proyecto> Proyectos { get; set; }
    }
}
