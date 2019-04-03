using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Models
{
    public class Documento
    {
        private string nombreDoc { get; set; }
        private string ruta { get; set; }
        private datatime fecha { get; set; }

        
        public Documento(string nombreDoc, string ruta)
        {
            nombreDoc = nombreDoc;
            ruta = ruta;
        }

    }
}