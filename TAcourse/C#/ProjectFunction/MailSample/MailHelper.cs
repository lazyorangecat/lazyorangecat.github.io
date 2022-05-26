using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MailSample
{
    internal class MailHelper
    {
        internal static void SendMail(List<string> recipientList, string subject, string body)
        {
            string SenderAccount = "bsfakemailkuo@gmail.com";
            string Password = "612148iluh";                             //!!!!!!!!!!!!!!!!

            //設兩大區塊 服務 郵件  順序無所謂

            //服務 
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;//通訊阜
            //smtp通常是587
            //sqlserver通常是1433(通常不會亂改)
            //88:通常http
            //443

            //也可以用建構式多載
            //SmtpClient smtpClient = new SmtpClient("smtp.gmail.com",587);
            client.Credentials=new NetworkCredential(SenderAccount, Password);
            client.EnableSsl = true;



            //郵件
            MailMessage mail = new MailMessage();
            mail.From =new MailAddress(SenderAccount,"寄件人抬頭");//寄件人
            recipientList.ForEach(addr=>mail.To.Add(addr));

            mail.Priority = MailPriority.High;
            
            //主旨
            mail.Subject = subject;                                 
            mail.SubjectEncoding = Encoding.UTF8;       //有中文就需要

            //內文
            mail.Body=body;
            mail.BodyEncoding = Encoding.UTF8;          //有中文就需要   
            mail.IsBodyHtml = true;

            //附件
            //Attachment attachment = new Attachment(@"C:\fakepath\fake.txt");    //@ 是【逐字字串常值】,會使得反斜線無效果
            //mail.Attachments.Add(attachment);

            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                //這邊demo就印出來，專案我們自己決定
                Console.WriteLine(ex);
                Console.WriteLine(ex.Message);
                throw ex;
            }
            finally
            {
                //attachment.Dispose();
                mail.Dispose();
                client.Dispose();                
            }
        }
    }
}
