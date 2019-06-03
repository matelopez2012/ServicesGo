using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ServicesGo.Business_Layer.Controllers.ControladorasHabilidad;
using ServicesGo.Business_Layer.Models;

namespace ServicesGo_Tests.Business_Layer_Tests.Controllers_Tests.ControladorasHabilidad_Tests
{
    [TestFixture]
    class ControladorActualizarHabilidad_Tests
    {
        ControladorActualizarHabilidad Controladora = new ControladorActualizarHabilidad();

        [TestCase]
        public void Actualizar_Habilidad_NoRegistada()
        {
            Controladora.ActualizarHabilidad(1, new HabilidadDefinida(), 10, "Bastantes");
        }
    }
}
