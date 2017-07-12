using System;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;

namespace Bloqueados_Auto
{
    static class Email
    {
        public static bool NetTest()
        {

            try
            {
                using (var cliente = new WebClient())
                {
                    using (var teste = cliente.OpenRead("http://www.google.com.br"))
                    {

                        return true;

                    }
                }
            }
            catch
            {

                return false;
            }

        } // Tesde simples de conexão à internet.

        public static bool Send(string cliente, string dest, string senha, string titulo, string msg) //recebe as informações para o email
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
            MailMessage mail = new MailMessage(cliente, dest, titulo, msg);
            mail.BodyEncoding = UTF8Encoding.UTF8;
            Console.WriteLine("\nEnviando email....");

            try
            {
                SMTP.Send(mail);
                return true;
            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
                return false;
            }
        }

        public static string UserAccountTest(string cliente, string senha)
        {
            int index = cliente.LastIndexOf('@'); // variavel para pegar contar todos os valores antes do @
            try
            {
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
                return "0";
            }
            catch (Exception e)
            {
                return "Falha na autenticação. Erro: " + e.Message;
            }
        }
    }
}
