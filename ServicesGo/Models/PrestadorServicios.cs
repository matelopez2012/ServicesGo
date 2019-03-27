
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ServicesGo.Models
{
    public class PrestadorServicios : Person

    {
        public PrestadorServicios(string nombreUsuario, string nombre, string apellidos, string cedula, 
            string direccion, string telefono, string correoElectronico, string foto, List<Habilidad> habilidades,
            string nombreDocArl,string rutaArl ,string nombreDocSegSocial, string rutaSegSocial , int estiloPresentacion,
            int formatoHV, bool modificado, DateTime fechaModificacion)
        {
            this.nombreUsuario = nombreUsuario;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.cedula = cedula;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correoElectronico = correoElectronico;
            this.foto = foto;
            this.Habilities = habilidades;
            this.estiloPresentacion = estiloPresentacion;
            this.formatoHV = formatoHV;
            this.modificado = modificado;
            this.fechaModificacion = fechaModificacion;

            createArl(nombreDocArl, rutaArl);
            socialSecurity(nombreDocSegSocial, rutaSegSocial);

        }


        public createArl(string nombreDocArl, string rutaArl) {
            this.arl = new Document(nombreDocArl, rutaArl);
        }

        public socialSecurity(string nombreDocSegSocial, string rutaSegSocial) {
            this.socialSecurity = new Document(nombreDocSegSocial, rutaSegSocial);

        }


        private int estiloPresentacion { get; set; }
        private int formatoHV { get; set; }
        private bool modificado { get; set; }
        private DateTime fechaModificacion { get; set; }
        private override string nombreUsuario { get; set; }
        private override string nombre { get; set; }
        private override string apellidos { get; set; }
        private override string cedula { get; set; }
        private override string direccion { get; set; }
        private override string telefono { get; set; }
        private override string correoElectronico { get; set; }
        private override string foto { get; set; }
        private List<Habilities> Habilities { get; set; }
        private Document arl { get; set; }
        private Document socialSecurity{ get; set; }


    }

}
