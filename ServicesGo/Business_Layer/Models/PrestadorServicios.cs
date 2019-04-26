
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace ServicesGo.Models
{
    [Table("PrestadoresServicios")]
    public class PrestadorServicios : Persona

    {

       

        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(30)]
        public string cedula { get; set; }

        [Required]
        public int estiloPresentacion { get; set; }

        [Required]
        public int formatoHV { get; set; }

        [Required]
        public bool modificado { get; set; }


        public DateTime fechaModificacion { get; set; }

        public ICollection<Habilidad> habilidades { get; set; }

        public Documento arl { get; set; }

        public Documento socialSecurity { get; set; }

        public PrestadorServicios(string nombreUsuario, string nombre, string apellidos, string cedula, 
            string direccion, string telefono, string correoElectronico, string foto, List<Habilidad> habilidades,
            string nombreDocArl,string rutaArl ,string nombreDocSegSocial, string rutaSegSocial , int estiloPresentacion,
            int formatoHV, bool modificado, DateTime fechaModificacion)
            : base(nombreUsuario, nombre, apellidos,  cedula, direccion,  telefono,  correoElectronico, foto)
        {

            
            this.habilidades = habilidades;
            this.estiloPresentacion = estiloPresentacion;
            this.formatoHV = formatoHV;
            this.modificado = modificado;
            this.fechaModificacion = fechaModificacion;

            createArl(nombreDocArl, rutaArl);
            createsocialSecurity(nombreDocSegSocial, rutaSegSocial);

        }

        public PrestadorServicios()
        {

        }

        public void createArl(string nombreDocArl, string rutaArl) {
            this.arl = new Documento(nombreDocArl, rutaArl);
        }

        public void createsocialSecurity(string nombreDocSegSocial, string rutaSegSocial) {
            this.socialSecurity = new Documento(nombreDocSegSocial, rutaSegSocial);

        }


     
    }

}
