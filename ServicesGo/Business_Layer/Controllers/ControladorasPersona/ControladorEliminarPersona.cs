using ServicesGo.Business_Layer.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasPersona
{
    public class ControladorEliminarPersona
    {
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private HomeServicesContext db = new HomeServicesContext();

        //Método para eliminar una persona
        //@Param : id de la persona a eliminar
        //@Return : boolean retorna verdadero si se eliminó la persona
        public Boolean eliminarPersona(int id)
        {
            //Búscamos el objeto que tiene el id que obtenemos por párametro
            Persona persona = db.Personas.Find(id);
            //Eliminamos el objeto obtenido
            db.Personas.Remove(persona);
            //guardamos los cambios
            db.SaveChanges();

            //retornamos true si el objeto se eliminó correctamente
            return true;
        }
    }
}