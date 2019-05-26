using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasAdministrator
{
    public class ControladorMostrarAdministradores
    {
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private static HomeServicesContext db = new HomeServicesContext();

        //Método que devuelve todos los administradores en la tabla administradores
        //@Return : Lista, retorna la lista de administradores
        public List<Administrador> mostrarAdministradores()
        {
            //Se  buscan todos los administradores
            List<Administrador> administradores = db.Administrador.ToList();

            //Si la lista de administradores es diferente de nulo, retornamos la lista
            if (administradores != null)
            {
                return administradores;
            }
            //En caso contrario retornamos nulo
            else
            {
                return null;
            }

        }
    }
}