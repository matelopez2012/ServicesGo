using ServicesGo.Business_Layer.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasDocumento
{
    //Servicio para eliminar documento
    public class ControladorEliminarDocumento
    {
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private static HomeServicesContext db = new HomeServicesContext();

        //Método para eliminar una habilidad
        //@Param : id de la hábilidad a eliminar
        //@Return : boolean retorna verdadero si se eliminó la habilidad
        public Boolean eliminarHabilidad(int id)
        {

            //Búscamos el objeto que tiene el id que obtenemos por párametro
            Documento documento = db.Documentos.Find(id);
            //Eliminamos el objeto obtenido
            db.Documentos.Remove(documento);
            //guardamos los cambios
            db.SaveChanges();

            //retornamos true si el objeto se eliminó correctamente
            return true;
        }
    }
}