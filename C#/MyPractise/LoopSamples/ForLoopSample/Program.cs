using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            for(int i = 0; i < 11; i++)
            {
                result = result + i;
                //result+=i
            }
            Console.WriteLine($"家總結果{result}");
            Console.ReadLine();
        }
    }
}
