using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasPeticion
{
    public class ControladorObtenerPeticiones
    {
        private static HomeServicesContext db = new HomeServicesContext();

        public static ICollection<Peticion> verPeticion()
        {
            ICollection<Peticion> peticion = db.Peticiones.ToList();

            return peticion;
        }
    }
}