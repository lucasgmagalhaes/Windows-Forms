using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;

namespace Bloqueados_Auto
{
    static class Email
    {
        public static void NetTest()
        {
            string status = "";
            try
            {
                using (var cliente = new WebClient())
                {
                    using (var teste = cliente.OpenRead("http://www.google.com.br"))
                    {

                        status = "Conexão estabelecida com sucesso.";

                    }
                }
            }
            catch
            {

                status = "Não foi possível estabelecer conexão";
            }
            Console.Write(status);

        } // Tesde simples de conexão à internet.

        public static void Send(string cliente, string dest, string senha, string titulo, string msg) //recebe as informações para o email
        {
            int index = cliente.LastIndexOf('@'); // variavel para pegar contar todos os valores antes do @

            SmtpClient SMTP = new SmtpClient(); // envio SMTP 

            // a diferença de cada provedor de emial está no seu host e a porta de comunicação basicamente.
            //email de envio gmail.com
            if (cliente.Substring(index) == "@gmail.com" || cliente.Substring(index) == "@gmail.com.br") //se for retirado dos os carcteres entes do @, e o que sobrar for igual à "@gmail.com"
            {

                //configuração do SMTP. porta, host, timeout, etc
                SMTP = new SmtpClient("smtp.gmail.com", 587); // cria protocolo SMTP, informando o host(no caso O Gmail e a porta de envio dele. tais informações são retiradas do provedor de email

                SMTP.EnableSsl = true; //Conexão encriptografada.
                SMTP.Timeout = 10000; //tempo de tentativa de envio.
                SMTP.DeliveryMethod = SmtpDeliveryMethod.Network; //qual será o método de entrega do email? Internet
                SMTP.UseDefaultCredentials = false; //
                SMTP.Credentials = new NetworkCredential(cliente, senha);
            }
            //email de envio Hotmail.com
            else if (cliente.Substring(index) == "@hotmail.com" || cliente.Substring(index) == "@hotmail.com.br")
            {
                SMTP = new SmtpClient("smtp-mail.outlook.com", 587); // cria protocolo SMTP, informando o host(no caso O Gmail e a porta de envio dele. tais informações são retiradas do provedor de email

                SMTP.EnableSsl = true; //Conexão encriptografada.
                SMTP.Timeout = 10000; //tempo de tentativa de envio.
                SMTP.DeliveryMethod = SmtpDeliveryMethod.Network; //qual será o método de entrega do email? Internet
                SMTP.UseDefaultCredentials = false; //
                SMTP.Credentials = new NetworkCredential(cliente, senha);

            }
            else if (cliente.Substring(index) == "@yahoo.com" || cliente.Substring(index) == "@yahoo.com.br")
            {
                SMTP = new SmtpClient("smtp.mail.yahoo.com", 465); // cria protocolo SMTP, informando o host(no caso O Gmail e a porta de envio dele. tais informações são retiradas do provedor de email

                SMTP.EnableSsl = true; //Conexão encriptografada.
                SMTP.Timeout = 10000; //tempo de tentativa de envio.
                SMTP.DeliveryMethod = SmtpDeliveryMethod.Network; //qual será o método de entrega do email? Internet
                SMTP.UseDefaultCredentials = false; //
                SMTP.Credentials = new NetworkCredential(cliente, senha);
            }
            else if (cliente.Substring(index) == "@mafrainformatica.com" || cliente.Substring(index) == "@mafrainformatica.com.br")
            {
                SMTP = new SmtpClient("mail.mafrainformatica.com.br", 587); // cria protocolo SMTP, informando o host(no caso O Gmail e a porta de envio dele. tais informações são retiradas do provedor de email

                SMTP.EnableSsl = false; //Conexão encriptografada.
                SMTP.Timeout = 10000; //tempo de tentativa de envio.
                SMTP.DeliveryMethod = SmtpDeliveryMethod.Network; //qual será o método de entrega do email? Internet
                SMTP.UseDefaultCredentials = false; //
                SMTP.Credentials = new NetworkCredential(cliente, senha);
            }

            try
            {   //Corpo do email
                MailMessage mail = new MailMessage(cliente, dest);
                mail.Subject = titulo;
                mail.IsBodyHtml = true;
                mail.Body = msg;

                //Setting img
                string img;
                if (File.Exists("DataFooter"))
                {
                    using (StreamReader filefooter = new StreamReader("DataFooter"))
                    {
                        string[] splt = Encription.Decription(filefooter.ReadLine()).Split('\\');
                        img = splt.LastOrDefault();
                        filefooter.Close();
                    }
                    if (!String.IsNullOrEmpty(img))
                    {
                        LinkedResource footerImg = new LinkedResource(img, "image/jpeg");
                        footerImg.ContentId = "companyLogo";
                        AlternateView foot = AlternateView.CreateAlternateViewFromString(msg + "<p> <img src=cid:companyLogo /> </p>", null, "text/html");
                        foot.LinkedResources.Add(footerImg);
                        mail.AlternateViews.Add(foot);
                    }
                }
                //Definindo anexos
                Attachment file = new Attachment(Program.PDFNomefile, MediaTypeNames.Application.Pdf);
                Attachment file2 = new Attachment(Program.PDFQuantFile, MediaTypeNames.Application.Pdf);
                mail.Attachments.Add(file);
                mail.Attachments.Add(file2);
                mail.BodyEncoding = UTF8Encoding.UTF8;
                Console.WriteLine("\nEnviando email....");

                SMTP.Send(mail);

            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
                return;
            }

            DateTime TempoRecebe = DateTime.Now;
            Console.Write("Email enviado com sucesso. " + TempoRecebe);
        }
    }
}
