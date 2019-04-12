using ServicesGo.Controllers.BussinesLayer.ControladorasHabilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServicesGo.Controllers.BussinesLayer.ControladorasHabilidad;
using ServicesGo.Business_Layer.Controllers.ControladorasHabilidad;

namespace ServicesGo
{
    public class Main
    {

        public Main()
        {
            byte[] time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
            byte[] key = Guid.NewGuid().ToByteArray();
            string token = Convert.ToBase64String(time.Concat(key).ToArray());
            Console.WriteLine(token);
        }
       

    }
}