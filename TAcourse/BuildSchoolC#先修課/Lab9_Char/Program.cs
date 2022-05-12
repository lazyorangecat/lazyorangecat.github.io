using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char[] charArray = new char[3] { 'q', 'w', 'e' };
            //char c=charArray[2];
            //c = "qwe"[2];



            string s = "This is Apple.";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write($"{s[i]}\n");
            }


            int j = 0;
            for (; j < s.Length - 1; j++)
            {
                if (s[j] == s[j + 1])
                {
                    Console.Write($"\"{s}\"含有{s[j]}的疊字\n");
                    break;
                }

            }

            if (j >= s.Length - 1)
                Console.Write($"\"{s}\"不含任何疊字\n");

            Console.ReadLine();
        }
    }
}
