using System;
using System.Collections.Generic;

namespace ProyectoProgramacionEv4.git.Models
{
    public partial class Proyecto
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime? FechaCreacion { get; set; }

        public virtual Cliente Cliente { get; set; } = null!;
    }
}
