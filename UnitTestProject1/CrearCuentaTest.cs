using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServicesGo.Business_Layer.Controllers.ControladorasCuenta;
using ServicesGo.Models;
using ServicesGo.Persistence_Layer;

namespace CrearCuentaTest
{
    [TestClass]
    public class CrearCuentaTest
    {
        private static HomeServicesContext db = new HomeServicesContext();

        [TestMethod]
        public void buscarCuentaExistente()
        {
            bool esperado = true;

            db.Cuentas.Add(new Cuenta("mateo_lopez", "mateo123", "Empleado"));

            Cuenta prueba = ControladoraCrearCuenta.buscarCuenta("mateo_lopez");

            bool real = true;

            if(prueba == null)
            {
                real = false;
            }

            Assert.AreEqual(esperado, real);

        }
    }
}
