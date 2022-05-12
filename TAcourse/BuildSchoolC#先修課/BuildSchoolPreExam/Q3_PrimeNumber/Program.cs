using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 2; i <= 200; i++)
            {
                bool isPrime = true;
                int divisor = 0;
                for (divisor = 2; divisor <= i; divisor++)
                {
                    if (i % divisor == 0)
                    {
                        if (divisor == i)
                        {
                            Console.WriteLine(i);
                        }
                        else
                            break;
                    }

                }
                
            }
            Console.ReadLine();
        }
    }
}
