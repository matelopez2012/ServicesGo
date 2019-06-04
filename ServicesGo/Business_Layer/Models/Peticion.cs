using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Models
{
    [Table("Peticiones")]
    public class Peticion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Cuenta CuentaRef { get; set; }

        [Required]
        public Empleado EmpleadoRef { get; set; }

        [Required]
        [MaxLength(300)]
        public string Observacion { get; set; }

        [Required]
        public DateTime FechaMod { get; set; }

        [Required]
        public bool Resuelta { get; set; }

        public Peticion(Cuenta cuentaRef, Empleado empleadoRef, string observacion)
        {
            CuentaRef = cuentaRef;
            EmpleadoRef = empleadoRef;
            Observacion = observacion;
            FechaMod = DateTime.Today;
        }
    }
}