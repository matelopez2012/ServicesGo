using ServicesGo.Business_Layer.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasCuenta
{
    public class ControladorRecuperarContrasena
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

        // El sistema genera un token para que el usuario cambie de contraseña
        // envia el token como link al correo y entra por GET al metodo
        public bool CambiarContrasena(string nombreUsuario, string contrasenaNueva, string token)
        {
            if (ValidarToken(nombreUsuario, token))
            {
                Cuenta cuenta = BuscarCuenta(nombreUsuario);
                cuenta.Contrasena = contrasenaNueva;
                DataBaseMap.SaveChanges();

                return true;
            }

            return false;
        }

        // Recibe el token generado por el sistema para una cuenta en especifico
        // El token es generado cuando el usuario requiere cambiar contraseña
        public bool ValidarToken(string nombreUsuario, string token)
        {
            var cuenta = BuscarCuenta(nombreUsuario);

            byte[] tokenBase64 = Convert.FromBase64String(token);
            DateTime fechaGenerado = DateTime.FromBinary(BitConverter.ToInt64(tokenBase64, 0));

            // El token tiene caducidad
            if (fechaGenerado >= DateTime.UtcNow.AddHours(-24))
            {
                if (cuenta.Token == token)
                {
                    return true;
                }
            }

            return false;
        }

        public void EnviarCorreo(string nombreUsuario, string correo)
        {
            var query = from st in DataBaseMap.Personas
                        where st.correoElectronico == correo
                        select st;

            if (query.FirstOrDefault() != null)
            {
                using (SmtpClient smtpClient = new SmtpClient())
                {
                    var basicCredential = new NetworkCredential("homeservices_info@maildrop.cc", "");
                    using (MailMessage message = new MailMessage())
                    {
                        MailAddress fromAddress = new MailAddress("homeservices_info@maildrop.cc");

                        smtpClient.Host = "mail.maildrop.cc";
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = basicCredential;

                        message.From = fromAddress;
                        message.Subject = "Recuperación de contraseña";
                        // Set IsBodyHtml to true means you can send HTML email.
                        message.IsBodyHtml = true;

                        byte[] time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
                        byte[] key = Guid.NewGuid().ToByteArray();
                        string token = Convert.ToBase64String(time.Concat(key).ToArray());

                        var cuenta = BuscarCuenta(nombreUsuario);

                        cuenta.Token = token;

                        DataBaseMap.SaveChanges();

                        message.Body = "<h1>Recuperar contraseña</h1><br/><p>Su token es " + token + "<p/>";
                        message.To.Add(correo);
                        smtpClient.Send(message);
                    }
                }
            }
        }
    }

    public class CopyOfControladorRecuperarContrasena
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

        // El sistema genera un token para que el usuario cambie de contraseña
        // envia el token como link al correo y entra por GET al metodo
        public bool CambiarContrasena(string nombreUsuario, string contrasenaNueva, string token)
        {
            if (ValidarToken(nombreUsuario, token))
            {
                Cuenta cuenta = BuscarCuenta(nombreUsuario);
                cuenta.Contrasena = contrasenaNueva;
                DataBaseMap.SaveChanges();

                return true;
            }

            return false;
        }

        // Recibe el token generado por el sistema para una cuenta en especifico
        // El token es generado cuando el usuario requiere cambiar contraseña
        public bool ValidarToken(string nombreUsuario, string token)
        {
            var cuenta = BuscarCuenta(nombreUsuario);

            byte[] tokenBase64 = Convert.FromBase64String(token);
            DateTime fechaGenerado = DateTime.FromBinary(BitConverter.ToInt64(tokenBase64, 0));

            // El token tiene caducidad
            if (fechaGenerado >= DateTime.UtcNow.AddHours(-24))
            {
                if (cuenta.Token == token)
                {
                    return true;
                }
            }

            return false;
        }

        public void EnviarCorreo(string nombreUsuario, string correo)
        {
            var query = from st in DataBaseMap.Personas
                        where st.correoElectronico == correo
                        select st;

            if (query.FirstOrDefault() != null)
            {
                using (SmtpClient smtpClient = new SmtpClient())
                {
                    var basicCredential = new NetworkCredential("homeservices_info@maildrop.cc", "");
                    using (MailMessage message = new MailMessage())
                    {
                        MailAddress fromAddress = new MailAddress("homeservices_info@maildrop.cc");

                        smtpClient.Host = "mail.maildrop.cc";
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = basicCredential;

                        message.From = fromAddress;
                        message.Subject = "Recuperación de contraseña";
                        // Set IsBodyHtml to true means you can send HTML email.
                        message.IsBodyHtml = true;

                        byte[] time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
                        byte[] key = Guid.NewGuid().ToByteArray();
                        string token = Convert.ToBase64String(time.Concat(key).ToArray());

                        var cuenta = BuscarCuenta(nombreUsuario);

                        cuenta.Token = token;

                        DataBaseMap.SaveChanges();

                        message.Body = "<h1>Recuperar contraseña</h1><br/><p>Su token es " + token + "<p/>";
                        message.To.Add(correo);
                        smtpClient.Send(message);
                    }
                }
            }
        }
    }
}