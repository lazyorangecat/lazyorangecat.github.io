using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSample002
{
    public static class MyClass
    {
        public static List<T> DoWhere<T>(this List<T> source, Func<T, bool> predicate)
        {
            List<T> result = new List<T>();
            foreach (var item in source)
            {
                if (predicate.Invoke(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> source
            = new List<string> { "Bill", "John", "David", "Tom", "David" };
            var result = source.DoWhere<string>((x) => x == "David");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            //現在什麼型別都可以來一下了
            List<int> source2
            = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            var result2 = source2.DoWhere/*這邊是利用傳入的參數推斷泛型型別*/((x) => x > 3);
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
