using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA_Initialaze
{
    internal class Program
    {
        private int _a = 1;
        private string B { get; set; } = "88";
        static void Main(string[] args)
        {
            var temp = new Program();
            //物件初始設定式
            var obj = new Program() { B = "BBBBBBBBBBB", _a = 99 };

            //4.集合初始設定式
                //4.1.Array
                int[] intArr = { 1, 2, 3 };
                int[] intArr2 = new int[3]{ 1, 2, 3 }; 
                int[] intArr3 = new int[]{ 1, 2, 3 };

                //4.2.List
                List<int> list = new List<int>() { 1,2,3 };

            //4.3.Dictionary 可以有別種的Key去查Value
            Dictionary<string, DayOfWeek> dict = new Dictionary<string, DayOfWeek>()
            new Dictionary<string, DayOfWeek>() { { "一", DayOfWeek.Monday }, };
        }
    }
}
