using ServicesGo.Business_Layer.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasUsuario
{
    public class ControladorEliminarUsuario
    {
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private HomeServicesContext db = new HomeServicesContext();

        //Método para eliminar un usuario
        //@Param : id del usuario a eliminar
        //@Return : boolean retorna verdadero si se eliminó la habilidad
        public Boolean eliminarUsuario(int id)
        {

            //Búscamos el objeto que tiene el id que obtenemos por párametro
            Habilidad habilidad = db.Habilidades.Find(id);
            //Eliminamos el objeto obtenido
            db.Habilidades.Remove(habilidad);
            //guardamos los cambios
            db.SaveChanges();

            //retornamos true si el objeto se eliminó correctamente
            return true;
        }
    }
}   
