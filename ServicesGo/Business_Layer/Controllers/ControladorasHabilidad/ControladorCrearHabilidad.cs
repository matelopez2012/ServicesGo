﻿using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Controllers.BussinesLayer.ControladorasHabilidad
{
    public static class ControladorCrearHabilidad
    {
        private static HomeServicesContext db = new HomeServicesContext();
    

        public static Boolean crearHabilidad(string nombre, int experiencia, string conocimientosEpecificos)
        {
            
            db.Habilidades.Add(new Habilidad { nombre=nombre, experiencia = experiencia, conocimientosEspecificos = conocimientosEpecificos});
            db.SaveChanges();

            return true;
        }

    }
}