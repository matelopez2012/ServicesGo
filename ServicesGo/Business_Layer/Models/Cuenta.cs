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
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string NombreUsuario { get; set; }

        [Required]
        [MaxLength(40)]
        public string Contrasena { get; set; }

        [Required]
        [MaxLength(15)]
        public string Rol { get; set; }

        public bool EstaAprobada { get; set; }

        [MaxLength(32)]
        public string Token { get; set; }
        
        public Cuenta(string nombreUsuario, string contrasena, string rol)
        {
            this.NombreUsuario = nombreUsuario;
            this.Contrasena = contrasena;
            this.Rol = rol;
            this.EstaAprobada = false;
        }
    }
}