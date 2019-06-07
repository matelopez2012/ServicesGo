
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace ServicesGo.Business_Layer.Models
{

    [Table("Empleados")]
    public class Empleado : Persona
    {
        public Empleado(Cuenta cuentaRef, string nombre, string apellidos, string cedula, string direccion, string telefono, string correoElectronico, string foto)
            : base(cuentaRef,  nombre,  apellidos,  cedula, direccion,  telefono,  correoElectronico,  foto)
        {
            this.Documento = cedula;
            
        }

        public Empleado() { }
    }
}
