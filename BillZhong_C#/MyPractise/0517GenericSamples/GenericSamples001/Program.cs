using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSamples001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1<int> o1 = new Class1<int>();
            string s1 =o1.Data.GetType().ToString();
            Display("o1.Data", s1);
            
            Class1<string> o2 = new Class1<string>();
            string s2=o2.Data.GetType().ToString();
            //沒有執行個體怎麼執行個體成員
            Display("o2.Data", s2);
            Console.ReadLine();
        }

        private static void Display(string varName, string typeString)
        {
            Console.WriteLine($"{varName}的型別是{ typeString}");
            
        }
    }
    public class Class1<T>
    {
        public T Data { get; set; }
    }
}
