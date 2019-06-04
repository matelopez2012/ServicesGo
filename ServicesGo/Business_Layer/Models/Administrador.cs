﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace ServicesGo.Business_Layer.Models
{
    [Table ("Administradores")]
    public class Administrador : Persona
    {


        [Key]
        public int id { get; set; }
        //[ForeignKey("Person_Id")]
        //public Persona persona  {get; set;}
        //public int PersonaId { get; set; }

        

        public Administrador(string nombreUsuario, string nombre, string apellidos, string cedula, string direccion,
            string telefono, string correoElectronico, string foto)
        : base(nombreUsuario, nombre, apellidos, cedula, direccion, telefono, correoElectronico, foto)
        {


        }

        public Administrador()
        {

        }


    }
}
