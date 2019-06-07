using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace ServicesGo.Business_Layer.Models
{
    [Table("PrestadoresServicios")]
    public class PrestadorServicios : Persona
    {
        [Range(0,100)]
        public int EstiloPresentacion { get; set; }

        [Range(0,100)]
        public int FormatoHV { get; set; }

        public bool PerfilModificado { get; set; }

        public DateTime FechaModificacion { get; set; }

        public ICollection<Habilidad> Habilidades { get; set; }

        public Documento Arl { get; set; }

        public Documento SeguridadSocial { get; set; }


        public PrestadorServicios(int id, Cuenta CuentaRef, string nombre, string apellidos, string cedula, string correo)
            : base (id, CuentaRef, nombre, apellidos, cedula, correo)
        {
            
        }

        public PrestadorServicios(Cuenta CuentaRef, string nombre, string apellidos, string cedula, 
            string direccion, string telefono, string correoElectronico, string foto, List<Habilidad> habilidades,
            string nombreDocArl,string rutaArl ,string nombreDocSegSocial, string rutaSegSocial , int estiloPresentacion,
            int formatoHV, bool modificado, DateTime fechaModificacion)
            : base(CuentaRef, nombre, apellidos,  cedula, direccion,  telefono,  correoElectronico, foto)
        {

            
            this.Habilidades = habilidades;
            this.EstiloPresentacion = estiloPresentacion;
            this.FormatoHV = formatoHV;
            this.PerfilModificado = modificado;
            this.FechaModificacion = fechaModificacion;

            createArl(nombreDocArl, rutaArl);
            createsocialSecurity(nombreDocSegSocial, rutaSegSocial);

        }

        public PrestadorServicios() { }

        public void createArl(string nombreDocArl, string rutaArl)
        {
            this.Arl = new Documento(nombreDocArl, rutaArl);
        }

        public void createsocialSecurity(string nombreDocSegSocial, string rutaSegSocial)
        {
            this.SeguridadSocial = new Documento(nombreDocSegSocial, rutaSegSocial);
        }
    }

}
