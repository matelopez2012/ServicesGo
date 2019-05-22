using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasHabilidad
{
    public static class ControladorActualizarHabilidad
    {
        private static HomeServicesContext db = new HomeServicesContext();

        public static Boolean actualizarHabilidad(int id, string nombre, int experiencia, string conocimientosEpecificos)
        {

            Habilidad habilidad = db.Habilidades.Find(id);
            habilidad.nombre = nombre;
            habilidad.experiencia = experiencia;
            habilidad.conocimientosEspecificos = conocimientosEpecificos;
            db.Habilidades.Add(habilidad);

            db.Entry(habilidad).State = EntityState.Modified;
            db.SaveChanges();

      

            return true;
        }
        
    }
}