using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasPeticion
{
    public class ControladoraVerPeticion
    {
        private static HomeServicesContext db = new HomeServicesContext();

        public static Cuenta buscarCuenta(string nombreUsuario)
        {
            Cuenta cuenta = db.Cuentas.Find(nombreUsuario);
            return cuenta;
        }

        public static Peticion verPeticion(string nombreCuenta, DateTime fecha)
        {
            Cuenta cuenta = buscarCuenta(nombreCuenta);
            var query = from st in db.Peticiones
                        where st.fechaMod == fecha
                        select st;
            Peticion peticion = query.FirstOrDefault();

            return peticion;
        }

    }
}