using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasAdministrador
{
    public static class ControladorActualizarAdministrador
    {
        private static HomeServicesContext db = new HomeServicesContext();

        public static Boolean actualizarAdministrador(int id)
        {

            Administrador administrador = db.Administradores.Find(id);
            db.Administradores.Add(administrador);

            db.Entry(administrador).State = EntityState.Modified;
            db.SaveChanges();

      

            return true;
        }
        
    }
}