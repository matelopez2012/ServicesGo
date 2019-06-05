using ServicesGo.Business_Layer.Models;
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
        private HomeServicesContext DataBaseMap = new HomeServicesContext();

        //Metodo que recibe como parametro el id del objeto, el nuevo nombre, la experiencia y los nuevos conocimientos específicos
        public void ActualizarHabilidad(Habilidad habilidad, HabilidadDefinida habilidadDefinida, int experiencia, string conocimientosEpecificos)
        {
            var habilidadActualizar = DataBaseMap.Habilidades.Find(habilidad.Id);
            habilidadActualizar.HabilidadDefinidaRef = habilidadDefinida;
            habilidadActualizar.Experiencia = experiencia;
            habilidadActualizar.ConocimientosEspecificos = conocimientosEpecificos;

            //Añadimos el nuevo objeto a la tabla habilidades
            DataBaseMap.Habilidades.Add(habilidadActualizar);
            DataBaseMap.Entry(habilidadActualizar).State = EntityState.Modified;
            //Guardamos los cambios
            DataBaseMap.SaveChanges();
        }
        
    }
}