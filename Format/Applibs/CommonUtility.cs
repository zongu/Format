using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace Format.Applibs
{
    public class CommonUtility
    {
        /// <summary>
        /// 發 Emaiil。
        /// </summary>
        /// <param name="subject">主旨</param>
        /// <param name="body">內容</param>        
        public static void SendEmail(string subject, string body)
        {            
            try
            {
                string smtpHost = Webconfig.Smtp.Split(';')[0];
                string smtpAcc = Webconfig.Smtp.Split(';')[1];
                string smtpPwd = Webconfig.Smtp.Split(';')[2];
                string[] SysMail = Webconfig.SysMail.Split(';');

                foreach(string mail in SysMail)
                {
                    MailMessage objMsg = new MailMessage(smtpAcc, mail);
                    objMsg.Subject = subject;
                    objMsg.Body = body;
                    objMsg.IsBodyHtml = true;
                    SmtpClient client = new SmtpClient(smtpHost, 25);
                    client.Credentials = new System.Net.NetworkCredential(smtpAcc, smtpPwd);
                    client.Send(objMsg);
                }                
            }
            catch (Exception ex)
            {
            }
        }
    }
}