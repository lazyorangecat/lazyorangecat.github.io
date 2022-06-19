using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();

            var person1 = list.SingleOrDefault(x => x.Name == "Tom");

            if(person1 == null)
            {
                Console.WriteLine("查無此人");
            }
            else
            {
                Console.WriteLine($"找到:{person1.Name}-{person1.Age}");
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
