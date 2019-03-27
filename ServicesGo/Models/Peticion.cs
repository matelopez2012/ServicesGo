using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Models
{
    public class Peticion
    {
        private string nombreCuenta;
        private string auditor;
        private string observacion;
        private DateTime fechaMod;
        private bool resuelta;

        public Peticion(string nombreCuenta, string auditor, string observacion)
        {
            this.nombreCuenta = nombreCuenta;
            this.auditor = auditor;
            this.observacion = observacion;
            this.fechaMod = DateTime.Today;
        }

        /*Gets*/

        public DateTime getFechaMod()
        {
            return this.fechaMod;
        }

        /*Sets*/

        public void setResuelta(bool resuelta)
        {
            this.resuelta = resuelta;
        }
    }
}