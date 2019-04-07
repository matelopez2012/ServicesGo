using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace ServicesGo.Models
{
    public class Administrador : Persona
    {
        [ForeignKey("Person_Id")]
        public virtual Persona Persona_Id { get; set; }

        public Administrador(string nombreUsuario, string nombre, string apellidos, string cedula, string direccion, string telefono, string correoElectronico, string foto)
        : base(nombreUsuario, nombre, apellidos, cedula, direccion, telefono, correoElectronico, foto)
        {

        }


    }
}
