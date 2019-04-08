using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Models
{
    public class Profesion
    {
        public string nombreProfesion { get; set; }
        public int experiencia { get; set; }
        public string conocimientos { get; set; }
        public Documento certificado { get; set; }
        public Documento tarjetaProfesional { get; set; }

        public Profesion(string nombreProfesion, int experiencia, string conocimientos)
        {
            this.nombreProfesion = nombreProfesion;
            this.experiencia = experiencia;
            this.conocimientos = conocimientos;
        }
    }
}