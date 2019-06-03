using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasAdministrador
{
    public class ControladorMostrarAdministrador
    {
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private static HomeServicesContext db = new HomeServicesContext();

        //Método para mostrar el administrador cuyo id obtenemos por párametro
        public Administrador mostrarAdministrador(string id)
        {
            //Obtenemos el administrador que tiene el id que obtenemos por párametro
            Administrador administrador = (Administrador)db.Administradores.Find(id);

            //Si el administrador que obtuvimos es diferente de nula, ó sea, si existe, la retornamos
            if (administrador != null)
            {
                return administrador;
            }
            //En caso contrario, ó sea, no existe, retornamos nulo
            else
            {
                return null;
            }
        }
    }
}