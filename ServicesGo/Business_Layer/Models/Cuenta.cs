using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Models
{
    [Table("Cuentas")]
    public class Cuenta
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 8)]
        public string NombreUsuario { get; set; }

        [Required]
        [MaxLength(40)]
        public string Contrasena { get; set; }

        [Required]
        [MaxLength(15)]
        public string Rol { get; set; }

        public bool Verificada { get; set; }

        [MaxLength(32)]
        public string Token { get; set; }
        
        public Cuenta(int id, string nombreUsuario, string contrasena, string rol)
        {
            Id = id;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            Rol = rol;
            Verificada = false;
        }

        public Cuenta () { }
    }
}