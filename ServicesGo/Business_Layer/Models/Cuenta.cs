﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Models
{
    [Table("Cuenta")]
    public class Cuenta
    {
        public string nombreUsuario { get; set; }
        public string contrasena { get; set; }
        public string rol { get; set; }
        public bool aprobada { get; set; }

        public Cuenta(string nombreUsuario, string contrasena, string rol)
        {
            this.nombreUsuario = nombreUsuario;
            this.contrasena = contrasena;
            this.rol = rol;
            this.aprobada = false;
        }
    }
}