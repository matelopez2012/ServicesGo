using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasPrestadorServicios
{
    public  class ControladorCrearPS
    {
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private  HomeServicesContext db = new HomeServicesContext();

        //Metodo para crear un PS, recibe todos los atributos de el PS a crear
        //El metodo llama los metodos que verifican que no exista una cuenta de usuario o PS con los datos brindados
        //y crea tanto la cuneta de usuario como el PS
        public  void crearPrestadorServicios(string nombreUsuario, string nombre, string apellidos, string cedula,
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

        //Metodo para valiar que no exista un PS registrada bajo el valor recibida en el parametro "cedula"
        public  Boolean validarPS(string cedula)
        {
            bool salida = false;
            var bandera = db.PrestadoresServicios.Find(cedula);
            if (bandera == null)
            {
                salida = true;
            }

            return salida;
        }

        //Metodo para valiar que no exista una cuenta registrada bajo el valor recibida en el parametro "nombreUsuario"
        public  Boolean validarCuenta(string nombreUsuario)
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
        public  void crearCuenta(string nombreUsuario, string clave, string rol, bool estado)
        {
            db.Cuentas.Add(new Cuenta(nombreUsuario, clave, rol));
            db.SaveChanges();
        }

    }
 
}