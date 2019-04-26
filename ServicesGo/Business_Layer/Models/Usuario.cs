﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

   
namespace ServicesGo.Models
{
    [Table("Usuarios")]
    public class Usuario : Persona

        
    {
        [Key]
        public int id { get; set; }

        //public Persona persona { get; set; }

        public Usuario(string nombreUsuario, string nombre, string apellidos, string cedula, string direccion,
            string telefono, string correoElectronico, string foto)
            : base (nombreUsuario, nombre, apellidos, cedula, direccion, telefono, correoElectronico, foto)
        {

        }

        public Usuario()
        {

        }


    }
}