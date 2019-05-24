using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasUsuario
{
    //Servicios para mostrar los usuarios
    public class ControladorMostrarUsuarios
    {

        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private static HomeServicesContext db = new HomeServicesContext();

        //Método que retorna una lista con todos los usuarios en la tabla Usuarios
        public List<Usuario> mostrarUsuarios()
        {
            //Se  buscan todas los usuarios
            List<Usuario> usuarios = db.Usuarios.ToList();

            //Si la lista de usuarios es diferente de nulo, retornamos la lista
            if (usuarios != null)
            {
                return usuarios;
            }
            //En caso contrario retornamos nulo
            else
            {
                return null;
            }

        }
    }
}