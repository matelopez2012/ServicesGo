using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasEmpleado
{


    public static class ControladorEliminarEmpleado
    {

        private static HomeServicesContext db = new HomeServicesContext();

        public static bool elimEmpleado(string cedula) {

            var query = db.Empleados.Find(cedula);
            db.Empleados.Remove(query);
            db.SaveChanges();
            return true;
}
}
}