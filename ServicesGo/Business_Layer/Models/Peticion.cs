using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Models
{
    public class Peticion
    {
        public string nombreCuenta { get; set; }
        public string auditor { get; set; }
        public string observacion { get; set; }
        public DateTime fechaMod { get; set; }
        public bool resuelta { get; set; }

        public Peticion(string nombreCuenta, string auditor, string observacion)
        {
            this.nombreCuenta = nombreCuenta;
            this.auditor = auditor;
            this.observacion = observacion;
            this.fechaMod = DateTime.Today;
        }
    }
}