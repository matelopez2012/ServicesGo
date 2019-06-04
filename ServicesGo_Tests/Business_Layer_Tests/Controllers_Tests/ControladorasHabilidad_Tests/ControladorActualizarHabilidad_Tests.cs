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
        HomeServicesContext dataBaseMap = new HomeServicesContext();

        [SetUp]
        public void Configuracion_Previa()
        {
            // Limpiamos la base de datos
            dataBaseMap.Database.ExecuteSqlCommand("TRUNCATE TABLE Habilidades");
            dataBaseMap.Database.ExecuteSqlCommand("TRUNCATE TABLE HabilidadesDefinidas");
            dataBaseMap.Database.ExecuteSqlCommand("TRUNCATE TABLE PrestadoresServicios");
            

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
