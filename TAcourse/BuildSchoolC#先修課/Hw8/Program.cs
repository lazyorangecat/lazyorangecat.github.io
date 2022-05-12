using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            string[] work = new string[3] { "", "", "" };
            Console.WriteLine("輸入三段文字");

            for (int i = 0; i < work.Length; i++)
            {
                work[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("輸出:");
            for (int j = work.Length - 1; j >= 0; j--)
            {
                Console.WriteLine(work[j]);
            }

            Console.ReadLine();



            //2
            int[] input = new int[6] { 0, 0, 0, 0, 0, 0 };
            Console.WriteLine("輸入6個整數");

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("原本的順序:");
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{input[i]},");
            }
            Console.WriteLine("\n------");

            Console.Write("切牌後順序:");

            for (int i = 0; i < input.Length/2; i++)
            {
                for (int j = i; j < i + 1; j++)
                {
                    Console.Write($"{input[j]},");
                }
                for (int k = i + 3; k < i + 4; k++)
                {
                    Console.Write($"{input[k]},");
                }
            }
            Console.ReadLine();
        }
    }
}
