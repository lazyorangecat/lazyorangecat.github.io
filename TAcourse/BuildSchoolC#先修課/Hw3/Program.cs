using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入a的值：");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("請輸入b的值：");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"交換前，a={a},b={b}");
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"交換後，a={a},b={b}");
        }
    }
}
