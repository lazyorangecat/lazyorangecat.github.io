﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int condition = 15;
            for(int i = 0; i < 3;i++)
            {
                Console.WriteLine("i="+i);
                for (int j = 14; j < 18; j++)
                {
                    if (j == condition)
                    {
                        break;
                    }
                    Console.WriteLine("j=" + j);
                }                
            }
            Console.ReadLine();
        }
    }
}
