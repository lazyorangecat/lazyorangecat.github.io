﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadThenDisplay
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            string input;
            Console.WriteLine("請輸入文字");
            input=Console.ReadLine();
            Console.Write("你輸入的文字是");
            Console.WriteLine(input);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
