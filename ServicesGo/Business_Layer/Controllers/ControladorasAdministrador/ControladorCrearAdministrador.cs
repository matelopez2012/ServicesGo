using ServicesGo.Business_Layer.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasAdministrador
{
    public class ControladorCrearAdministrador
    {
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private static HomeServicesContext db = new HomeServicesContext();

        //Metodo para crear un administrador
        //@Param : id del administrador
        //@Param : nombreUsuario, nombre de usuario del administrador
        //@Param : nombre, nombre del administrador
        //@Param : apellidos, apellidos del administrador
        //@Param : cedula, cedula del administrador
        //@Param : direccion, direccion del administrador
        //@Param : telefono, telefono del administrador
        //@Param : correoElectronico, correo electronico del administrador
        //@Param : foto, URL de la foto del administrador
        //@Return : boolean retorna verdadero si creó al administrador
        public Boolean crearAdministrador(int id, string nombreUsuario, string nombre, string apellidos, 
            string cedula, string direccion, string telefono, string correoElectronico, string foto)
        {
            //Añade un nuevo objeto a la tabla Administradores
            db.Administradores.Add(new Administrador
            {
                nombreUsuario = nombreUsuario,
                nombre = nombre,
                apellidos = apellidos,
                cedula = cedula,
                direccion = direccion,
                telefono = telefono,
                correoElectronico = correoElectronico,
                foto = foto
            });
            //Guardamos los cambios
            db.SaveChanges();
            //retornamos true si los cambios fueron exítosos
            return true;
        }

        //Metodo que recibe todos los atributos del administrador a crear
        //@Param : administrador, objeto Administrador que contiene la información del nuevo administrador
        //Return : retorna true si creó al administrador
        public Boolean agregarAdministrador(Administrador administrador)
        {
            return crearAdministrador(administrador.id, administrador.nombreUsuario, administrador.nombre,
                administrador.apellidos, administrador.cedula, administrador.direccion, administrador.telefono,
                administrador.correoElectronico, administrador.foto);
        }

    }
}