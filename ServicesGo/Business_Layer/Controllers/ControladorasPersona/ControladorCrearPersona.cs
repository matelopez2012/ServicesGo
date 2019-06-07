using ServicesGo.Business_Layer.Models;
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
        //Recibimos como parametros los atributos de la persona a crear
        //@Param : id de la persona
        //@Param : nombreUsuario, nombre de usuario de la persona
        //@Param : nombre, nombre de la persona
        //@Param : apellidos, apellidos de la persona
        //@Param : cedula, cedula de la persona
        //@Param : direccion, direccion de la persona
        //@Param : telefono, telefono de la persona
        //@Param : correoElectronico, correo electronico de la persona
        //@Param : foto, URL de la foto de la persona
        //@Return : boolean retorna verdadero si creó a la persona
        public Boolean crearPersona(Cuenta cuentaRef, string nombre, string apellidos,
            string cedula, string direccion, string telefono, string correoElectronico, string foto)
        {
            //Creamos una nueva instancia de Persona, y se envía por parametro sus atributos
            //Añadimos la instancia de Persona que acabamos de crear al mapeador de clases ORM
            db.Personas.Add(new Persona
            (
                cuentaRef,
                nombre,
                apellidos,
                cedula,
                direccion,
                telefono,
                correoElectronico,
                foto
            ));
            //Guardamos los cambios en el ORM, quedando así actualizado
            db.SaveChanges();
            //retornamos true si los cambios en el ORM fueron exitosos con la creación de la persona
            return true;
        }

        //Método que recibe todos los atributos de la persona a crear
        //@Param : persona, objeto Persona que contiene la información de la nueva persona
        //Return : retorna true si creó a la persona
        public Boolean agregarPersona(Persona persona)
        {
            return crearPersona(persona.CuentaRef, persona.Nombre, persona.Apellidos, 
                persona.Documento, persona.Direccion, persona.Telefono, persona.Correo, persona.Foto);
        }
    }
}