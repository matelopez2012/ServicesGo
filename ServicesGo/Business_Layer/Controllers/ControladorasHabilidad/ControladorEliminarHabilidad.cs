using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasHabilidad
{
    public class ControladorEliminarHabilidad
    {
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private static HomeServicesContext db = new HomeServicesContext();

        //Método para eliminar una habilidad
        //@Param : id de la hábilidad a eliminar
        //@Return : boolean retorna verdadero si se eliminó la habilidad
        public boolean eliminarHabilidad(int id)
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