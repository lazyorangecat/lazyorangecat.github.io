using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckIsRightTriangle(3, 4, 5);
            CheckIsRightTriangle(13, 5, 12);
            CheckIsRightTriangle(24, 25, 7);
            CheckIsRightTriangle(9, 40, 41);
            CheckIsRightTriangle(3, 3, 3);

            Console.ReadLine();
        }
        static void CheckIsRightTriangle(int a, int b, int c)
        {
            Console.Write($"{a},{ b },{ c }" );
            int temp = 0;
            while(c<a||c<b)//若c非最大
            {
                temp = a;
                a = b;
                b = c;
                c = temp;
            }
            bool result = (a * a + b * b == c * c);
            if (result)
                Console.WriteLine("可以組成直角三角形");
            else
                Console.WriteLine("無法組成直角三角形");
            
        }
    }
}
