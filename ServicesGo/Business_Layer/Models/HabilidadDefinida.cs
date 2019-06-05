
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Models
{

    [Table("HabilidadesDefinidas")]
    public class HabilidadDefinida
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        [Timestamp]
        public Byte[] TimeStamp { get; set; }


        public HabilidadDefinida()
        {

        }

        public HabilidadDefinida(string Nombre, string Descripcion)
        {
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
        }
    }
}