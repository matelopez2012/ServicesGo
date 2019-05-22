using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasHabilidad
{
    public class ControladorMostrarHabilidad
    {
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private static HomeServicesContext db = new HomeServicesContext();

        //Método para mostrar la habilidad cuyo id obtenemos por párametro
        public static Habilidad mostrarHabilidad(int id)
        {
            //Obtenemos la hábilidad que tiene el id que obtenemos por párametro
            Habilidad habilidad = db.Habilidades.Find(id);

            //Si la habilidad que obtuvimos es diferente de nula, ó sea, si existe, la retornamos
            if(habilidad != null)
            {
                return habilidad;
            }
            //En caso contrario, ó sea, no existe, retornamos nulo
            else
            {
                return null;
            }
        }
    }
}