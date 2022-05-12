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
            Console.WriteLine("輸入一串以逗號分隔的整數:");
            string input = Console.ReadLine();

            Console.WriteLine(
                String.Join(",",
                input.Split(',')
                .Reverse()))
                ;

            string output = input.Split(',')
                .Aggregate((sum, x) => x + "," + sum);
            Console.WriteLine(output);
            
        }
    }
}
