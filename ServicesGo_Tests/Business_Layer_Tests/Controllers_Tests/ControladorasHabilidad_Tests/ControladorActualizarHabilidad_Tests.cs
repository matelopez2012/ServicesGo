using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ServicesGo.Business_Layer.Controllers.ControladorasHabilidad;
using ServicesGo.Business_Layer.Models;
using ServicesGo.Persistence_Layer;

namespace ServicesGo_Tests.Business_Layer_Tests.Controllers_Tests.ControladorasHabilidad_Tests
{
    [TestFixture]
    class ControladorActualizarHabilidad_Tests
    {
        ControladorActualizarHabilidad Controladora = new ControladorActualizarHabilidad();
        HomeServicesContext DataBaseMap = new HomeServicesContext();

        [SetUp]
        public void Configuracion_Previa()
        {
            // Limpiamos la base de datos
            DataBaseMap.Database.ExecuteSqlCommand("TRUNCATE TABLE Habilidades");
            DataBaseMap.Database.ExecuteSqlCommand("TRUNCATE TABLE HabilidadesDefinidas");
            DataBaseMap.Database.ExecuteSqlCommand("TRUNCATE TABLE PrestadoresServicios");

            // Agregamos habilidades definidas
            DataBaseMap.HabilidadesDefinidas.Add(new HabilidadDefinida("Pintor","Persona con habilidades y conocimientos en pintura y coloración."));
            DataBaseMap.HabilidadesDefinidas.Add(new HabilidadDefinida("Plomero","Persona con conocimientos en repación de tuberias."));
            DataBaseMap.HabilidadesDefinidas.Add(new HabilidadDefinida("Carpintero", "Especialista en la fabricación y reparación de muebles sencillos."));

            // Creamos algunos prestadores de servicio
            //DataBaseMap.PrestadoresServicios.Add();
        }

        [TestCase(7, 1, 50, "Muchisímos")]
        public void Actualizar_Habilidad_NoRegistada(int idHabilidad, int idHabilidadDefinida, int experiencia, string conocimientosEspecificos)
        {
            Controladora.ActualizarHabilidad(idHabilidad,idHabilidadDefinida,experiencia,conocimientosEspecificos);
        }

        [TestCase(1, 1, 50, "Muchisímos")]
        public void Actualizar_Habilidad_Registada(int idHabilidad, int idHabilidadDefinida, int experiencia, string conocimientosEspecificos)
        {
            Controladora.ActualizarHabilidad(idHabilidad, idHabilidadDefinida, experiencia, conocimientosEspecificos);
        }

        [TestCase(1, 12, 50, "Muchisímos")]
        public void Actualizar_Habilidad_HabilidadDefinidaNoRegistrada(int idHabilidad, int idHabilidadDefinida, int experiencia, string conocimientosEspecificos)
        {
            Controladora.ActualizarHabilidad(idHabilidad, idHabilidadDefinida, experiencia, conocimientosEspecificos);
        }
    }
}
