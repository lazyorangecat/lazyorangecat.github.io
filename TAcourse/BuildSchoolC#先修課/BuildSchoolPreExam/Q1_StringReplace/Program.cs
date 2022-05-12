using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_StringReplace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("金槍魚");
                    continue;
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine("螃蟹");
                    continue;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("章魚");
                    continue; ;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
