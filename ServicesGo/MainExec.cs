using ServicesGo.Controllers.BussinesLayer.ControladorasHabilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServicesGo.Business_Layer.Controllers.ControladorasCuenta;

namespace ServicesGo
{
    public class MainExec
    {

        static void Main()
        {
            ControladoraCrearCuenta.crearCuenta("juanse_duque", "random", "usuario");
            Console.WriteLine(ControladoraValidarInicioSesion.validarSesion("juanse_duque","random"));
        }
       

    }
}