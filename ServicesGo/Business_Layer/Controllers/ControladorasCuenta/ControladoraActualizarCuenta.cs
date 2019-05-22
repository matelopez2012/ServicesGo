using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasCuenta
{
    public class ControladoraActualizarCuenta
    {
        private static HomeServicesContext db = new HomeServicesContext();

        public static Cuenta buscarCuenta(string nombreUsuario)
        {
            var query = from st in db.Cuentas
                        where st.nombreUsuario == nombreUsuario
                        select st;

            return query.FirstOrDefault();
        }

        public static bool actualizarRol(string nombreUsuario, string rol)
        {
            if (buscarCuenta(nombreUsuario) != null)
            {
                var query = from st in db.Cuentas
                            where st.nombreUsuario == nombreUsuario
                            select st;

                query.FirstOrDefault().rol = rol;
                db.SaveChanges();

                return true;
            }

            return false;
        }
    }
}