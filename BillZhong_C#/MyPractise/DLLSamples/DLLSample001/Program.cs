﻿using My_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLSample001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyRectangle rect = new MyRectangle();
            rect.Width = 10;
            rect.Height = 10;
            Console.WriteLine($"面積為:{rect.GetArea()}");
        }
    }
}
