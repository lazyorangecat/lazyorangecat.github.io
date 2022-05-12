using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "好筆電")
            {
                Console.WriteLine($"你輸入了{input}，但我不想聽");
                input = Console.ReadLine();
            }
            Console.WriteLine("謝謝");
            Console.ReadLine();

            for (int i = 0; i < 7; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //用+ 做出乘法
            int num = 0;
            for (int counter = 1; counter <= 10; counter++)
            {
                num += 2;
            }
            Console.WriteLine($"2加十次，結果是{num}");

            //用+ 做出指數
            int num2 = 1;
            for (int counter = 1; counter <= 10; counter++)
            {
                num2 *= 2;
            }
            Console.WriteLine($"2乘十次，結果是{num2}");
            Console.ReadLine();
        }
    }
}
