using ServicesGo.Business_Layer.Models;
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
        public void ActualizarHabilidad(int idHabilidad, int idHabilidadDefinida, int experiencia, string conocimientosEpecificos)
        {
            //Búscamos el objeto cuyo id es el que recibimos por parametro
            var habilidad = db.Habilidades.Find(idHabilidad);
            var habilidadDefinida = db.HabilidadesDefinidas.Find(idHabilidadDefinida);

            //Asignamos al objeto creado, los nuevos atributos
            habilidad.HabilidadDefinidaRef = habilidadDefinida;
            habilidad.Experiencia = experiencia;
            habilidad.ConocimientosEspecificos = conocimientosEpecificos;

            //Añadimos el nuevo objeto a la tabla habilidades
            db.Habilidades.Add(habilidad);
            db.Entry(habilidad).State = EntityState.Modified;
            //Guardamos los cambios
            db.SaveChanges();
        }
        
    }
}