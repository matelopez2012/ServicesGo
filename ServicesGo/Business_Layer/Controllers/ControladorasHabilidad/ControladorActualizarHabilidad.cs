using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasHabilidad
{
    public class ControladorActualizarHabilidad
    {
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private HomeServicesContext db = new HomeServicesContext();

        //Metodo que recibe como parametro el id del objeto, el nuevo nombre, la experiencia y los nuevos conocimientos específicos
        public Boolean actualizarHabilidad(int id, string nombre, int experiencia, string conocimientosEpecificos)
        {

            //Búscamos el objeto cuto id es el que recibimos por parametro
            Habilidad habilidad = db.Habilidades.Find(id);

            //Asignamos al objeto creado, los nuevos atributos
            habilidad.nombre = nombre;
            habilidad.experiencia = experiencia;
            habilidad.conocimientosEspecificos = conocimientosEpecificos;

            //Añadimos el nuevo objeto a la tabla habilidades
            db.Habilidades.Add(habilidad);
            db.Entry(habilidad).State = EntityState.Modified;
            //Guardamos los cambios
            db.SaveChanges();
           
            //Retornamos true para indicar que el objeto se actualizó correctamente
            return true;
        }
        
    }
}