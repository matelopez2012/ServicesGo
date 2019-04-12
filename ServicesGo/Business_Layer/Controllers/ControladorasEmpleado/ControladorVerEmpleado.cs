using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasEmpleado
{
    public static class ControladorVerEmpleado
    {
        private static HomeServicesContext db = new HomeServicesContext();


        public static Empleado mostrarEmpleado(string cedula)
        {   
            return buscarEmpleado(cedula);
        }

        public static Empleado buscarEmpleado(string cedula)
        {
            return db.Empleados.Find(cedula);
        }

    }
}