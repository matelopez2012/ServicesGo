using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ServicesGo.Business_Layer.Controllers.ControladorasCuenta;

namespace ServicesGo_Tests.BusinessLayerTests.ControllersTests.AdministratorControllersTests
{
    class ActualizarCuentaTest
    {
        ControladorActualizarCuenta controladora = new ControladorActualizarCuenta();

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void prueba_cambiarEstado()
        {
            //Assert.AreEqual(controladora.actualizarRol("marti_nez", "cliente"), true);
            //Exception Assert.Throws(System.IO.FileNotFoundException, controladora.buscarCuenta("math_ex"));
        }
    }
}
