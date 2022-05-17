using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSamples001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape rect = new MyRectangle() { Width = 10, Height = 10 };
            Display(rect);
            IShape circle = new MyCircle() { Radius = 3 };
            Display(circle);
            Console.ReadLine();

        }

        private static void Display(IShape shape)
        {
            Console.WriteLine($"這個形狀的面積是{shape.GetArea()}");
        }
    }
}
