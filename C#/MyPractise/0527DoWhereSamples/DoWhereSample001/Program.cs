using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DoWhereSample001.MyClass;

namespace DoWhereSample001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> source1 = new List<string> { "Bill", "John", "David", "Tom", "David" };
            //var obj = new MyClass();
            //轉入 List<string> source,Func<string,bool>
            //var result = obj.DoWhere(source, (x) => x == "David");
            //var result1 = source1.DoWhere( (x) => x == "David");
            var result1 = source1.DoWhere(new SearchDavid());

            Display(result1);
            //List<int> source2 = new List<int> { 1, 2, 3, 4, 5 };
            int[] source2 = new int[] { 1, 2, 3, 4, 5 };


            //var result2 = source2.DoWhere((x) => x > 3);
            var result2 = source2.DoWhere(new SearchMoreThen());

            Display(result2);

            //實際上是這樣
            //Func<string, bool> func = new Func<string, bool>(Search);
            //var result=obj,DoWhere(source,func);
            //顯示結果
            
            //擴充方法
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadLine();
        }

        static void Display<T>(IEnumerable<T> source)
        {
            foreach (var item in source)
                Console.WriteLine(item);
        }

    }
}
