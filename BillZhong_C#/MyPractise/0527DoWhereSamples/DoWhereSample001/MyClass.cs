using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhereSample001
{
    internal static class MyClass
    {
        public static IEnumerable<T> DoWhere<T>(this IEnumerable<T> source, IPredicate<T> predicate)
        {
            //List<T> result = new List<T>();
            foreach (var item in source)
            {
                if (predicate.Invoke(item))
                {
                    //result.Add(item);
                    yield return item;
                }
            }
            //return result;
        }
        public class SearchDavid : IPredicate<string>
        {
            public bool Invoke(string x)
            {
                return x == "David";
            }
        }
        public class SearchMoreThen : IPredicate<int>
        {
            public bool Invoke(int x)
            {
                return x > 3;
            }
        }
    }
}
