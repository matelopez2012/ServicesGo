using ServicesGo.Business_Layer.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasCuenta
{
    public class ControladorCrearCuenta
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

        // 
        public bool CrearCuenta(string nombreUsuario, string contrasena, string rol)
        {
            if (BuscarCuenta(nombreUsuario) == null)
            {
                Cuenta cuenta = new Cuenta(nombreUsuario,contrasena,rol);

                DataBaseMap.Cuentas.Add(cuenta);
                DataBaseMap.SaveChanges();

                return true;
            }

            return false;
        }
    }
}