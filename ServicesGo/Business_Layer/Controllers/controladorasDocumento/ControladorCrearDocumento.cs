using ServicesGo.Business_Layer.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasDocumento
{



    public class ControladoraCrearDocumento
    {
        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private static HomeServicesContext db = new HomeServicesContext();

        //Metodo para crear un nuevo documento cuyos atributos pasamos por parámetro
        //Recibimos como parametros los atributos del documento a crear
        public void crearDocumento(string nombreDoc, string ruta, int habilidad )
        {
            //Creamos una nueva instancia, y se envía por parametro sus atributos
            Documento document = new Documento(nombreDoc, ruta, habilidad);

            //Añadimos la instancia que acabamos de crea al mapeador de clases ORM
            db.Documentos.Add(document);
            db.SaveChanges();
        }
    }
}