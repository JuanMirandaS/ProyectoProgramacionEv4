using System;
using System.Collections.Generic;

namespace ProyectoProgramacionEv4.git.Models
{
    public partial class AgendaCliente
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Proyecto { get; set; }
        public string? Empresa { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public DateTime? FechaDeIngreso { get; set; }
        public DateTime? HoraDeAgenda { get; set; }
        public DateTime? FechaHoraAtencionOficina { get; set; }
    }
}
