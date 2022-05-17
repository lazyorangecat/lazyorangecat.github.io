using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample002
{
    public delegate bool MyPredicate(string value);
    //static bool SearchDavid(string value)
    //{
    //    return (value == "David");
    //}
    public class MyClass
    {
        public List<string> DoWhere(List<string> source,Func<string,bool> predicate)
        {
            List<string> result = new List<string>();
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
        static bool SearchDavid(string value)
        {
            return (value == "David");
        }
        static void Main(string[] args)
        {
            List<string> source
                = new List<string> { "Bill", "John", "David", "Tom", "David" };
            MyClass obj = new MyClass();
            //MyPredicate predicate = SearchDavid;
            //var result = obj.DoWhere(source, predicate);

            //var result = obj.DoWhere(source,
            //                        delegate (string x) { return x == "David"; }
            //                        );

            //var result = obj.DoWhere(source,
            //                        (x)=> { return x == "David"; }
            //                        );

            var result = obj.DoWhere(source,
                                    x=>x == "David"
                                    );

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
