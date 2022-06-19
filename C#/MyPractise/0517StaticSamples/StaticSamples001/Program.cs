using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticSamples001
{
    public static class Class1
    {
        private static int x = 100;
        public static void Execute()
        {
            Console.WriteLine($"This is {x}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Class1.Execute();
            Console.ReadLine();
        }
    }
}
