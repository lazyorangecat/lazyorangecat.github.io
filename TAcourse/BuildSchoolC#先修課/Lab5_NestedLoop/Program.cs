using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_NestedLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //第幾"列"
            for (int row = 1; row <= 3; row++)
            {
                //符號印幾"次"
                for (int counter = 1; counter <= 5; counter++)
                {
                    //連續印出符號，【不換行】
                    Console.Write("O");
                }
                //每列結束要換行
                Console.WriteLine();
            }

            int width = 5;//int.Parse(Console.ReadLine());

            for (int row = 1; row <= width; row++)
            {
                //印空白區
                for (int counter = 1; counter <= width - (row); counter++)
                {
                    Console.Write("ˋ");
                }

                //印實體區
                for (int counter = 1; counter <= row; counter++)
                {
                    Console.Write("O");
                }

                //列的結束要換行
                Console.WriteLine();
            }






            Console.ReadLine();
        }
    }
}
