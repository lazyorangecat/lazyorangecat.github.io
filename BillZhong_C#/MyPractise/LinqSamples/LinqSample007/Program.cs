using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            var list = CreateList();

            var person1 = list.ElementAtOrDefault(index);


            if (person1 == null)
            {
                Console.WriteLine("查無此人");
            }
            else
            {
                Console.WriteLine($"找到索引為:{index}-{person1.Name}-{person1.Age}");
            }
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
