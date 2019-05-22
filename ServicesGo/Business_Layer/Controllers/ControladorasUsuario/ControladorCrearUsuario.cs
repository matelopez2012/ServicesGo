using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasUsuario
{
    public static class ControladorCrearUsuario
    {
        private static HomeServicesContext db = new HomeServicesContext();


        public static Boolean crearUsuario(string nombreUsuario, string nombre, string apellidos, string cedula, string direccion,
            string telefono, string correoElectronico, string foto)
        {
            Usuario usuario = new Usuario(nombreUsuario, nombre, apellidos, cedula, direccion, telefono, correoElectronico, foto);

            db.Usuarios.Add(usuario);
            db.SaveChanges();

            return true;
        }
    }
}