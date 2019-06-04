using ServicesGo.Business_Layer.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasHabilidad
{
    public class ControladorCrearHabilidad
    {
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private HomeServicesContext DataBaseMap = new HomeServicesContext();

        //Metodo para crear una habilidad, recibe todos los atributos de la hábilidad a crear
        public void CrearHabilidad(int idHabilidadDefinida, int experiencia, string conocimientosEpecificos, int idPrestadorServicio)
        {
            var habilidadDefinida = DataBaseMap.HabilidadesDefinidas.Find(idHabilidadDefinida);
            var prestadorServicio = DataBaseMap.PrestadoresServicios.Find(idPrestadorServicio);

            //Añade un nuevo objeto a la tabla Habilidades
            DataBaseMap.Habilidades.Add(new Habilidad(habilidadDefinida,experiencia,conocimientosEpecificos,prestadorServicio));
            //Guardamos los cambios
            DataBaseMap.SaveChanges();
            //retornamos true si los cambios fueron exítosos
        }

    }
}