using ServicesGo.Business_Layer.Models;
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
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private HomeServicesContext db = new HomeServicesContext();


        //Metodo para crear una habilidad, recibe todos los atributos de la hábilidad a crear
        
        public void crearHabilidad(int id_ps, HabilidadDefinida nombre, int experiencia, string conocimientosEpecificos)
        {
            //Añade un nuevo objeto a la tabla Habilidades
            db.Habilidades.Add(new Habilidad { habilidad_id = nombre, experiencia = experiencia, conocimientosEspecificos = conocimientosEpecificos});
            //Guardamos los cambios
            db.SaveChanges();
            //retornamos true si los cambios fueron exítosos 


        }

    }
}