using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.controladorasDocumento
{
    //Servicio para actualizar documento
    public class ControladoraActualizarDocumento
    {

        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private static HomeServicesContext db = new HomeServicesContext();

        public static Boolean actualizarDocumento(int id, string nombreDoc, string ruta, Habilidad habilidad)
        {

            Documento documento = db.Documentos.Find(id);
            documento.nombreDoc = nombreDoc;
            documento.ruta = ruta;
            documento.habilidad = habilidad;
            db.Documentos.Add(documento);

            db.Entry(documento).State = EntityState.Modified;
            db.SaveChanges();

            return true;
        }

        public static Boolean actualizarHabilidadDocumento(int id, Habilidad habilidad)
        {

            Documento documento = db.Documentos.Find(id);
            documento.habilidad = habilidad;
           
            db.Documentos.Add(documento);

            db.Entry(documento).State = EntityState.Modified;
            db.SaveChanges();

            return true;
        }

    }
}