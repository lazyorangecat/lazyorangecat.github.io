using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("輸入一串以逗號分隔的整數:");
            //string input=Console.ReadLine();
            //char cut = ',';

            //for(int i=input.Length-1; i>=0; i--)
            //{
            //    input.Split(',');
            //    Console.Write(input[i]+',');
            //}
            //Console.ReadLine();

            Console.WriteLine("輸入一串以逗號分隔的整數:");
            string input = Console.ReadLine();
            string[] stringArray = input.Split(',');
            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                
                if(i!=stringArray.Length-1)
                {
                    Console.Write(',');
                }
                Console.Write(stringArray[i]);
            }
            //解二
            Console.ReadLine();
            //string output = string.Empty;
            //for (int i = stringArray.Length - 1; i >= 0; i--)
            //{
            //    if (i != stringArray.Length - 1)
            //    {
            //        output += ',';
            //    }
            //    output += stringArray;
            //}
            //Console.Write(output);
            ////解三
            //Array.Reverse(stringArray);

        }
    }
}
