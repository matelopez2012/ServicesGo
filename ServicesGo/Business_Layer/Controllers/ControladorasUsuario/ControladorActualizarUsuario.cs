using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasUsuario
{
    public class ControladorActualizarUsuario
    {
        private static HomeServicesContext db = new HomeServicesContext();

        public static Boolean actualizarHabiliad(int id, string nombreUsuario, string nombre, string apellidos, 
            string cedula, string direccion, string telefono, string correoElectronico, string foto)
        {

            Usuario usuario = db.Usuarios.Find(id);
            usuario.nombreUsuario = nombreUsuario;
            usuario.nombre = nombre;
            usuario.apellidos = apellidos;
            usuario.cedula = cedula;
            usuario.direccion = direccion;
            usuario.telefono = telefono;
            usuario.correoElectronico = correoElectronico;
            usuario.foto = foto;


            db.Usuarios.Add(usuario);

            db.Entry(usuario).State = EntityState.Modified;
            db.SaveChanges();



            return true;
        }
    }
}