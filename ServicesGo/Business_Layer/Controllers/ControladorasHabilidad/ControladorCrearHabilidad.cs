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
        private HomeServicesContext dataBaseMap = new HomeServicesContext();

        //Metodo para crear una habilidad, recibe todos los atributos de la hábilidad a crear
        public void CrearHabilidad(int idHabilidadDefinida, int experiencia, string conocimientosEpecificos, int idPrestadorServicio)
        {
            var habilidadDefinida = dataBaseMap.HabilidadesDefinidas.Find(idHabilidadDefinida);
            var prestadorServicio = dataBaseMap.PrestadoresServicios.Find(idPrestadorServicio);

            //Añade un nuevo objeto a la tabla Habilidades
            dataBaseMap.Habilidades.Add(new Habilidad(habilidadDefinida,experiencia,conocimientosEpecificos,prestadorServicio));
            //Guardamos los cambios
            dataBaseMap.SaveChanges();
            //retornamos true si los cambios fueron exítosos
        }

    }
}