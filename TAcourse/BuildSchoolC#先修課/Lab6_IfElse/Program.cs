using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 95;
            if (score > 90)
            {
                Console.WriteLine("評價A");
            }
            else if (score > 80)
            {
                Console.WriteLine("評價B");
            }
            else if (score > 70)
            {
                Console.WriteLine("評價C");
            }

            Console.WriteLine("_______________");


            int n = 6;
            if (n % 2 == 0)
            {//偶數
                if (n % 5 == 0)
                {//10的倍數
                    Console.WriteLine($"{n}是10的倍數");
                }
                else
                {//偶數
                    Console.WriteLine($"{n}是偶數");
                }
            }
            else
            {
                Console.WriteLine($"{n}是奇數");
            }



            Console.ReadLine();
        }
    }
}
