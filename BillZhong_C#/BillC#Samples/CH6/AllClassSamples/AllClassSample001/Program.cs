using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClassSample001
{
    class Program
    {
        const int x = 10;
        static void Main(string[] args)
        {
            MyShape rect = new MyRectangle() { Width = 10, Height = 10 };
             Console.WriteLine($"方形的面積是 {rect.GetArea()}");
            Display(rect);
            MyShape circle = new MyCircle() { Radius = 3 };
            // Console.WriteLine($"圓形的面積是 {circle.GetArea()}");
            Display(circle);
            Console.ReadLine();
            //這樣寫是不行的，因為 MyShape 是抽象類別
            //MyShape shape = new MyShape();



            List<MyShape> shapes = new List<MyShape>
            {
                new MyRectangle() { Width = 10, Height = 10 },
                new MyCircle() { Radius = 3 },
                new MyCircle() { Radius = 5 },
                new MyRectangle() { Width = 10, Height = 11 },
                new MyRectangle() { Width = 10, Height = 12 },
                new MyCircle() { Radius = 8 }
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetArea());
            }

            shapes.ForEach(x => Console.WriteLine(x.GetArea())); 

        }

        static void Display(MyShape shape)
        {
            Console.WriteLine($"這個形狀的面積是 {shape.GetArea()}");
        }
    }
}
