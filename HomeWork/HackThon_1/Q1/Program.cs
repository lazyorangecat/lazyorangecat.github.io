using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max;
            do
            {

                Console.WriteLine("輸入大於90的整數");
                max = int.Parse(Console.ReadLine());                
                
            }while (max < 90);
            for (int i = 1; i <= max; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Dann");
                    continue;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("School");
                    continue;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Build");
                    continue; ;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
