using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasPersona
{
    public class ControladorMostrarPersonas
    {
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private static HomeServicesContext db = new HomeServicesContext();

        //Método que devuelve todos las personas en la tabla personas
        //@Return : Lista, retorna la lista de personas
        public List<Persona> mostrarPersonas()
        {
            //Se  buscan todas las personas
            List<Persona> personas = db.Personas.ToList();

            //Si la lista de personas es diferente de nulo, retornamos la lista
            if (personas != null)
            {
                return personas;
            }
            //En caso contrario retornamos nulo
            else
            {
                return null;
            }

        }
    }
}