﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualitySample002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 10;
            Console.WriteLine($"ReferenceEquals(i,i) is {object.ReferenceEquals(i, i)}");
            Console.WriteLine($"ReferenceEquals(i,j) is {object.ReferenceEquals(i, j)}");
            MyRectangle r1 = new MyRectangle { Width = 5, Height = 5 };
            MyRectangle r2 = new MyRectangle { Width = 5, Height = 5 };
            MyRectangle r3 = r2;
            Console.WriteLine($"ReferenceEquals(r1,r2) is {object.ReferenceEquals(r1, r2)}");
            Console.WriteLine($"ReferenceEquals(r2,r3) is {object.ReferenceEquals(r2, r3)}");
            Console.ReadLine();


        }

    }
}


