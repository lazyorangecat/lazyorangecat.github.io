﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample006
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> {"A","B","C","D","E","F","F"};
            var resultOfSkip = list.Skip(3);
            Console.WriteLine("Skip(3) 的結果 ");
            Display(resultOfSkip);

            var resultOfTake = list.Take(3);
            Console.WriteLine("Take(3) 的結果 ");
            Display(resultOfTake);

            var resultOfSkipTake = list.Skip(2).Take(2);
            Console.WriteLine("Skip(2).Take(2) 的結果 ");
            Display(resultOfSkipTake);

            Console.ReadLine();
        }

        static void Display(IEnumerable <string> source)
        {
            foreach (var item in source)
            {
                Console.WriteLine(item);
            }
        }
    }
}
