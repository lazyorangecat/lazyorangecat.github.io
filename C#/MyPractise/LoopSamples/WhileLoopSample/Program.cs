using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int i = 1;
            while (i < 11)
            {
                result++;
                i++;
            }
            Console.WriteLine($"家總結果:"+result);
        }
    }
}
