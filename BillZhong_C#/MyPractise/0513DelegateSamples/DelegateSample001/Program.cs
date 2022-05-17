using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample001
{
    public delegate void SomeAction(string message);
    internal class Program
    {
        static void ShowText(string msg)
        {
            Console.WriteLine($"ShowText{msg}");
        }
        static void ShowmMssage(string str)
        {
            Console.WriteLine($"ShowText{str}");
        }
        static void Main(string[] args)
        {
            SomeAction action1=new SomeAction(ShowText);
            action1 += ShowmMssage;

            SomeAction action2 = ShowText;
            action1.Invoke("第一個");

            action2("第二個");

            Console.ReadLine();
            

        }
    }

}
