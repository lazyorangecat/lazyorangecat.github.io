using ExtensionSamples001.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionSamples001
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<string> source
                = new List<string> { "Bill", "John", "David", "Tom", "David" };



            var result = source.DoWhere((x) => x == "David");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


        }

    }
}

