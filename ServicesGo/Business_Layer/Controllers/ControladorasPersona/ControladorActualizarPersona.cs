﻿using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasPersona
{
    public static class ControladorActualizarPersona
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
        public Boolean actualizarPersona(int id, string nombreUsuario, string nombre, string apellidos, 
            string cedula, string direccion, string telefono, string correoElectronico, string foto)
            {
                //Búscamos a la persona cuyo id es el que recibimos por parámetro
                Persona persona = db.Personas.Find(id);

                //Asignamos los nuevos atributos a la persona creada
                persona.nombreUsuario = nombreUsuario;
                persona.nombre = nombre;
                persona.apellidos = apellidos;
                persona.cedula = cedula;
                persona.direccion = direccion;
                persona.telefono = telefono;
                persona.correoElectronico = correoElectronico;
                persona.foto = foto;
                
                //Añadimos el nuevo objeto a la tabla habilidades
                db.Personas.Add(persona);
                db.Entry(persona).State = EntityState.Modified;
                
                //Guardamos los cambios
                db.SaveChanges();

                //Retornamos true para indicar que el objeto se actualizó correctamente
                return true;
            }

            //Método que recibe todos los nuevos atributos de la persona a modificar
            //@Param : persona, objeto Persona que contiene la nueva información de la persona a modificar
            //Return : retorna true si modificó a la persona
            public Boolean modificarPersona(Persona persona)
            {
                return actualizarPersona(persona.id, persona.nombreUsuario, persona.nombre, persona.apellidos, 
                    persona.cedula, persona.direccion, persona.telefono, persona.correoElectronico, persona.foto);
            }
        
    }
}