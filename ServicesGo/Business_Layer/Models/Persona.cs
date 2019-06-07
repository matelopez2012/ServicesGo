using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Models
{
    [Table("Personas")]
    public class Persona
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(80, MinimumLength = 6)]
        public string Correo { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 8)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 6)]
        public string Documento { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 7)]
        public string Telefono { get; set; }

        [StringLength(40, MinimumLength = 3)]
        public string Foto { get; set; }


        public Cuenta CuentaRef { get; set; }

        [Timestamp]
        public Byte[] TimeStamp { get; set; }


        public Persona(Cuenta CuentaRef, string nombre, string apellidos, string cedula, string direccion, string telefono, string correoElectronico, string foto)
        {
            this.CuentaRef = CuentaRef;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Documento = cedula;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Correo = correoElectronico;
            this.Foto = foto;
        }

        public Persona(int id, Cuenta CuentaRef, string nombre, string apellidos, string cedula, string correoElectronico)
        {
            this.Id = id;
            this.CuentaRef = CuentaRef;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Documento = cedula;
            this.Correo = correoElectronico;
        }

        public Persona() { }
    }

}

