using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasPersona
{
    public static class ControladorMostrarPersona
    {
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private static HomeServicesContext db = new HomeServicesContext();

        //Método para mostrar la persona cuyo id obtenemos por párametro
        public Persona mostrarPersona(string id)
        {
            //Obtenemos la persona que tiene el id que obtenemos por párametro
            Persona persona = db.Personas.Find(id);

            //Si la persona que obtuvimos es diferente de nula, ó sea, si existe, la retornamos
            if (persona != null)
            {
                return persona;
            }
            //En caso contrario, ó sea, no existe, retornamos nulo
            else
            {
                return null;
            }
        }
    }
}