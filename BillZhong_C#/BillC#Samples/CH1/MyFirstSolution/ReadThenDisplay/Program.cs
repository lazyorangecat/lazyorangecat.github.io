﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ReadThenDisplay
{
    
    class Program
    {
       
        static void Main(string[] args)
        {           
            //string input;
            Console.WriteLine("請輸入文字 :");
            string input = Console.ReadLine();
            Console.Write("你輸入的文字是 : ");
            Console.WriteLine(input);
            Console.ReadLine();

        }


    }
}
