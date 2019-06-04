using NUnit.Framework;
using ServicesGo.Business_Layer.Controllers.ControladorasPrestadorServicios;
using ServicesGo.Business_Layer.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesGo_Tests.Business_Layer_Tests.Controllers_Tests.ControladorasPrestadorServicios_Tests
{
    [TestFixture]
    class ControladorAprobarPS_Tests
    {
        ControladorAprobarPS controladora = new ControladorAprobarPS();
        HomeServicesContext DataBaseMap = new HomeServicesContext();

        [SetUp]
        public void Configuracion_Previa()
        {
            // Limpiamos la base de datos.
            DataBaseMap.Database.ExecuteSqlCommand("TRUNCATE TABLE Cuentas");

            // Agregamos Cuentas a aprobar.    Cuenta(string nombreUsuario, string contrasena, string rol)
            DataBaseMap.Cuentas.Add(new Cuenta("MateLopez", "abc123", "Prestador de servicio"));

        }

        [TestCase("xxxxx")]
        public void Nombre_Usuario_No_Existe(string nombreUsuario)
        {
            controladora.cambiarEstadoCuenta(nombreUsuario);
        }

        [TestCase("")]
        public void Tipo_De_Dato_Incorrecto(string nombreUsuario)
        {
            controladora.cambiarEstadoCuenta(nombreUsuario);
        }

        [TestCase("MateLopez")]
        public void Estado_De_Cuenta_Ya_Aprobado(string nombreUsuario)
        {
            controladora.cambiarEstadoCuenta(nombreUsuario);
        }

    }
}
