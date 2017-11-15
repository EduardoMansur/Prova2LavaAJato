using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Http;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using webApiProva2.Connect;
using webApiProva2.Models;

namespace webApiProva2.Controllers
{
    public class EmailController : ApiController
    {
        [Route("api/Email/send")]
        [HttpPost]
        [ResponseType(typeof(string))]
        public void sendEmail(string email)
        {

            SmtpClient cliente = new SmtpClient();
            cliente.Host = "smtp.gmail.com";
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.EnableSsl = true;
            cliente.Port = 587;

            System.Net.NetworkCredential credenciais = new NetworkCredential("emailprovatalp@gmail.com", "Aluno123");
            cliente.Credentials = credenciais;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("emailprovatalp@gmail.com");
            mail.To.Add(new MailAddress("eduardotmpereira@gmail.com"));
            mail.Body = "Corpo do e-mail. Email enviado pela prova  15200402";
            cliente.Send(mail);

        }

  
    }
}
