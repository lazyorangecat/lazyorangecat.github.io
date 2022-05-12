using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1
            //Console.WriteLine("\\/\'\"\'\\/");
            //Console.ReadLine();


            ////2
            //Console.WriteLine("輸入一個整數");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("\\");
            //    }
            //    Console.WriteLine();
            //    for (int k = 0; k < n; k++)
            //    {
            //        Console.Write("/");
            //    }
            //    Console.WriteLine();

            //}
            //Console.ReadLine();


            //3
            Console.WriteLine("輸入一串數字");
            string s = Console.ReadLine();

            int count = 0;
            for (int num = 0; num <= 9; num++)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == num + 48)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"數字{num}出現{count}次");
                count = 0;

            }




            Console.ReadLine();
        }
    }
}
