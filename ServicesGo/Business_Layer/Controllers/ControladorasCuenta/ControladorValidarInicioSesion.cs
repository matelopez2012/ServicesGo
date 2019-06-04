using ServicesGo.Business_Layer.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasCuenta
{
    public class ControladorValidarInicioSesion
    {
        // Instancia del contexto que permitirá mapear la base de datos
        private HomeServicesContext DataBaseMap = new HomeServicesContext();

        // Consulta si existe la cuenta en la base de datos y la retorna
        // null en caso de no existir
        public Cuenta BuscarCuenta(string nombreUsuario)
        {
            var consultaCuenta = from st in DataBaseMap.Cuentas
                                 where st.NombreUsuario == nombreUsuario
                                 select st;

            return consultaCuenta.FirstOrDefault();
        }

        // Si la cuenta existe y su contraseña concuerda retorna true
        public bool ValidarSesion(string nombreCuenta, string contrasena)
        {
            var cuenta = BuscarCuenta(nombreCuenta);

            if (cuenta == null || cuenta.Contrasena != contrasena)
            {
                return false;
            }

            return true;
        }
    }
}