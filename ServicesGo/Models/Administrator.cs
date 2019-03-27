using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ServicesGo.Models
{
    public class Administrator : Person
    {
        public override string nombreUsuario { get; set; }
        public override string nombre { get; set; }
        public override string apellidos { get; set; }
        public override string cedula { get; set; }
        public override string direccion { get; set; }
        public override string telefono { get; set; }
        public override string correoElectronico { get; set; }
        public override string foto { get; set; }

        public Administrator(string nombreUsuario, string nombre, string apellidos, string cedula, string direccion, string telefono, string correoElectronico, string foto)
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

       
    }
}