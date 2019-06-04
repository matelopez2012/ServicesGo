using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Models
{
    [Table("Profesiones")]
    public class Profesion
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(40)]
        public string nombreProfesion { get; set; }

        [Required]
        public int experiencia { get; set; }

        [Required]
        [StringLength(300)]
        public string conocimientos { get; set; }

        public Documento certificado { get; set; }

        public Documento tarjetaProfesional { get; set; }

        public Profesion(string nombreProfesion, int experiencia, string conocimientos)
        {
            this.nombreProfesion = nombreProfesion;
            this.experiencia = experiencia;
            this.conocimientos = conocimientos;
        }
    }
}