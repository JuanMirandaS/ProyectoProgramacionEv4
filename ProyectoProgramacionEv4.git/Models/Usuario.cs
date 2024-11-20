﻿using System;
using System.Collections.Generic;

namespace ProyectoProgramacionEv4.git.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string ContrasenaHash { get; set; } = null!;
        public string Rol { get; set; } = null!;
    }
}
