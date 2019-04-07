using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Models
{
    public class Documento
    {
        private string nombreDoc;
        private string ruta; 
        private DateTime fecha; 

        public Documento(string nombreDoc, string ruta)
        {
            nombreDoc = nombreDoc;
            ruta = ruta;
        }


        public string NombreDoc { get; set; }
        
        public string Rruta { get; set; }

        public DateTime Fecha { get; set; }
        

    }
}