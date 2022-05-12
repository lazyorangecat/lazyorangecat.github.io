using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindQuadrant(3.3, 4);
            FindQuadrant(-2, 4.4);
            FindQuadrant(-3.3, -5.5);
            FindQuadrant(2, -5);

            FindQuadrant(2, 0);
            FindQuadrant(0, -5);
            FindQuadrant(0, 0);

            Console.ReadLine();
        }
        static void FindQuadrant(double x, double y)
        {
            if (x > 0 && y > 0)
                Console.WriteLine($"({x},{y})屬於第一象限");
            else if (x < 0 && y > 0)
                Console.WriteLine($"({x},{y})屬於第二象限");
            else if (x < 0 && y < 0)
                Console.WriteLine($"({x},{y})屬於第三象限");
            else if (x > 0 && y < 0)
                Console.WriteLine($"({x},{y})屬於第四象限");
            else
                Console.WriteLine($"({x},{y})不屬於任何象限");

        }
    }
}
