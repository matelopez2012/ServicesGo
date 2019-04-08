using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasUsuario
{
    public class ControladorMostrarUsuario
    {

        private static HomeServicesContext db = new HomeServicesContext();



        public static Usuario mostrarUsuario(int id)
        {

            Usuario usuario = db.Usuarios.Find(id);

            if (usuario != null)
            {
                return usuario;
            }

            else
            {
                return null;
            }
        }
    }
}