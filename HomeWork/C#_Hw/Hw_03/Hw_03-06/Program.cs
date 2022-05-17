using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_03_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputInt;
            bool isInputInt;
            int ans=0;
            do
            {
                Console.WriteLine("請輸入一個大於1整數");
                inputInt = 0;
                isInputInt = int.TryParse(Console.ReadLine(), out inputInt);
            } while (isInputInt != true || inputInt <= 1);

            if(inputInt%2==1)
            {
                ans=-(inputInt-1)/2+inputInt;

            }
            else
            {
                ans = -(inputInt / 2);
            }
            Console.WriteLine(ans);

            Console.ReadLine();
        }
    }
}
