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
        [MaxLength(25)]
        public string nombreCuenta { get; set; }

        [Required]
        [MaxLength(25)]
        public string auditor { get; set; }

        [Required]
        [MaxLength(300)]
        public string observacion { get; set; }

        [Required]
        public DateTime fechaMod { get; set; }

        [Required]
        public bool resuelta { get; set; }

        public Peticion(string nombreCuenta, string auditor, string observacion)
        {
            this.nombreCuenta = nombreCuenta;
            this.auditor = auditor;
            this.observacion = observacion;
            this.fechaMod = DateTime.Today;
        }
    }
}