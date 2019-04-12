using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.ControladorasCuenta
{
    public class ControladoraRecuperarContrasena
    {
        private static HomeServicesContext db = new HomeServicesContext();

        public static Cuenta buscarCuenta(string nombreUsuario)
        {
            var query = from st in db.Cuentas
                        where st.nombreUsuario == nombreUsuario
                        select st;

            return query.FirstOrDefault();
        }

        public static void cambiarContrasena(string nombreUsuario, string contrasenaNueva)
        {
            Cuenta cuenta = buscarCuenta(nombreUsuario);
            cuenta.contrasena = contrasenaNueva;
            db.SaveChanges();
        }

        public static bool validarToken(string nombreUsuario, string token)
        {
            byte[] data = Convert.FromBase64String(token);
            DateTime when = DateTime.FromBinary(BitConverter.ToInt64(data, 0));

            if (when >= DateTime.UtcNow.AddHours(-24))
            {
                return true;
            }

            return false;
        }


        public static void enviarCorreo(string correo)
        {
            var query = from st in db.Personas
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

                        message.Body = "<h1>Recuperar contraseña</h1><br/><p>Su token es " + token + "<p/>";
                        message.To.Add(correo);

                        try
                        {
                            smtpClient.Send(message);
                        }
                        catch (Exception ex)
                        {
                            //Error, could not send the message
                        }
                    }
                }
            }
        }
    }
}