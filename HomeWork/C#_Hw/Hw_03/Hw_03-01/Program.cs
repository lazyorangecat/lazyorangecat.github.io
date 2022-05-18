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

            
            //int ans1=0;            
            //int temp = 1;
            //int ans2=0;

            //while(ans2 != 1836311903)
            //{
                
            //    ans2 = ans1 + temp;
            //    ans1 = temp;
            //    temp = ans2;
            //    Console.WriteLine(ans2);
            //}
            //Console.ReadLine();

            int A = 0;
            int x = 1;
            while(x>0)
            {
                Console.WriteLine(x);
                x += A;
                A = x - A;
            }

            Console.ReadLine();
        }
    }
}
