using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu order1 = new Menu();
            order1.Foods = new Food[2]
            {
                new Food{Name="便當",Price =70,Counter=4},
                new Food{Name="羹湯",Price =35, Counter=3},
            };

            Console.WriteLine(order1.GetTotalPrice(order1));
            Console.ReadLine();
        }
    }
    public class Menu
    {
        public Food[] Foods { get; set; }
        public int GetTotalPrice(Menu menu)
        {
            int result = 0;
            for (int i = 0; i <= Foods.Length - 1; i++)
            {
                result += Foods[i].CalculatesubTotal();
            }

            foreach (Food food in Foods)
            {
                result += food.CalculatesubTotal();
            }
            return result;
        }
    }
    public class Food
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Counter { get; set; }
        public int CalculatesubTotal()
        {
            return Price * Counter;
        }

    }
}
