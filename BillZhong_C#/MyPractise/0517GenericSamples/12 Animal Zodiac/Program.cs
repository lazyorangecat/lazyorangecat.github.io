using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Animal_Zodiac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array
                = new string []  { "龍", "鼠", "馬", "豬", "羊", "牛", "虎", "兔", "蛇", "猴", "雞", "狗" };
            var result=array.OrderBy(x => x,new ZodiacComparer());
            Console.WriteLine(string.Join(",", result));
            Console.ReadLine();
        }
    }
    public class ZodiacComparer : IComparer<string>
    {
        private static readonly string[] _zodiac = new string[]
        {"鼠","牛","虎","兔","龍","蛇","馬","羊","猴","雞","狗","豬" };
        public int Compare(string x, string y)
        {
            return Array.IndexOf(_zodiac, x)-Array.IndexOf(_zodiac, y);
            
        }
    }
}
