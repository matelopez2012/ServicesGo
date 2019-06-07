using ServicesGo.Business_Layer.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasAdministrador
{
    public class ControladorActualizarAdministrador
    {
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private static HomeServicesContext db = new HomeServicesContext();

        //Metodo que actualiza la nueva información del administrador.
        //@Param : id del administrador a ser modificado.
        //@Param : nombreUsuario, nuevo nombre de usuario del administrador
        //@Param : nombre, nuevo nombre del administrador
        //@Param : apellidos, nuevos apellidos del administrador
        //@Param : cedula, nueva cedula del administrador
        //@Param : direccion, nueva direccion del administrador
        //@Param : telefono, nuevo telefono del administrador
        //@Param : correoElectronico, nuevo correo electronico del administrador
        //@Param : foto, nueva URL de la foto del administrador
        //@Return : boolean retorna verdadero si actualizo al administrador
        public Boolean actualizarAdministrador(int id, Cuenta cuentaRef, string nombre, string apellidos,
            string cedula, string direccion, string telefono, string correoElectronico, string foto)
        {
            //Obtenemos el administrador cuyo id lo pasamos por párametro
            Administrador administrador = db.Administradores.Find(id);

            //Modificamos los atributos del administrador con los parámetros que obtenemos
            administrador.CuentaRef = cuentaRef;
            administrador.Nombre = nombre;
            administrador.Apellidos = apellidos;
            administrador.Documento = cedula;
            administrador.Direccion = direccion;
            administrador.Telefono = telefono;
            administrador.Correo = correoElectronico;
            administrador.Foto = foto;

            //Añadimos el administrador con los nuevos atributos
            db.Administradores.Add(administrador);
            db.Entry(administrador).State = EntityState.Modified;

            //Guardamos los cambios
            db.SaveChanges();

            //Retornamos true para indicar que el objeto se actualizó correctamente
            return true;
        }

        //Metodo que recibe todos los nuevos atributos del administrador a modificar
        //@Param : administrador, objeto Administrador que contiene la nueva información del administrador a modificar
        //Return : retorna true si actualizó al administrador
        public Boolean modificarAdministrador(Administrador administrador)
        {
            return actualizarAdministrador(administrador.Id, administrador.CuentaRef, administrador.Nombre, 
                administrador.Apellidos, administrador.Documento, administrador.Direccion, administrador.Telefono,
                administrador.Correo, administrador.Foto);
        }
        
    }
}