using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal money;
            decimal A = 540000m * 0.05m;
            decimal B=  670000m * 0.12m;
            decimal C = 1210000m * 0.20m;
            decimal D = 2110000m*0.30m;
            decimal E = 5780000m*0.40m;
            int level=0;
            do
            {
                decimal result=0;
                Console.WriteLine("輸入金額");
                money = decimal.Parse(Console.ReadLine());

                if (money >= 10310001m)
                    level = 5;
                else if (money <= 10310000m && money >= 4530001m)
                    level = 4;
                else if (money <= 4530000m && money >= 2420001m)
                    level = 3;
                else if (money <= 2420000m && money >= 1210001m)
                    level = 2;
                else if (money <= 1210000m && money >= 540001m)
                    level = 1;
                else if (money <= 540000m && money >= 0)
                    level = 0;

                switch (level)
                {
                    case 0:
                        {                            
                            result = money * 0.05m;
                            Console.WriteLine(result);
                            break;
                        }
                    case 1:
                        {
                            result = A + (money - 540000m) * 0.12m;
                            Console.WriteLine(result);
                            break;
                        }
                    case 2:
                        {
                            result = A + B + (money - 1210000m) * 0.20m;
                            Console.WriteLine(result);
                            break;
                        }
                    case 3:
                        {
                            result = A + B + C + (money - 2420000m) * 0.30m;
                            Console.WriteLine(result);
                            break;
                        }
                    case 4:
                        {
                            result = A + B + C + D + (money - 4530000m) * 0.40m;
                            Console.WriteLine(result);
                            break;
                        }
                    case 5:
                        {
                            result = A + B + C + D + E + (money - 10310000m) * 0.50m;
                            Console.WriteLine(result);
                            break;
                        }


                }
                Console.WriteLine("-----------------------");
            }while (money<88888888888888888888888888m);
        }
    }
}
