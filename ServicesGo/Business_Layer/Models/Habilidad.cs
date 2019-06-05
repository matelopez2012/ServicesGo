using ServicesGo.Business_Layer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Models
{
    [Table("Habilidades")]
    public class Habilidad
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("HabilidadDefinidaRef")]
        public HabilidadDefinida HabilidadDefinidaRef { get; set; }

        [Required]
        [Range(0,100)]
        public int Experiencia { get; set; }

        [Required]
        [StringLength(300)]
        public string ConocimientosEspecificos { get; set; }

        public PrestadorServicios PrestadorServiciosRef { get; set; }

        public ICollection<Documento> DocumentosSoporte { get; set; }

        [Timestamp]
        public Byte[] TimeStamp { get; set; }


        public Habilidad(int id, HabilidadDefinida habilidadDefinidaRef, int experiencia, string conocimientosEspecificos, PrestadorServicios prestadorServiciosRef)
        {
            Id = id;
            HabilidadDefinidaRef = habilidadDefinidaRef;
            Experiencia = experiencia;
            ConocimientosEspecificos = conocimientosEspecificos;
            PrestadorServiciosRef = prestadorServiciosRef;
        }

        public Habilidad()
        {

        }

        public void añadirDocumentoSoporte(string nombreDocumento, string ruta)
        {
            Documento documento = new Documento(nombreDocumento, ruta);
        }


        public Documento buscarDocumento(String nombre)
        {
            List < Documento > doc = DocumentosSoporte.ToList();

            Documento documento = doc.Find(x => x.nombreDoc.Contains(nombre));

            return documento != null ? documento : null;
        }


        public void añadirDocumento(string nombreDoc, string ruta)
        {
            DocumentosSoporte.Add(new Documento(nombreDoc, ruta));
        }


        public void eliminarDocumento(string nombreDoc)
        {
            //Documento documento = buscarDocumento(nombre);
        //this.documentosSoporte.Remove(documento);

        }



    }
}