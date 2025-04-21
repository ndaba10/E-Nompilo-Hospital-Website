using PHCApplication.Migrations;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Http;
using System.Net.Mail;

namespace PHCApplication.Models
{
    public class Email
    {
        [Key]
         public int ID { get;set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }


        public void SendMail()
        {
            MailMessage mc = new MailMessage(System.Configuration.ConfigurationManager.AppSettings["Email"].ToString() ,To);
            mc.Subject = Subject;
            mc.Body = Body;
            mc.IsBodyHtml = false;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com" , 587);
            smtp.Timeout = 1000000;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            NetworkCredential nc = new NetworkCredential(System.Configuration.ConfigurationManager.AppSettings["Email"].ToString() , System.Configuration.ConfigurationManager.AppSettings["Password"].ToString());
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = nc;
            smtp.Send(mc);

            //mc.From = new MailAddress("clashcode.testing@outlook.com");

            //message.To.Add(email);
            //message.Subject = subject;
            //message.IsBodyHtml = true;
            //message.Body = confirmLink;

            //smtpClient.Port = 587;
            //smtpClient.Host = "smtp.office365.com";

            //smtpClient.EnableSsl = true;
            //smtpClient.UseDefaultCredentials = false;
            //smtpClient.Credentials = new NetworkCredential("clashcode.testing@outlook.com", "Clash1234");
            //smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtpClient.Send(message);
            //return true;
        }
    }
}
