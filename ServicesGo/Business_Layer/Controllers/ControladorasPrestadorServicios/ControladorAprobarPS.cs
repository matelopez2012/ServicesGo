using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasPrestadorServicios
{
    public  class ControladorAprobarPS
    {
        private  HomeServicesContext db = new HomeServicesContext();


        //Metodo que busca y retorna las cuentas de PS que estan sin aprobar, en una lista de Cuentas
        public List<Cuenta> consultarCuentasSinAprobar() {
            var cuentasSinAprobar = from a in db.Cuentas
                      where a.EstaAprobada == false && a.Rol == "PrestadorServicios"
                   select a;
            return (List<Cuenta>) cuentasSinAprobar;

        }

        //Metodo que retorna la cantidad de cuentas de PS que estan sin aprobar
        public  int numeroCuentasSinAprobar() {
            var cuentasSinAprobar = from a in db.Cuentas
                                    where a.EstaAprobada == false && a.Rol == "PrestadorServicios"
                                    select a;

            return cuentasSinAprobar.ToList().Count();
           
        }


        //Metodo que cambia el estado de lacuenta registrada bajo el valor recibido por el parametro "nombreUsuario"
        public  void cambiarEstadoCuenta(string nombreUsuario) {

            var c = from a in db.Cuentas
                       where a.NombreUsuario == nombreUsuario 
                       select a;

            Cuenta cuenta = c.FirstOrDefault();
            //cuenta.aprobado = true;
            db.Cuentas.Add(cuenta);
            db.Entry(c).State = EntityState.Modified;
            db.SaveChanges();


        }


        //Metodo que busca en la base de datos en registro de el PS registrada bajo el valor recibido en el parametro "cedula" 
        //y lo retorna como un objeto de tipo PredtadorServicios
        public PrestadorServicios buscarPrestadorServicios(string cedula) {
            PrestadorServicios ps = db.PrestadoresServicios.Find(cedula);
            return ps;

        }


        //Metodo que busca en la base de datos en registro de la cuenta registrada bajo el valor recibido en el parametro "nombreUsuario" 
        //y lo retorna como un objeto de tipo cuenta
        public  Cuenta buscarCuentaSinAprobar(string nombreUsuario) {
            Cuenta c = db.Cuentas.Find(nombreUsuario);
            return c;

        }



    }
}