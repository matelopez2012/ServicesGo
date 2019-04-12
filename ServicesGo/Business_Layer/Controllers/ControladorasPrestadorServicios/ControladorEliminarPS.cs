using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasPrestadorServicios
{
    public class ControladorEliminarPS
    {

         

        private static HomeServicesContext db = new HomeServicesContext();

        public static bool elimPrestadoServicios(string cedula)
        {

            var query = db.PrestadoresServicios.Find(cedula);

            db.PrestadoresServicios.Remove(query);
            db.SaveChanges();
            return true;
        }
    }




}
