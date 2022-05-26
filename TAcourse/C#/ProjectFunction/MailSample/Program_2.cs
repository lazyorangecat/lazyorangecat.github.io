using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //收件者【們】
            List<string> recipientList = new List<string>
            {
                "b10710080@g.chu.edu.tw"
            };
            //信件主旨
            string subject = "註冊驗證信";

            //信件內容
            string body = "<h1>請點<a href='#'>連結</a>驗證</h1>";//注意引號

            SendMail(recipientList, subject, body);
        }

        private static void SendMail(List<string> recipientList, string subject, string body)
        {
            throw new NotImplementedException();
        }
    }
}
