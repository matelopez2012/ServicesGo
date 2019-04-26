using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ServicesGo.Models
{
    [Table("Personas")]
    public class Persona
    {
        [Key]
        public int id { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(25)]
   
        public string cedula { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(25)]
        public string nombreUsuario { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(25)]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50)]
        public string apellidos { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(35)]
        public string direccion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(15)]
        public string telefono { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(35)]
        public string correoElectronico { get; set; }

 
        public Cuenta cuenta { get; set; }

        
        public string foto { get; set; }

        [Timestamp]
        public Byte[] TimeStamp { get; set; }

        public Persona(string nombreUsuario, string nombre, string apellidos, string cedula, string direccion, string telefono, string correoElectronico, string foto)
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

        public Persona()
        {

        }

    }

}

