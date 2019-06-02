using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasPeticion
{
    public class ControladoraObtenerPeticion
    {
        private HomeServicesContext db = new HomeServicesContext();

        public Peticion verPeticion(string nombreCuenta, DateTime fecha)
        {
            Peticion peticion = db.Peticiones.SqlQuery("select nombreCuenta, fechaMod" +
                "from Peticiones " +
                "where fechaMod ="+fecha+" and nombreCuenta = "+nombreCuenta).FirstOrDefault();

            return peticion;
        }

    }
}