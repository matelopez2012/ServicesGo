using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasCuenta
{
    public class ControladoraValidarInicioSesion
    {
        private static HomeServicesContext db = new HomeServicesContext();

        public static Cuenta buscarCuenta(string nombreUsuario)
        {
            var query = from st in db.Cuentas
                        where st.nombreUsuario == nombreUsuario
                        select st;

            return query.FirstOrDefault();
        }

        public static bool validarSesion(string nombreCuenta, string contrasena)
        {
            Cuenta cuenta = buscarCuenta(nombreCuenta);

            if (cuenta == null)
            {
                return false;
            }

            if(cuenta.contrasena != contrasena)
            {
                return false;
            }

            return true;
        }
    }
}