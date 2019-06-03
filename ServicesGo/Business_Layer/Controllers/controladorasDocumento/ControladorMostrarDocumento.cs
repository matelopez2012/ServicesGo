using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasDocumento
{
    //Servicio para mostrar un determinado documento
    public class ControladoraMostrarDocumento
    {
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private static HomeServicesContext db = new HomeServicesContext();

        //Constructor del servicio mostrar documento
        //Recibe como parámetro
        public static Documento mostrarDocumento(int id)
        {
            //Búscamos el documento cuyo id se obtiene por parámetro
            Documento documento = db.Documentos.Find(id);

            //Si el documetno es diferente de nulo, o sea, que existe, lo retornamos
            if (documento != null)
            {
                return documento;
            }
            //Sino, no existe y por lo tanto retornamos nulo
            else
            {
                return null;
            }
        }

    }
}