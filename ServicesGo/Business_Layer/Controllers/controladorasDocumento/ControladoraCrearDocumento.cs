using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.controladorasDocumento
{
    public static class ControladoraCrearDocumento
    {

        private static HomeServicesContext db = new HomeServicesContext();


        public static Boolean crearDocumento(string nombreDoc, string ruta, int habilidad )
        {
            Documento document = new Documento(nombreDoc, ruta, habilidad);

            db.Documentos.Add(document);
            db.SaveChanges();

            return true;
        }
    }
}