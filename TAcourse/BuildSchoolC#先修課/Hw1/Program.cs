using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入新台幣數值：");
            string intputnumber = Console.ReadLine();
            double TW = int.Parse(intputnumber);
            double US = TW / 28;
            Console.WriteLine($"對應的美金價值為：" + US);
        }
    }
}
