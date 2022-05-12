using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一個整數");
            int max=int.Parse(Console.ReadLine());

            for(int row=max;row>0;row--)
            {
                for(int counter=0;counter<=max-row;counter++)
                {
                    Console.Write(row);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
