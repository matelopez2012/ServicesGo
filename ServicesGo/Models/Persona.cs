using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Models
{
    public class Persona
    {



        protected string _nombreUsuario;
        protected string _nombre;
        protected string _apellidos;
        protected string _cedula;
        protected string _direccion;
        protected string _telefono;
        protected string _correoElectronico;
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
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
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