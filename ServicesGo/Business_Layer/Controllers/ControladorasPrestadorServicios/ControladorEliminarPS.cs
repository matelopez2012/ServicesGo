using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasPrestadorServicios
{
    public class ControladorEliminarPS
    {


        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private  HomeServicesContext db = new HomeServicesContext();

        //Método para eliminar una Ps
        //@Param : cedula numero de identificacion de el PS a eliminar
        //@Return : boolean retorna verdadero si se eliminó el PS
        public bool elimPrestadoServicios(string cedula)
        {
            //Búscamos el objeto que tiene la cedula que obtenemos por párametro 
            var query = db.PrestadoresServicios.Find(cedula);
            //Eliminamos el objeto obtenido
            db.PrestadoresServicios.Remove(query);
            //guardamos los cambios
            db.SaveChanges();
            //retornamos true si el objeto se eliminó correctamente
            return true;
        }
    }




}
