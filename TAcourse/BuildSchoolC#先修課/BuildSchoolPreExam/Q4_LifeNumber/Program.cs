using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_LifeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入生日的西元年、月、日(YYYYMMDD");
            string s = Console.ReadLine();
            int total = 0;
            string totaltostring = null;
            int number = 0;            
            
            for (int i = 0; i < s.Length; i++)
            {
                total = total + (s[i]-48);
            }
            totaltostring += total;

            for (int i = 0;i < totaltostring.Length;i++)
            {
                number=number+(totaltostring[i]-48);
            }
            Console.WriteLine(number);

            Console.ReadLine();
        }
    }
}
