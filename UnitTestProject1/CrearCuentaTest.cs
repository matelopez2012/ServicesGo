using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServicesGo.Business_Layer.Controllers.ControladorasCuenta;
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

            //db.Cuentas.Add();

            ControladoraCrearCuenta.buscarCuenta("");
        }
    }
}
