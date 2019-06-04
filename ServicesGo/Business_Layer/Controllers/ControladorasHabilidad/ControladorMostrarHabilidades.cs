using ServicesGo.Business_Layer.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasHabilidad
{
    public class ControladorMostrarHabilidades
    {
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private static HomeServicesContext db = new HomeServicesContext();

        //Método que retorna una lista con todas las habilidades en la tabla habilidades
        public List<Habilidad> mostrarHabilidades()
        {
            //Se  buscan todas las habilidades
            List<Habilidad> habilidades = db.Habilidades.ToList();

            //Si la lista de habilidades es diferente de nulo, retornamos la lista
            if (habilidades != null)
            {
                return habilidades;
            }
            //En caso contrario retornamos nulo
            else
            {
                return null;
            }

        }
    }
}