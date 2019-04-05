using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Models
{
    public class Habilidad
    {
        private string nombre { get; set; }
        private int experiencia { get; set; }
        private string conocimientosEspecificos { get; set; }
        private List<Documento> documentosSoporte { get; set; }

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
    }
}