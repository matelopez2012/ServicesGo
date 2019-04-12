using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasPrestadorServicios
{
    public static class ControladorAprobarPS
    {
        private static HomeServicesContext db = new HomeServicesContext();


        public static List<PrestadorServicios> consultarCuentasSinAprobar() {

            var cuentasSinAprobar = from a in db.Cuentas
                                    where a.aprobada = "false" && a.rol = "PrestadorServicios"
                                    select a;

            return cuentasSinAprobar;

        }

        public static int numeroCuentasSinAprobar() {

            var cuentasSinAprobar = from a in db.Cuentas
                                    where a.aprobada = "false" && a.rol="PrestadorServicios"
                                    select a;

            return cuentasSinAprobar.length;

        }

        public static void cambiarEstadoCuenta(string nombreUsuario) {

             

            Cuenta c = from a in db.Cuentas
                       where a.nombreUsuario = nombreUsuario 
                       select a;

            c.aprobada = "true";

            db.Cuentas.Add(c);

            db.Entry(c).State = EntityState.Modified;
            db.SaveChanges();


        }

        public static PrestadorServicios buscarPrestadorServicios(string cedula) {

            PrestadorServicios ps = db.PrestadoresServicios.Find(cedula);

            return ps;

        }


        public static Cuenta buscarCuentaSinAprobar(string nombreUsuario) {


            Cuenta c = db.Cuentas.Find(nombreUsuario);

            return c;

        }



    }
}