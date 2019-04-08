using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasHabilidad
{
    public static class ControladorMostrarHabilidad
    {

        private static HomeServicesContext db = new HomeServicesContext();



        public static Habilidad mostrarHabilidad(int id)
        {

            Habilidad habilidad = db.Habilidades.Find(id);

            if(habilidad != null)
            {
                return habilidad;
            }

            else
            {
                return null;
            }
        }
    }
}