using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ServicesGo.Models
{
    [Table("Habilidades")]
    public class Habilidad
    {
        
        
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }
        [Required]
        //[MaxLength(1), MinLength(5)]
        public int experiencia { get; set; }
        [Required]
        [StringLength(300)]
        public string conocimientosEspecificos { get; set; }

       // [ForeignKey("Document")]
        public ICollection<Documento> documentosSoporte { get; set; }

        //public PrestadorServicios prestadorservicios { get; set; }

        [Timestamp]
        public Byte[] TimeStamp { get; set; }

       

        public Habilidad()
        {

        }

        public Habilidad(string nombre, int experiencia, string conocimientosEpecificos)
        {
            nombre = nombre;
            experiencia = experiencia;
            conocimientosEspecificos = conocimientosEspecificos;
        }

        public void añadirDocumentoSoporte(string nombreDocumento, string ruta)
        {
            Documento documento = new Documento(nombreDocumento, ruta);
        }


        public Documento buscarDocumento(String nombre)
        {
            List < Documento > doc = documentosSoporte.ToList();

            Documento documento = doc.Find(x => x.nombreDoc.Contains(nombre));

            return documento != null ? documento : null;

        }


        public void añadirDocumento(string nombreDoc, string ruta)
        {
            documentosSoporte.Add(new Documento(nombreDoc, ruta));
        }


        public void eliminarDocumento(string nombreDoc)
        {
            Documento documento = buscarDocumento(nombre);
            this.documentosSoporte.Remove(documento);

        }



    }
}