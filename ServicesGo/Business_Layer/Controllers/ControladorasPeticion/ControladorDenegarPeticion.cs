using ServicesGo.Business_Layer.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasPeticion
{
    public class ControladorDenegarPeticion
    {
        private HomeServicesContext db = new HomeServicesContext();

        public PrestadorServicios buscarPS(string nombreUsuario)
        {
            var query = from st in db.PrestadoresServicios
                        where st.nombreUsuario == nombreUsuario
                        select st;

            return query.FirstOrDefault();
        }

        public void denegarPeticion(string idPeticion, string nombreCuenta, bool resuelta)
        {
            PrestadorServicios ps = buscarPS(nombreCuenta);

            ps.PerfilModificado = resuelta;

            Peticion peticion = db.Peticiones.Find(idPeticion);

            peticion.resuelta = resuelta;

            db.SaveChanges();
        }
    }
}