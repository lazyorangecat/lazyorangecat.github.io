using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            int i = 0;
            for (i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();


            //2
            Console.WriteLine("輸入兩個整數:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = 0;

            if (b > a)//把兩數比較大的數換到被除數
            {
                (a, b) = (b, a);//把兩個數互換
            }
            while (a % b != 0)//兩個數相除不為0,代表還能繼續除
            {
                c = a % b;//c為餘數
                a = b;//把除數變成被除數
                b = c;//把餘數變成除數
            }
            Console.WriteLine($"最大公因數是:{b}");
            Console.ReadLine();
            Convert.ToInt32(Console.ReadLine());
        }
    }
}
