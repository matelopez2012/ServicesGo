using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace ServicesGo.Models
{
    public class Administrador : Persona
    {


        [Key]
        public int Id { get; set; }
        //[ForeignKey("Person_Id")]
        public Persona persona  {get; set;}
        public int PersonaId { get; set; }

        [Timestamp]
        public Byte[] TimeStamp { get; set; }

        public Administrador(string nombreUsuario, string nombre, string apellidos, string cedula, string direccion, string telefono, string correoElectronico, string foto)
        : base(nombreUsuario, nombre, apellidos, cedula, direccion, telefono, correoElectronico, foto)
        {

        }

   
    }
}
