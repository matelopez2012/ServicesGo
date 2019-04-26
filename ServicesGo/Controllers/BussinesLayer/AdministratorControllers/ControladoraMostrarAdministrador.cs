using ServicesGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicesGo.Controllers.BussinesLayer.AdministratorControllers
{
    public class ControladoraMostrarAdministrador
    {
        public ControladoraMostrarAdministrador()
        {

        }
        public Administrador buscarAdministrador(string cedula)
        {
            Administrador admin = new Administrador("matelopez2012", "Mateo", "López", "1053857801", "Cll 47 # 13-13", "88888888", "matelopez2012@gmail.com", "foto.jpg");
            return admin;
        }

        public void mostrarAdministrador(Administrador administrador)
        {
            Console.WriteLine(administrador.nombreUsuario);
        }
    }

   
}