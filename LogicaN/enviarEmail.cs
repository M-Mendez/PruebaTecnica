using System;
using System.Net.Mail;

namespace PruebaT.LogicaN
{
    public class enviarEmail
    {
        private string dominio ="http://localhost:5001/";
        public void enviarcorreo(string destinatario, string token)
        {
            string Origen = ""; //Ingresar su correo
            
            string contraseña =""; //Ingresar la contraseña de su correo

            string url = dominio + "Cuentas/Restaurar/?token="+token;

            MailMessage message = new MailMessage(Origen, destinatario, "Recuperación de Contraseña",
                "<p>Usted solicito recuperación de contraseña seleccione el siguiente link para ingresar</p><br>"+
                "<a href='"+url+"'>Click para Recuperar Contraseña</a>" );
            
            message.IsBodyHtml = true;

            string output = null;
           try{
            
            SmtpClient smtpclient = new SmtpClient();
            smtpclient.EnableSsl = true;
            smtpclient.UseDefaultCredentials = false;
            smtpclient.Host = "smtp.gmail.com";
            smtpclient.Port = 587;
            smtpclient.Credentials = new System.Net.NetworkCredential(Origen, contraseña);

            smtpclient.Send(message);

            smtpclient.Dispose();

            output = "Message enviado";

            }
            catch (Exception ex)
            {
            output = "Error : " + ex.Message;
            }
            Console.WriteLine(output);
        }
    }
}