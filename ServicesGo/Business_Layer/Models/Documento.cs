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
        public string nombreDoc { get; set; }
        [Required]
        public string ruta { get; set; }
        public DateTime fecha { get; set}



        public Documento(string nombreDoc, string ruta)
        {
            nombreDoc = nombreDoc;
            ruta = ruta;
        }
        

    }
}