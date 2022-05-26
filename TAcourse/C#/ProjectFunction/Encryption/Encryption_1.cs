using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    internal class Encryption
    {
        //明文plantext
        public static string SHA256(string plantext)
        {
            //long=>Int64
            //Int=>Int32
            //short=>Int16
            //byte 就像是Int8      一個位元組(Byte)=8位元(bit)
            byte[] source=plantext.Select(c=>(byte)c)
                .ToArray();

            byte[] entyted = new SHA256Cng().ComputeHash(source);

            string ciphertext = string.Concat(
                entyted.Select(x=>x.ToString("X2"))
                //格式化字串，X代表十六進位，2代表總共兩位
                );
            return ciphertext.ToUpper();//看要不要全大寫
            //return ciphertext;
        }
    }
}
