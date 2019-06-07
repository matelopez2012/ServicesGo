using ServicesGo.Business_Layer.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasPersona
{
    public class ControladorActualizarPersona
    {
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private static HomeServicesContext db = new HomeServicesContext();

        //Metodo que actualiza la nueva información de la persona.
        //@Param : id de la persona a ser modificada.
        //@Param : nombreUsuario, nuevo nombre de usuario de la persona
        //@Param : nombre, nuevo nombre de la persona
        //@Param : apellidos, nuevos apellidos de la persona
        //@Param : cedula, nueva cedula de la persona
        //@Param : direccion, nueva direccion de la persona
        //@Param : telefono, nuevo telefono de la persona
        //@Param : correoElectronico, nuevo correo electronico de la persona
        //@Param : foto, nueva URL de la foto de la persona
        //@Return : boolean retorna verdadero si actualizo a la persona
        public Boolean actualizarPersona(int id, Cuenta cuentaRef, string nombre, string apellidos, 
            string cedula, string direccion, string telefono, string correoElectronico, string foto)
            {
                //Buscamos el objeto en el ORM cuyo id es el que obtenemos por parámetro
                Persona persona = db.Personas.Find(id);

                //Asignamos los nuevos atributos a la persona creada
                persona.CuentaRef = cuentaRef;
                persona.Nombre = nombre;
                persona.Apellidos = apellidos;
                persona.Documento = cedula;
                persona.Direccion = direccion;
                persona.Telefono = telefono;
                persona.Correo = correoElectronico;
                persona.Foto = foto;
                
                //Añadimos la instancia persona con los nuevos atributos al ORM
                //reemplazando a la instancia de la persona original
                db.Personas.Add(persona);
                //Comprobamos si existe alguna modificación de los atributos 
                db.Entry(persona).State = EntityState.Modified;
                
                //Guardamos los cambios en el ORM, quedando así actualizado
                db.SaveChanges();

                //Retornamos true para indicar que el objeto se actualizó correctamente
                return true;
            }

            //Método que recibe todos los nuevos atributos de la persona a modificar
            //@Param : persona, objeto Persona que contiene la nueva información de la persona a modificar
            //Return : retorna true si modificó a la persona
            public Boolean modificarPersona(Persona persona)
            {
                return actualizarPersona(persona.Id, persona.CuentaRef, persona.Nombre, persona.Apellidos, 
                    persona.Documento, persona.Direccion, persona.Telefono, persona.Correo, persona.Foto);
            }
        
    }
}