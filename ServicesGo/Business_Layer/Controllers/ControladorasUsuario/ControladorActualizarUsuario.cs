using ServicesGo.Business_Layer.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasUsuario
{
    //Servicio para actualizar usuario
    public class ControladorActualizarUsuario
    {

        //Creamos la instancia de HomeServicesContext que permitirá mapear la base
        private static HomeServicesContext db = new HomeServicesContext();

        //Constructor para el servicio
        //Recibe como parametro los diferentes atributos de la hábilidad que se desean actualizar
        public static Boolean actualizarUsuario(int id, Cuenta cuentaRef, string nombre, string apellidos, 
            string cedula, string direccion, string telefono, string correoElectronico, string foto)
        {

            //Obtenemos el usuario cuyo id la pasamos por párametro
            Usuario usuario = db.Usuarios.Find(id);

            //Modificamos los atributos el usuario con los parámetros que obtenemos
            usuario.CuentaRef = cuentaRef;
            usuario.nombre = nombre;
            usuario.apellidos = apellidos;
            usuario.cedula = cedula;
            usuario.direccion = direccion;
            usuario.telefono = telefono;
            usuario.correoElectronico = correoElectronico;
            usuario.foto = foto;

            //Añadimos el usuario con los nuevos atributos
            db.Usuarios.Add(usuario);
            db.Entry(usuario).State = EntityState.Modified;
            
            //Guardamos los cambios
            db.SaveChanges();



            return true;
        }
    }
}