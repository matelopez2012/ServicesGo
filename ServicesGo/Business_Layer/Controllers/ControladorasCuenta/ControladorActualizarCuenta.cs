using ServicesGo.Business_Layer.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasCuenta
{
    public class ControladorActualizarCuenta
    {
        // Instancia del contexto que permitirá mapear la base de datos
        private HomeServicesContext DataBaseMap = new HomeServicesContext();

        // Consulta si existe la cuenta en la base de datos y la retorna
        // null en caso de que no exista
        public Cuenta BuscarCuenta(string nombreUsuario)
        {
            var consultaCuenta = from st in DataBaseMap.Cuentas
                        where st.NombreUsuario == nombreUsuario
                        select st;

            return consultaCuenta.FirstOrDefault();
        }

        // Método para actualizar el rol de un usuario
        public bool ActualizarRol(string nombreUsuario, string rol)
        {
            if (BuscarCuenta(nombreUsuario) != null)
            {
                // Si la cuenta existe la guarda
                var cuenta = BuscarCuenta(nombreUsuario);
                
                //Y cambia su rol
                cuenta.Rol = rol;
                DataBaseMap.SaveChanges();

                return true;
            }

            return false;
        }
    }
}