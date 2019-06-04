using ServicesGo.Business_Layer.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasUsuario
{
    //Servicio para mostrar un determinado usuario
    public class ControladorMostrarUsuario
    {
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base
        private static HomeServicesContext db = new HomeServicesContext();


        //Constructor del servicio
        public static Usuario mostrarUsuario(int id)
        {

            //Búscamos un usuario cuyo id obtebemos por parámetro
            Usuario usuario = db.Usuarios.Find(id);

            //Sí el usuario es diferente de nulo, quiere decir que existe, y por lo tanto lo retornamos
            if (usuario != null)
            {
                return usuario;
            }
            //Sino, no existe, por lo tanto retornamos null
            else
            {
                return null;
            }
        }
    }
}