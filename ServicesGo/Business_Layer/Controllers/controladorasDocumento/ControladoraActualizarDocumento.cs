using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.controladorasDocumento
{
    public class ControladoraActualizarDocumento
    {

        private static HomeServicesContext db = new HomeServicesContext();

        public static Boolean actualizarDocumento(int id, string nombreDoc, string ruta, int habilidad)
        {

            Documento documento = db.Documentos.Find(id);
            documento.nombreDoc = nombreDoc;
            documento.ruta = ruta;
            documento.habilidad_id = habilidad;
            db.Documentos.Add(documento);

            db.Entry(documento).State = EntityState.Modified;
            db.SaveChanges();

            return true;
        }

        public static Boolean actualizarHabilidadDocumento(int id, int habilidad)
        {

            Documento documento = db.Documentos.Find(id);
            documento.habilidad_id = habilidad;
           
            db.Documentos.Add(documento);

            db.Entry(documento).State = EntityState.Modified;
            db.SaveChanges();

            return true;
        }

    }
}