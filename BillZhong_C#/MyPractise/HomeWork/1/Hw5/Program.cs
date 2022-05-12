using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入年分(民國年)");
            int year = 1911+int.Parse(Console.ReadLine());

            DateTime endDate = new DateTime(year, 12, 31);

            switch(endDate.DayOfYear)
            {
                case 365:
                    Console.WriteLine("不是閏年");
                    break;

                case 366:
                    Console.WriteLine("是閏年");
                    break ;
            }
            //解二
            bool judge = DateTime.IsLeapYear(year);

            if(judge)
                Console.WriteLine("不是閏年");
            else
                Console.WriteLine("是閏年");
        }
    }
}
