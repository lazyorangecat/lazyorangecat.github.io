using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_03_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            int ans1=0;
            int ans2 = 0;
            int temp = 1;

            for (; ans2 != 1836311903;)
            {
                
                ans2 = ans1 + temp;
                ans1 = temp;
                temp = ans2;
                Console.WriteLine(ans2);
            }
            Console.ReadLine();
        }
    }
}
