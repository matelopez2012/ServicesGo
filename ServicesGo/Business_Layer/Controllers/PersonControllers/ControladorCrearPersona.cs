using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Controllers.BussinesLayer.ControladorasPersona
{
    public static class ControladorCrearPersona
    {
        private static HomeServicesContext db = new HomeServicesContext();
    

        public static Boolean crearPersona(string nombreUsuario, string nombre, string apellidos,
            string cedula, string direccion,  string telefono, string correoElectronico, string foto)
        {
            
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
            db.SaveChanges();

            return true;
        }

    }
}