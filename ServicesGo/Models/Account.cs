using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Models
{
    public class Account
    {
        private string nombreUsuario;
        private string contrasena;
        private string rol;
        private bool aprobada;

        public Account(String nombreUsuario, String contrasena, String rol)
        {
            this.nombreUsuario = nombreUsuario;
            this.contrasena = contrasena;
            this.rol = rol;
            this.aprobada = false;
        }

        /*Gets*/

        public string getNombreUsuario()
        {
            return this.nombreUsuario;
        }

        public string getContrasena()
        {
            return this.contrasena;
        }

        public string getRol()
        {
            return this.rol;
        }

        public bool getAprobada()
        {
            return this.aprobada;
        }

        /*Sets*/

        public void setAprobada(bool aprobada)
        {
            this.aprobada = aprobada;
        }
    }
}