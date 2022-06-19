using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();

            var person1 = list.SingleOrDefault(x => x.Name == "Tom");
            Console.WriteLine($"大於於35歲的人最後一個被找到的是:{person1.Name}");

            var person2 = list.Single(x => x.Name == "Bill");
            Console.WriteLine($"大於37歲的人最後一個被找到的是:{person2.Name}");
            Console.ReadLine();


        }
        static List<MyData> CreateList()
        {
            return new List<MyData>()
            {
                new MyData { Name = "Bill",Age =47  },
                new MyData { Name = "John",Age =37  },
                new MyData { Name = "Tom",Age =48  },
                new MyData { Name = "David",Age =36  },
                new MyData { Name = "Bill",Age =35  },

            };
        }
    }
}
