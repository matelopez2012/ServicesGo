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

        private static HomeServicesContext db = new HomeServicesContext();

        public static Persona mostrarPersona(string id)
        {
            Persona persona = db.Personas.Find(id);

            if(persona != null)
            {
                return persona;
            }

            else
            {
                return null;
            }
        }
    }
}