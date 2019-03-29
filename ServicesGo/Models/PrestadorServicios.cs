
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ServicesGo.Models
{
    public class PrestadorServicios : Persona

    {

        private int estiloPresentacion { get; set; }
        private int formatoHV { get; set; }
        private bool modificado { get; set; }
        private DateTime fechaModificacion { get; set; }
        private List<Habilidad> habilidades { get; set; }
        private Documento arl { get; set; }
        private Documento socialSecurity { get; set; }

        public PrestadorServicios(string nombreUsuario, string nombre, string apellidos, string cedula, 
            string direccion, string telefono, string correoElectronico, string foto, List<Habilidad> habilidades,
            string nombreDocArl,string rutaArl ,string nombreDocSegSocial, string rutaSegSocial , int estiloPresentacion,
            int formatoHV, bool modificado, DateTime fechaModificacion)
            : base(nombreUsuario, nombre, apellidos,  cedula, direccion,  telefono,  correoElectronico,  foto)

        {
            
            this.habilidades = habilidades;
            this.estiloPresentacion = estiloPresentacion;
            this.formatoHV = formatoHV;
            this.modificado = modificado;
            this.fechaModificacion = fechaModificacion;

            createArl(nombreDocArl, rutaArl);
            createsocialSecurity(nombreDocSegSocial, rutaSegSocial);

        }


        public void createArl(string nombreDocArl, string rutaArl) {
            this.arl = new Documento(nombreDocArl, rutaArl);
        }

        public void createsocialSecurity(string nombreDocSegSocial, string rutaSegSocial) {
            this.socialSecurity = new Documento(nombreDocSegSocial, rutaSegSocial);

        }


        
       
        


    }

}
