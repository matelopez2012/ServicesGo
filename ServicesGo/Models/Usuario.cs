using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Models
{
    public class Usuario : Persona
    {

        public Usuario(string nombreUsuario, string nombre, string apellidos, string cedula, string direccion,
            string telefono, string correoElectronico, string foto)
            : base (nombreUsuario, nombre, apellidos, cedula, direccion, telefono, correoElectronico, foto)
        {

        }
      
    }
}