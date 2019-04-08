using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.controladorasDocumento
{
    public class ControladoraMostrarDocumento
    {
        private static HomeServicesContext db = new HomeServicesContext();


        public static Documento mostrarDocumento(int id)
        {

            Documento documento = db.Documentos.Find(id);

            if (documento != null)
            {
                return documento;
            }

            else
            {
                return null;
            }
        }

    }
}