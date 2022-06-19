using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一個整數:");
            int input=int.Parse(Console.ReadLine());
            
            if (input % 2 == 0)
                Console.WriteLine("偶數");
            else
                Console.WriteLine("奇數");

            //解二
            switch (input%2)
            {
                case 0:
                    Console.WriteLine("偶數");
                    break;
                case 1:
                    Console.WriteLine("奇數");
                    break ;
            }
            
            //解三
            Console.WriteLine(input%2==0?"偶數":"奇數");
            Console.ReadLine();
        }
    }
}
