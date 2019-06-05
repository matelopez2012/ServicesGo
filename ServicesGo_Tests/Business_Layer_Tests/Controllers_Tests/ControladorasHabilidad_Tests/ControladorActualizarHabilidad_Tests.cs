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
            var Habilidad_Pintor = DataBaseMap.HabilidadesDefinidas.Add(new HabilidadDefinida(1, "Pintor","Persona con Habilidades y conocimientos en pintura y coloración."));
            var Habilidad_Plomero = DataBaseMap.HabilidadesDefinidas.Add(new HabilidadDefinida(2, "Plomero","Persona con conocimientos en repación de tuberias."));
            var Habilidad_Carpintero = DataBaseMap.HabilidadesDefinidas.Add(new HabilidadDefinida(3, "Carpintero", "Especialista en la fabricación y reparación de muebles sencillos."));

            // Creamos cuentas para los prestadores de servicio
            var Cuenta_Felipe = DataBaseMap.Cuentas.Add(new Cuenta(1, "felipe_calderon", "felipe123", "prestador_servicios"));
            var Cuenta_Tomas = DataBaseMap.Cuentas.Add(new Cuenta(2, "tomas_cardenas", "tomas123", "prestador_servicios"));
            var Cuenta_Juan = DataBaseMap.Cuentas.Add(new Cuenta(3, "juan_quintero97", "juan123", "prestador_servicios"));

            // Creamos algunos prestadores de servicio
            var PS_Felipe = DataBaseMap.PrestadoresServicios.Add(new PrestadorServicios(1, Cuenta_Felipe,"Felipe","Calderon","111223","felipe@ps.com"));
            var PS_Tomas = DataBaseMap.PrestadoresServicios.Add(new PrestadorServicios(2, Cuenta_Tomas,"Tomas","Cardenas","221333","tomas@ps.com"));
            var PS_Juan = DataBaseMap.PrestadoresServicios.Add(new PrestadorServicios(3, Cuenta_Juan,"Juan","Quintero","971131","juan@ps.com"));

            // Agregamos habilidades a cada uno
            PS_Felipe.Habilidades.Add(new Habilidad(1 ,Habilidad_Pintor, 55, "Pintura artesanal", PS_Felipe));
            PS_Tomas.Habilidades.Add(new Habilidad(2, Habilidad_Plomero, 85, "Fugas de agua", PS_Tomas));
            PS_Juan.Habilidades.Add(new Habilidad(3, Habilidad_Carpintero, 15, "Muebles y decoracion de madera", PS_Juan));
        }

        [TestCase(4, 1, 50, "Pintura rupestre")]
        public void Actualizar_Habilidad_NoRegistada(int idHabilidad, int idHabilidadDefinida, int experiencia, string conocimientosEspecificos)
        {
            Controladora.ActualizarHabilidad(idHabilidad, idHabilidadDefinida, experiencia, conocimientosEspecificos);
        }

        [TestCase(1, 1, 50, "Pintura rupestre")]
        public void Actualizar_Habilidad_Registada(int idHabilidad, int idHabilidadDefinida, int experiencia, string conocimientosEspecificos)
        {
            Controladora.ActualizarHabilidad(idHabilidad, idHabilidadDefinida, experiencia, conocimientosEspecificos);
        }

        [TestCase(1, 4, 55, "Reparación de herramientas y objetos metalicos.")]
        public void Actualizar_Habilidad_HabilidadDefinidaNoRegistrada(int idHabilidad, int idHabilidadDefinida, int experiencia, string conocimientosEspecificos)
        {
            Controladora.ActualizarHabilidad(idHabilidad, idHabilidadDefinida, experiencia, conocimientosEspecificos);
        }
    }
}
