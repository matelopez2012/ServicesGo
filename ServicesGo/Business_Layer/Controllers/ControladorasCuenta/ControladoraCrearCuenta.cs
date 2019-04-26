using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasCuenta
{
    public class ControladoraCrearCuenta
    {
        private static HomeServicesContext db = new HomeServicesContext();

        public static Cuenta buscarCuenta(string nombreUsuario)
        {
            var query = from st in db.Cuentas
                        where st.nombreUsuario == nombreUsuario
                        select st;

            return query.FirstOrDefault();
        }

        public static bool crearCuenta(string nombreUsuario, string contrasena, string rol)
        {
            if (buscarCuenta(nombreUsuario) != null)
            {
                Cuenta cuenta = new Cuenta(nombreUsuario,contrasena,rol);

                db.Cuentas.Add(cuenta);
                db.SaveChanges();

                return true;
            }

            return false;
        }
    }
}