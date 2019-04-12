using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasEmpleado
{
    public static class ControladorCrearEmpleado
    {
        private static HomeServicesContext db = new HomeServicesContext();
      
        public static void crearEmpleado(string nombreUsuario , string nombre, string apellidos, string cedula, 
            string direccion, string telefono, string correoElectrónico, string foto,string clave, string rol, bool estado)
        {
            if (validarEmpleado(cedula) && validarCuenta(nombreUsuario)) {

                crearCuenta( nombreUsuario,  clave,  rol,  estado);
                db.Empleados.Add(new Empleado(nombreUsuario,nombre, apellidos,  cedula,  direccion,  telefono,  correoElectrónico,  foto));
                db.SaveChanges();
            }


        }

        public static Boolean validarEmpleado(string cedula)
        {
            bool salida = false;
            var bandera = db.Empleados.Find(cedula);
            if (bandera == null) {
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


        public static void crearCuenta(string nombreUsuario,string clave,string rol,bool estado) {
            db.Cuentas.Add(new Cuenta(nombreUsuario, clave, rol, estado));
            db.SaveChanges();
        }
           

    }
}