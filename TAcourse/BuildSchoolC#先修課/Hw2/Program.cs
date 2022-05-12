using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入整數的華氏溫度值：");
            string intputnumber = Console.ReadLine();
            double F = int.Parse(intputnumber);
            double C = (F - 32) * 5 / 9;
            Console.WriteLine("對應的攝氏溫度值為：" + C);
        }
    }
}
