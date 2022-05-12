using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = new int[4] { 9, 4, 5, 3 };
            Console.WriteLine(numberArray);

            //Console.WriteLine(numberArray[2]);
            //numberArray[2] = 111;
            //Console.WriteLine(numberArray[2]);

            //for(int i = 0;i<numberArray.Length;i++)
            //{
            //    Console.WriteLine(numberArray[i]);
            //}

            //for(int i = 0; i<numberArray.Length;i++)
            //{
            //    numberArray[i] = int.Parse(Console.ReadLine());
            //}
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] % 2 == 0)
                    Console.Write("偶");
                else
                    Console.Write("奇");
            }

            Console.ReadLine();
        }
    }
}
