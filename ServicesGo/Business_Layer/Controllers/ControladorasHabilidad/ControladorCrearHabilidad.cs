using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Controllers.BussinesLayer.ControladorasHabilidad
{
    public class ControladorCrearHabilidad
    {
        private HomeServicesContext db = new HomeServicesContext();


        //Metodo para crear una habilidad, recibe todos los atributos de la hábilidad a crear
        
        public Boolean crearHabilidad(int id_ps, string nombre, int experiencia, string conocimientosEpecificos)
        {
            //Añade un nuevo objeto a la tabla Habilidades
            db.Habilidades.Add(new Habilidad { nombre=nombre, experiencia = experiencia, conocimientosEspecificos = conocimientosEpecificos});
            //Guardamos los cambios
            db.SaveChanges();
            //retornamos true si los cambios fueron exítosos 
            return true;
        }

    }
}