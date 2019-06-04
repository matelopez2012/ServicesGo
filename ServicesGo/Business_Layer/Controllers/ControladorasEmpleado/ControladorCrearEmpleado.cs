using ServicesGo.Business_Layer.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasEmpleado
{
    public  class ControladorCrearEmpleado
    {
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private HomeServicesContext db = new HomeServicesContext();

        //Metodo para crear un Empleado, recibe todos los atributos de el empleado a crear
        //El metodo llama los metodos que verifican que no exista una cuenta de usuario o empleado con los datos brindados
        //y crea tanto la cuneta de usuario como el empleado
        public  void crearEmpleado(string nombreUsuario , string nombre, string apellidos, string cedula, 
            string direccion, string telefono, string correoElectrónico, string foto,string clave, string rol, bool estado)
        {
            if (validarEmpleado(cedula) && validarCuenta(nombreUsuario)) {

                crearCuenta( nombreUsuario,  clave,  rol,  estado);
                db.Empleados.Add(new Empleado(nombreUsuario,nombre, apellidos,  cedula,  direccion,  telefono,  correoElectrónico,  foto));
                db.SaveChanges();
            }


        }

        //Metodo para valiar que no exista un empleado registrada bajo el valor recibida en el parametro "cedula"
        public  Boolean validarEmpleado(string cedula)
        {
            bool salida = false;
            var bandera = db.Empleados.Find(cedula);
            if (bandera == null) {
                salida = true;
            }

            return salida;
        }

        //Metodo para valiar que no exista una cuenta registrada bajo el valor recibida en el parametro "nombreUsuario"
        public Boolean validarCuenta(string nombreUsuario)
        {
            bool salida = false;
            var bandera = db.Cuentas.Find(nombreUsuario);
            if (bandera == null)
            {
                salida = true;
            }

            return salida;
        }

        //Metodo para crear una Cuenta, recibe todos los atributos de la Cuenta a crear
        public void crearCuenta(string nombreUsuario,string clave,string rol,bool estado) {
            db.Cuentas.Add(new Cuenta(nombreUsuario, clave, rol));
            db.SaveChanges();
        }
           

    }
}