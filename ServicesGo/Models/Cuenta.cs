using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Models
{
    public class Cuenta
    {
        private string nombreUsuario { get; set; }
        private string contrasena { get; set; }
        private string rol { get; set; }
        private bool aprobada { get; set; }

        public Cuenta(String nombreUsuario, String contrasena, String rol)
        {
            this.nombreUsuario = nombreUsuario;
            this.contrasena = contrasena;
            this.rol = rol;
            this.aprobada = false;
        }
    }
}