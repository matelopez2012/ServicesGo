using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasPeticion
{
    public class ControladorDenegarPeticion
    {
        private static HomeServicesContext db = new HomeServicesContext();

        public static PrestadorServicios buscarPS(string nombreUsuario)
        {
            var query = from st in db.PrestadoresServicios
                        where st.nombreUsuario == nombreUsuario
                        select st;

            return query.FirstOrDefault();
        }

        public static void denegarPeticion(string idPeticion, string nombreCuenta, bool resuelta)
        {
            PrestadorServicios ps = buscarPS(nombreCuenta);

            ps.modificado = resuelta;

            Peticion peticion = db.Peticiones.Find(idPeticion);

            peticion.resuelta = resuelta;

            db.SaveChanges();
        }
    }
}