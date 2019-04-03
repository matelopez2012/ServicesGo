using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ServicesGo.Models
{
    public class Administrador : Personna
    {
        [ForeignKey("Person_Id")]
        public virtual Persona Persona_Id { get; set; }
        public Administrator(string nombreUsuario, string nombre, string apellidos, string cedula, string direccion, string telefono, string correoElectronico, string foto)
        : base(nombreUsuario, nombre, apellidos, cedula, direccion, telefono, correoElectronico, foto)
        {

        }


    }
}
