using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasAdministrador
{
    public static class ControladorActualizarAdministrador
    {
        private static HomeServicesContext db = new HomeServicesContext();

        public static Boolean actualizarAdministrador(int id, string nombreUsuario, string nombre, string apellidos,
            string cedula, string direccion, string telefono, string correoElectronico, string foto)
        {

            Administrador administrador = db.Administradores.Find(id);

            administrador.nombreUsuario = nombreUsuario;
            administrador.nombre = nombre;
            administrador.apellidos = apellidos;
            administrador.cedula = cedula;
            administrador.direccion = direccion;
            administrador.telefono = telefono;
            administrador.correoElectronico = correoElectronico;
            administrador.foto = foto;

            db.Administradores.Add(administrador);

            db.Entry(administrador).State = EntityState.Modified;
            db.SaveChanges();

      

            return true;
        }
        
    }
}