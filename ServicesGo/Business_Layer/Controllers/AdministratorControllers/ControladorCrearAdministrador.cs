using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Controllers.BussinesLayer.ControladorasAdministrador
{
    public static class ControladorCrearAdministrador
    {
        private static HomeServicesContext db = new HomeServicesContext();
    

        public static Boolean crearAdministrador(int id, string nombreUsuario, string nombre, string apellidos, 
            string cedula, string direccion, string telefono, string correoElectronico, string foto)
        {
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
            db.SaveChanges();

            return true;
        }

    }
}