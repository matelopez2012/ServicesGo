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
        public void cambiarEstadoCuenta(string nombreUsuario)
        {
            controladora.cambiarEstadoCuenta(nombreUsuario);
        }

        [TestCase("")]
        public void cambiarEstadoCuenta(string nombreUsuario)
        {
            controladora.cambiarEstadoCuenta(nombreUsuario);
        }

        [TestCase("MateLopez")]
        public void cambiarEstadoCuenta(string nombreUsuario)
        {
            controladora.cambiarEstadoCuenta(nombreUsuario);
        }

    }
}
