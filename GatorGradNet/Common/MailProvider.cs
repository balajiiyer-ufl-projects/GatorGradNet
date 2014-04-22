using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class MailProvider
    {
        #region Private Members
        private static MailProvider instance = new MailProvider();

        #endregion
        

        #region Public Methods
        public static MailProvider Instance()
        {
            return instance;
        }


        public void MailSend(int verificationcode, string ToAddress,string firstName)
        {
            using (MailMessage mailMessage = new MailMessage())
            {
                mailMessage.From = new MailAddress(Constants.FROM_ADDRESS);
                mailMessage.Subject = "GatorGardNet: Verify your email address";

                mailMessage.Body = "Hello " + firstName+"! <p><a href=http://gatorgradnet.com/Verificationpage.aspx?code=" + verificationcode+">Click here to verify your email Id</a></p><br>Sincerely,</br><br>The GatorGradNet team</br>";
                //mailMessage.Body = "http://server address/Verificationpage.aspx?code=" + verificationcode;
                mailMessage.IsBodyHtml = true;
                mailMessage.To.Add(new MailAddress(ToAddress));


                SmtpClient smtp = new SmtpClient();
                smtp.Host = Constants.HOST;
                smtp.EnableSsl = true;
                System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();
                NetworkCred.UserName = mailMessage.From.Address;
                NetworkCred.Password = Constants.PASSWORD;
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = Constants.PORT;
                smtp.Send(mailMessage);
            }
        }
        public void MailSend(int verificationcode, string ToAddress,string subject, string firstName)
        {
            using (MailMessage mailMessage = new MailMessage())
            {
                
                mailMessage.From = new MailAddress(Constants.FROM_ADDRESS);
                mailMessage.Subject = subject;

                mailMessage.Body = "Hello " + firstName + "! <p> Your new password is "+ verificationcode+" </p><br>Sincerely,</br><br>The GatorGradNet team</br>";
                //mailMessage.Body = "http://server address/Verificationpage.aspx?code=" + verificationcode;
                mailMessage.IsBodyHtml = true;
                mailMessage.To.Add(new MailAddress(ToAddress));


                SmtpClient smtp = new SmtpClient();
                smtp.Host = Constants.HOST;
                smtp.EnableSsl = true;
                System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();
                NetworkCred.UserName = mailMessage.From.Address;
                NetworkCred.Password = Constants.PASSWORD;
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = Constants.PORT;
                smtp.Send(mailMessage);
            }
        }


        public void MailSend(string ToAddress, string subject,string )
        {
            using (MailMessage mailMessage = new MailMessage())
            {

                mailMessage.From = new MailAddress(Constants.FROM_ADDRESS);
                mailMessage.Subject = subject;

                //mailMessage.Body = "Hello " + firstName + "! <p> Your new password is " + verificationcode + " </p><br>Sincerely,</br><br>The GatorGradNet team</br>";
                //mailMessage.Body = "http://server address/Verificationpage.aspx?code=" + verificationcode;
                mailMessage.IsBodyHtml = true;
                mailMessage.To.Add(new MailAddress(ToAddress));


                SmtpClient smtp = new SmtpClient();
                smtp.Host = Constants.HOST;
                smtp.EnableSsl = true;
                System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();
                NetworkCred.UserName = mailMessage.From.Address;
                NetworkCred.Password = Constants.PASSWORD;
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = Constants.PORT;
                smtp.Send(mailMessage);
            }
        }


        #endregion
    }
}
