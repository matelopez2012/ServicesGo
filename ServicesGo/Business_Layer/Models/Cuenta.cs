using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ServicesGo.Models
{
    [Table("Cuentas")]
    public class Cuenta
    {
        [Key]
        public int id;

        [Required]
        [MaxLength(25)]
        public string nombreUsuario { get; set; }

        [Required]
        [MaxLength(40)]
        public string contrasena { get; set; }

        [Required]
        [MaxLength(15)]
        public string rol { get; set; }

        [Required]
        public bool aprobada { get; set; }

        [Required]
        public string token { get; set; }
        
        public Cuenta(string nombreUsuario, string contrasena, string rol)
        {
            this.nombreUsuario = nombreUsuario;
            this.contrasena = contrasena;
            this.rol = rol;
            this.aprobada = false;
        }
    }
}