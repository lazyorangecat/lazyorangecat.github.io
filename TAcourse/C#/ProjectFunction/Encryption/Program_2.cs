using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Encryption.SHA256("Demmo"));

            string pwd_註冊時 = "sdsdsds";
            string pwd_InDB=Encryption.SHA256(pwd_註冊時);//加密後才存進DB

            //登入    要比對
            //string pwd_Login = "和註冊田的不一樣";
            string pwd_Login = pwd_註冊時;
            Console.WriteLine("\n比對結果:");
            Console.WriteLine(Encryption.SHA256(pwd_Login)==pwd_InDB);
            Console.ReadLine();
        }
    }
}
