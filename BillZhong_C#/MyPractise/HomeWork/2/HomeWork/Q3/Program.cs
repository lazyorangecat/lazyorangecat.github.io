using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            var splited = input.Split(',');

            var groups = splited
                .Select(str => int.Parse(str))
                .OrderBy(num => num)
                .GroupBy(num => num % 2);

            foreach(var g in groups)
            {
                Console.WriteLine($"組名:{g.Key}");
                Console.Write("\t成員:");
                //foreach(var item in g)
                //{
                //    Console.Write(item+",");
                //}                                       等同下一句
                Console.WriteLine(string.Join(",",g));
            }
        }
    }
}
