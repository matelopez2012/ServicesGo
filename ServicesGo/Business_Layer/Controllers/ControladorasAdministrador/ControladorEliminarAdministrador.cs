using ServicesGo.Business_Layer.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasAdministrador
{
    public class ControladorEliminarAdministrador
    {
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private HomeServicesContext db = new HomeServicesContext();

        //Método para eliminar un administrador
        //@Param : id del administrador a eliminar
        //@Return : boolean retorna verdadero si se eliminó el administrador
        public Boolean eliminarAdministrador(int id)
        {
            //Búscamos el objeto que tiene el id que obtenemos por párametro
            Administrador administrador = db.Administradores.Find(id);
            //Eliminamos el objeto obtenido
            db.Administradores.Remove(administrador);
            //guardamos los cambios
            db.SaveChanges();

            //retornamos true si el objeto se eliminó correctamente
            return true;
        }
    }
}