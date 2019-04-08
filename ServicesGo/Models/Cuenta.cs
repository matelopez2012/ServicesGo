using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Models
{
    public class Cuenta
    {
        public string nombreUsuario { get; set; }
        public string contrasena { get; set; }
        public string rol { get; set; }
        public bool aprobada { get; set; }

        public Cuenta(String nombreUsuario, String contrasena, String rol)
        {
            this.nombreUsuario = nombreUsuario;
            this.contrasena = contrasena;
            this.rol = rol;
            this.aprobada = false;
        }
    }
}