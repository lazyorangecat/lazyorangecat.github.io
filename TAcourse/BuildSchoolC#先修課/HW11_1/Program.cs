using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CandyStore store_A = new CandyStore
            {
                Name ="Build店",
                Owner ="Dann",
                Canyies =new string[2] {"棒棒糖","軟糖"}
            };
            store_A.Display();
                        
            CandyStore store_B = new CandyStore();
            store_B.Name = "School店";
            store_B.Owner = "Jimmy";
            store_B.Canyies = new string[3] { "沙士糖","棒棒糖","軟糖"};
            store_B.Display();




            Console.ReadLine();
        }
        
    }
    
    public class CandyStore
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public string[] Canyies { get;set; }

        public void Display()
        {
            Console.WriteLine($"店名:{Name}");
            Console.WriteLine($"店長:{Owner}");
            Console.WriteLine($"糖果清單:");
            foreach(string candy in Canyies)
            {
                Console.WriteLine($"\t{ candy}");
            }
            Console.WriteLine("-------------------------------------------------");
            
        }
    }
        
        
}

