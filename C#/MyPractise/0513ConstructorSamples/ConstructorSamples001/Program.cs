using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSamples001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass o1 = new BaseClass();
            Display("o1", o1.X);

            BaseClass o2 = new BaseClass(99);
            Display("o2", o2.X);

            Class1 o3 = new Class1(55,77);
            Display("o3", o3.X,o3.K);


            Console.ReadLine();
        }
        static void Display(string name, int value)
        {
            Console.WriteLine($"{name}的X是{value}");
        }
        static void Display(string name, int v1, int v2)
        {
            Console.WriteLine($"{name}的X是{v1},K是{v2}");
        }
    }
    public class BaseClass
    {
        public int X { get; private set; }

        public BaseClass() : this(0)
        {
            //X = 0;
        }
        public BaseClass(int y)
        {
            X = y;
        }
    }
    public class Class1 : BaseClass
    {
        public int K { get; set; }
        public Class1(int x, int y) : base(y)
        {
            K = x;
        }
    }
}
