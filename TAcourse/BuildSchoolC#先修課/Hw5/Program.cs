using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("輸入一個整數");
            int width = int.Parse(Console.ReadLine());

            for (int row = 1; row <= width; row++)
            {
                for (int counter = 0; counter <= width - row; counter++)
                {
                    Console.Write("X");
                }

                for (int counter = 1; counter <= row; counter++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            for (int row = 1; row <= width; row++)
            {
                for (int counter = 1; counter <= row; counter++)
                {
                    Console.Write(" ");
                }

                for (int counter = 0; counter <= width - row; counter++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }

            for (int row = 1; row <= width; row++)
            {
                for (int counter = 1; counter <= width - row; counter++)
                {
                    Console.Write(" ");
                }

                for (int counter = 1; counter <= row; counter++)
                {
                    Console.Write("X");
                }

                Console.WriteLine();
            }

            for (int row = 1; row <= width; row++)
            {
                for (int counter = 1; counter <= row; counter++)
                {
                    Console.Write("X");
                }

                for (int counter = 1; counter <= width - row; counter++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }


            Console.ReadLine();


            //2
            Console.WriteLine("輸入一個整數");
            int x = int.Parse(Console.ReadLine());

            for (int row = 1; row <= x; row++)
            {
                for (int counter = 1; counter <= x - row; counter++)
                {
                    Console.Write(" ");
                }

                for (int counter = 1; counter <= 2 * row - 1; counter++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //3
            Console.WriteLine("輸入一個整數");
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int counter = 0; counter <= n - row; counter++)
                {
                    Console.Write("X");
                }
                for (int counter = 1; counter <= 2 * row - 1; counter++)
                {
                    Console.Write("|");
                }
                for (int counter = 0; counter <= n - row; counter++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
            for (int row = 1; row <= n - 1; row++)
            {
                for (int counter = 0; counter <= row; counter++)
                {
                    Console.Write("X");
                }
                for (int counter = 2; counter <= (n - row) * 2; counter++)
                {
                    Console.Write("|");
                }
                for (int counter = 0; counter <= row; counter++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
            Console.ReadLine();


            //4
            Console.WriteLine("輸入一個整數");
            int y = int.Parse(Console.ReadLine());

            for (int row = 0; row < 5; row++)
            {

                for (int counter = -1; counter < row; counter++)
                {
                    Console.Write("X");
                }
                for (int counter = 1; counter < y - row; counter++)
                {
                    Console.Write("'");
                }

                for (int counter = 0; counter < y - row; counter++)
                {
                    Console.Write("X");
                }

                for (int counter = 0; counter < row; counter++)
                {
                    Console.Write("'");
                }
                Console.WriteLine();
            }
            for (int row = 0; row < 5; row++)
            {
                for (int counter = 1; counter < y - row; counter++)
                {
                    Console.Write("'");
                }
                for (int counter = -1; counter < row; counter++)
                {
                    Console.Write("X");
                }

                for (int counter = 0; counter < row; counter++)
                {
                    Console.Write("'");
                }


                for (int counter = 0; counter < y - row; counter++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();


            }
            Console.ReadLine();


            //5
            for (int i = 1; i < 10; i++)//從1開始跑,每輪跑完後+3(三組分別是1,4,7開頭)
            {
                for (int j = 1; j < 10; j++)//每輪從1開始跑,跑9次,這裡是要乘的1~9
                {
                    //以下以每一列為輸出單位
                    Console.Write($"{j}*{i}={i * j}\t");

                    //輸出每一列第一段，中間加入間隔\t(同tab鍵)排版,並規定輸出為2個字元空間方便對齊

                    //輸出每一列第三段並換行跑下一個j,並規定輸出為2個字元空間方便對齊
                }
                Console.WriteLine();//#字號為數字預留位置符號，注意不會輸出非有效位數的零
                //每完成一個i多換行一次,也就是跑完3,6,9換行(每一組)
            }
            Console.ReadKey();
        }
    }
}
