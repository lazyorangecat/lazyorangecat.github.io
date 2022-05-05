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
            Console.WriteLine("輸入一串有意義的英文");
            string input = Console.ReadLine().ToLower();
            string[] inputArray= input.Split(' ');
            var groupbyWord = inputArray.GroupBy(x => x);

            foreach (var group in groupbyWord)
            {
                Console.WriteLine(String.Join("\n",$"{group.Key}:{group.Count()}"));
            }
            Console.ReadLine();

            
        }
    }
}
