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


        public static List<Cuenta> consultarCuentasSinAprobar() {

            var cuentasSinAprobar = from a in db.Cuentas
                                    where a.aprobada == false && a.rol == "PrestadorServicios"
                                    select a;

            return (List <Cuenta>) cuentasSinAprobar;

        }

        public static int numeroCuentasSinAprobar()
        {

            var cuentasSinAprobar = from a in db.Cuentas
                                    where a.aprobada == false && a.rol == "PrestadorServicios"
                                    select a;

            return cuentasSinAprobar.Count<Cuenta>();

        }

        public static void cambiarEstadoCuenta(string nombreUsuario) {

             

            var c = from a in db.Cuentas
                       where a.nombreUsuario == nombreUsuario 
                       select a;

            Cuenta cuenta = c.FirstOrDefault();

            db.Cuentas.Add(cuenta);

            db.Entry(cuenta).State = EntityState.Modified;
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