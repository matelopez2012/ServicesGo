using ServicesGo.Models;
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
        private static HomeServicesContext db = new HomeServicesContext();

        
            public static Boolean actualizarPersona(int id, string nombreUsuario, string nombre, string apellidos, string cedula, 
                string direccion, string telefono, string correoElectronico, string foto)
            {

                Persona persona = db.Personas.Find(id);
                persona.nombreUsuario = nombreUsuario;
                persona.nombre = nombre;
                persona.apellidos = apellidos;
                persona.cedula = cedula;
                persona.direccion = direccion;
                persona.telefono = telefono;
                persona.correoElectronico = correoElectronico;
                persona.foto = foto;
                db.Personas.Add(persona);

                db.Entry(persona).State = EntityState.Modified;
                db.SaveChanges();

      

                return true;
            }
        
    }
}