
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ServicesGo.Models
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Empleado admin = new Empleado("matelopez2012", "Mateo", "López", "1053857801", "Cll 47 # 13-13", "88888888", "matelopez2012@gmail.com", "foto.jpg");
            Console.WriteLine(admin.nombreUsuario);
        }
    }
}