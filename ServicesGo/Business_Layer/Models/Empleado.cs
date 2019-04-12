﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace ServicesGo.Models
{

    [Table("Empleados")]
    public class Empleado : Persona
{

        [Key]
        [Required]
        [MaxLength(30)]
        public string cedula { get; set; }

        public Empleado(string nombreUsuario, string nombre, string apellidos, string cedula, string direccion, string telefono, string correoElectronico, string foto)
            : base(nombreUsuario,  nombre,  apellidos,  cedula, direccion,  telefono,  correoElectronico,  foto)
        {
            this.cedula = cedula;
            
        }
       
        
    }

}
