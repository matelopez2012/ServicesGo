using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Models
{
    public class Profesion
    {
        private string nombreProfesion;
        private int experiencia;
        private string conocimientos;
        private Documento certificado;
        private Documento tarjetaProfesional;

        public Profesion(string nombreProfesion, int experiencia, string conocimientos)
        {
            this.nombreProfesion = nombreProfesion;
            this.experiencia = experiencia;
            this.conocimientos = conocimientos;
        }

        /*Gets*/

        /*Sets*/

        public void setCertificado(string nombreDoc, string ruta)
        {
            
        }

        public void setTarjetaProfesional(string nombreDoc, string ruta)
        {

        }
    }
}