using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("請輸入首項");
            int fir = int.Parse(Console.ReadLine());

            Console.WriteLine("請輸入公差");
            int dif = int.Parse(Console.ReadLine());

            int ans = fir;
            Console.WriteLine("等差數列前7項");
            for (int i = 1; i < 8; i++)
            {

                Console.WriteLine(ans);
                ans += dif;
            }


            Console.ReadLine();

            //2
            Console.WriteLine("請輸入首項");
            int fir2 = int.Parse(Console.ReadLine());

            Console.WriteLine("請輸入公比");
            int dif2 = int.Parse(Console.ReadLine());

            int ans2 = fir2;
            for (int i = 1; i < 8; i++)
            {
                Console.Write($"{ans2},");
                ans2 *= dif2;
            }
            

            Console.ReadLine();

            //3
            Console.WriteLine("買的可樂瓶數");
            int buy = int.Parse(Console.ReadLine());
            int bottel = buy;
            while (bottel >= 3)
            {
                int total = bottel / 3;
                int recode = bottel % 3;
                buy += total;
                bottel = total + recode;

            }
            Console.WriteLine($"實際能喝到的可樂瓶數{buy}");


            Console.ReadLine();
        }
    }
}
