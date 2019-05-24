using ServicesGo.Models;
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
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string descripcion { get; set; }
        [Required]
        //[MaxLength(1), MinLength(5)]

        [Timestamp]
        public Byte[] TimeStamp { get; set; }



        public HabilidadDefinida()
        {

        }

        public static implicit operator HabilidadDefinida(Habilidad v)
        {
            throw new NotImplementedException();
        }
    }
}