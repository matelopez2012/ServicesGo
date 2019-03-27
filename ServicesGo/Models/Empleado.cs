
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ServicesGo.Models
{ 
public class Empleado : Persona

{
        public Empleado(string nombreUsuario, string nombre, string apellidos, string cedula, string direccion, string telefono, string correoElectronico, string foto)
        {
            this.nombreUsuario = nombreUsuario;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.cedula = cedula;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correoElectronico = correoElectronico;
            this.foto = foto;
        }

        private override string nombreUsuario { get; set; }
        private override string nombre { get; set; }
        private override string apellidos { get; set; }
        private override string cedula { get; set; }
        private override string direccion { get; set; }
        private override string telefono { get; set; }
        private override string correoElectronico { get; set; }
        private override string foto { get; set; }
    }

}
