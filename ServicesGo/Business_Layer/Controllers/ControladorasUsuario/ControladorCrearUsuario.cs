using ServicesGo.Business_Layer.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasUsuario
{
    //Servicios para crear un usuario
    public static class ControladorCrearUsuario
    {

        //Creamos la instancia de HomeServicesContext que permitirá mapear la base
        private static HomeServicesContext db = new HomeServicesContext();

        //Constructor para el servicio
        //Recibimos por parámetro los atributos del usuario a crear
        public static Boolean crearUsuario(string nombreUsuario, string nombre, string apellidos, string cedula, string direccion,
            string telefono, string correoElectronico, string foto)
        {
            //Creamos un nuevo usuario
            Usuario usuario = new Usuario(nombreUsuario, nombre, apellidos, cedula, direccion, telefono, correoElectronico, foto);

            //Añadimos el usuario creado
            db.Usuarios.Add(usuario);
            //guardamos los cambios 
            db.SaveChanges();

            //Retornamos verdadero si el proceso se realizó de manera éxitosa
            return true;
        }
    }
}