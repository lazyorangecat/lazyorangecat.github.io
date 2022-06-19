using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_orderby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]
             {
                 1,2,3,4,99,88,77,66,55,44,22,11,33,888,666,999
             };
            var result = array.OrderBy(x => x, new numberComparer());
            Console.WriteLine(string.Join(",", result));


            Console.ReadLine();
        }


    }
    public class numberComparer : IComparer<int>
    {
        
        //private static readonly int[] numberOrder
        //    = new int[] { 1, 3, 11, 33, 55, 77, 99, 999, 2, 4, 22, 44, 66, 88, 666, 888 };
        public int Compare(int x, int y)
        {
            //先分奇偶再分大小
            int rx = x % 2;
            int ry = y % 2;
            if (ry==rx)
            {

                return ry-rx;
            }
            return ry-rx;


        }
    }
}
