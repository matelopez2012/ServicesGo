using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasEmpleado
{


    public  class ControladorEliminarEmpleado
    {
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private HomeServicesContext db = new HomeServicesContext();

        //Método para eliminar una Empleado
        //@Param : cedula numero de identificacion de el Empleado a eliminar
        //@Return : boolean retorna verdadero si se eliminó el Empleado
        public bool elimEmpleado(string cedula) {

            //Búscamos el objeto que tiene la cedula que obtenemos por párametro 
            var query = db.Empleados.Find(cedula);
            //Eliminamos el objeto obtenido
            db.Empleados.Remove(query);
            //guardamos los cambios
            db.SaveChanges();
            //retornamos true si el objeto se eliminó correctamente
            return true;
}
}
}