﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopSample
{
   
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;            
            for (int i = 1; i < 11; i++)
            {
                result = result + i;
                // 也可以寫成
                // result +=i;
            }
          
            Console.WriteLine($"加總結果 : {result}");           
            Console.ReadLine();
            
        }
    }
}
