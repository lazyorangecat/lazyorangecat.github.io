using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_NumberTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入1~9其中一個數字作為層數");
            int input = int.Parse(Console.ReadLine());

            for (int row = input; row >= 1; row--)
            {
                for (int counter = 1; counter <= input - row; counter++)
                {
                    Console.Write(" ");
                }

                for (int counter = 1; counter <=row ; counter++)
                {
                    Console.Write($"{row}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
