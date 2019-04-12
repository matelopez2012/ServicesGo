using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasPrestadorServicios
{
    public class ControladorCambiarPresentacionPerfilPS
    {

        private static HomeServicesContext db = new HomeServicesContext();


        public static void cambiarPresentacionPerfil(string cedula, int presentacion)
        {
            PrestadorServicios prestador = buscarPrestadorServicios(cedula);

            prestador.estiloPresentacion = presentacion;
            db.PrestadoresServicios.Add(prestador);
            db.Entry(prestador).State = EntityState.Modified;
            db.SaveChanges();



        }

       
        public static  PrestadorServicios buscarPrestadorServicios(string cedula)
        {
            PrestadorServicios prestador = db.PrestadoresServicios.Find(cedula);

            return prestador;


        }



    }
}