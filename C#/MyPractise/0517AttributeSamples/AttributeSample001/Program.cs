using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeSample001
{
    public class Class1
    {
        //[Obsolete("就說不要用這個方法")]

        [Obsolete("就說不要用這個方法"),]


        public void Execute()
        {
        }
        public void Begin()
        {
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 o = new Class1();
            o.Begin();
            o.Execute();

        }
    }
}
