using ServicesGo.Controllers.BussinesLayer.ControladorasHabilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServicesGo.Controllers.BussinesLayer.ControladorasHabilidad;
using ServicesGo.Business_Layer.Controllers.ControladorasHabilidad;

namespace ServicesGo
{
    public class Main
    {

        public Main()
        {
            ControladorActualizarHabilidad.actualizarHabiliad(1, "act", 1, "act");
          
            Console.WriteLine(34);
        }
       

    }
}