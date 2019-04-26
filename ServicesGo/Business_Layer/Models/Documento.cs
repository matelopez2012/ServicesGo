using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ServicesGo.Models
{
    [Table("Documentos")]
    public class Documento
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(30)]
        public string nombreDoc { get; set; }
        [Required]
        [StringLength(100)]
        public string ruta { get; set; }

        public Habilidad habilidad { get; set; }

        [Timestamp]
        public Byte[] TimeStamp { get; set; }

        public Documento()
        {

        }

        public Documento(string nombreDoc, string ruta, int habilidad)
        {
            nombreDoc = nombreDoc;
            ruta = ruta;
            habilidad = habilidad;
        }

        public Documento(string nombreDoc, string ruta)
        {
            nombreDoc = nombreDoc;
            ruta = ruta;
        }
    }
}