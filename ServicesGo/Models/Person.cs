using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Models
{
    public virtual class Persona
    {
        public virtual string nombreUsuario { get; set; }
        public virtual string nombre { get; set; }
        public virtual string apellidos { get; set; }
        public virtual string cedula { get; set; }
        public virtual string direccion { get; set; }
        public virtual string telefono { get; set; }
        public virtual string correoElectronico { get; set; }
        public virtual string foto { get; set; }



    }

}
