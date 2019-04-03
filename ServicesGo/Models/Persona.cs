using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ServicesGo.Models
{
    public class Persona
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(25)]
        public string _nombreUsuario;
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(25)]
        protected string _nombre;
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50)]
        protected string _apellidos;
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(25)]
        protected string _cedula;
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(35)]
        protected string _direccion;
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(15)]
        protected string _telefono;
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(35)]
        protected string _correoElectronico;
        [Required(ErrorMessage = "El campo {0} es requerido")]
        protected string _foto;

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


        public string nombreUsuario
        {
            get => _nombreUsuario;
            set => _nombreUsuario = value;
        }

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }

        public string cedula
        {
            get { return _cedula; }
            set { _cedula = value; }
        }

        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public string telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }


        public string correoElectronico
        {
            get { return _correoElectronico; }
            set { _correoElectronico = value; }
        }

        public string foto
        {
            get { return _foto; }
            set { _foto = value; }
        }
    }

}