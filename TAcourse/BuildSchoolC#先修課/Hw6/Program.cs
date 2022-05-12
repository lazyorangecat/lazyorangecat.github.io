using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("輸入考試分數:");
            int grade = int.Parse(Console.ReadLine());

            if (grade > 90)
            {
                Console.WriteLine("獎勵是：一頓西堤");
            }
            else if (grade > 70)
            {
                Console.WriteLine("獎勵是：一杯City Cafe");
            }
            else
            {
                Console.WriteLine("獎勵是：一頓暴打");
            }
            Console.ReadLine();


            //2
            Console.WriteLine("輸入你的原始考試分數:");
            int Ograde = int.Parse(Console.ReadLine());
            Console.WriteLine("你是原住民嗎:");
            bool aboriginal = bool.Parse(Console.ReadLine());
            Console.WriteLine("你有身心障礙嗎:");
            bool bodyless = bool.Parse(Console.ReadLine());

            if (aboriginal == true)
            {
                int midgrade = (int)(Ograde * 1.35);
                if (bodyless == true)
                {
                    int fingrade = (int)(midgrade * 1.22);
                    Console.WriteLine($"你的有效分數是：{fingrade}");
                }
                else
                {
                    Console.WriteLine($"你的有效分數是：{midgrade}");

                }
            }
            else
            {
                if (bodyless == true)
                {
                    int midgrade = (int)(Ograde * 1.22);
                    Console.WriteLine($"你的有效分數是：{midgrade}");
                }
                else
                {
                    Console.WriteLine($"你的有效分數是：{Ograde}");
                }
            }
            Console.ReadLine();


            //3
            Console.WriteLine("輸入身高:");
            double high = double.Parse(Console.ReadLine());

            Console.WriteLine("輸入年薪:");
            int salary = int.Parse(Console.ReadLine());

            Console.WriteLine("輸入職業:");
            string work = Console.ReadLine();

            //判斷
            bool isConsiderToMate = true;

            if (high < 180 || salary < 1000000)
            {
                isConsiderToMate=false;
            }
            else
            {
                if (work == "醫師" || work == "律師")
                {
                    isConsiderToMate= true;
                }
                else
                {
                    isConsiderToMate = false;
                }
            }
            if(isConsiderToMate)
                Console.WriteLine("結果：考慮");
            else
                Console.WriteLine("結果：不考慮");
            Console.ReadLine();
        }
    }
}
