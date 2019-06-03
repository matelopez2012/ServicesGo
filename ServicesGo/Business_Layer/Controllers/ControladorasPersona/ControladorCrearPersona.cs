using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasPersona
{
    public class ControladorCrearPersona
    {
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private static HomeServicesContext db = new HomeServicesContext();

        //Metodo para crear una persona.
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
        public Boolean crearPersona(string nombreUsuario, string nombre, string apellidos,
            string cedula, string direccion, string telefono, string correoElectronico, string foto)
        {
            //Añade un nuevo objeto a la tabla Personas
            db.Personas.Add(new Persona
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

        //Método que recibe todos los atributos de la persona a crear
        //@Param : persona, objeto Persona que contiene la información de la nueva persona
        //Return : retorna true si creó a la persona
        public Boolean agregarPersona(Persona persona)
        {
            return crearPersona(persona.nombreUsuario, persona.nombre, persona.apellidos, 
                persona.cedula, persona.direccion, persona.telefono, persona.correoElectronico, persona.foto);
        }
    }
}