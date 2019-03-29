using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Models
{
    public class Peticion
    {
        private string nombreCuenta { get; set; }
        private string auditor { get; set; }
        private string observacion { get; set; }
        private DateTime fechaMod { get; set; }
        private bool resuelta { get; set; }

        public Peticion(string nombreCuenta, string auditor, string observacion)
        {
            this.nombreCuenta = nombreCuenta;
            this.auditor = auditor;
            this.observacion = observacion;
            this.fechaMod = DateTime.Today;
        }
    }
}