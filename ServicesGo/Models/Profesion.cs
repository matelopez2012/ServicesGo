using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Models
{
    public class Profesion
    {
        private string nombreProfesion { get; set; }
        private int experiencia { get; set; }
        private string conocimientos { get; set; }
        private Documento certificado { get; set; }
        private Documento tarjetaProfesional { get; set; }

        public Profesion(string nombreProfesion, int experiencia, string conocimientos)
        {
            this.nombreProfesion = nombreProfesion;
            this.experiencia = experiencia;
            this.conocimientos = conocimientos;
        }
    }
}