using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasEmpleado
{
    public  class ControladorVerEmpleado
    {
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private  HomeServicesContext db = new HomeServicesContext();

        //Método que llama al metodo que busca a el Empleado a mostrar y retorna lo que retorne este
        //@Param : cedula  numero de identificacion de el Empleaado que se quiere mostrar
        public  Empleado mostrarEmpleado(string cedula)
        {   
            return buscarEmpleado(cedula);
        }

        //Método busca a el Empleado a mostrar y retorna lo retorna
        //@Param : cedula  numero de identificacion de el Empleaado que se quiere mostrar
        public  Empleado buscarEmpleado(string cedula)
        {
            return db.Empleados.Find(cedula);
        }

    }
}