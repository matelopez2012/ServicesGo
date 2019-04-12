using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasAdministrador
{
    public static class ControladorMostrarAdministrador
    {

        private static HomeServicesContext db = new HomeServicesContext();



        public static Administrador mostrarAdministrador(string id)
        {

            Administrador administrador = db.Administradores.Find(id);

            if(administrador != null)
            {
                return administrador;
            }

            else
            {
                return null;
            }
        }
    }
}