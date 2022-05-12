using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_BreakAndContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1333 * 123 + 2;
            int divisor = 2;

            for (; divisor <= Math.Sqrt(num); divisor++)
            {
                if (num % divisor == 0)
                    break;
            }

            if (divisor < num)
                Console.WriteLine($"{num}非質數={divisor}*{num / divisor}");
            else
                Console.WriteLine(num + "是質數");

            Console.ReadLine();
        }
    }
}
