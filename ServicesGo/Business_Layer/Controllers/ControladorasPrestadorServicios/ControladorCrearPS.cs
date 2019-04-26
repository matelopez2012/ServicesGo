using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasPrestadorServicios
{
    public static class ControladorCrearPS
    {
        private static HomeServicesContext db = new HomeServicesContext();

        public static void crearPrestadorServicios(string nombreUsuario, string nombre, string apellidos, string cedula,
            string direccion, string telefono, string correoElectronico, string foto, List<Habilidad> habilidades,
            string nombreDocArl, string rutaArl, string nombreDocSegSocial, string rutaSegSocial, int estiloPresentacion,
            int formatoHV, bool modificado, DateTime fechaModificacion, string clave, string rol, bool estado)
        {
            if (validarPS(cedula) && validarCuenta(nombreUsuario))
            {

                db.PrestadoresServicios.Add(new PrestadorServicios(nombreUsuario, nombre, apellidos, cedula,
            direccion, telefono, correoElectronico, foto, habilidades,
             nombreDocArl, rutaArl, nombreDocSegSocial, rutaSegSocial, estiloPresentacion,
            formatoHV, modificado, fechaModificacion));
            }

        }

        public static Boolean validarPS(string cedula)
        {
            bool salida = false;
            var bandera = db.PrestadoresServicios.Find(cedula);
            if (bandera == null)
            {
                salida = true;
            }

            return salida;
        }

        public static Boolean validarCuenta(string nombreUsuario)
        {
            bool salida = false;
            var bandera = db.Cuentas.Find(nombreUsuario);
            if (bandera == null)
            {
                salida = true;
            }

            return salida;
        }


        public static void crearCuenta(string nombreUsuario, string clave, string rol, bool estado)
        {
            db.Cuentas.Add(new Cuenta(nombreUsuario, clave, rol));
            db.SaveChanges();
        }

    }
 
}