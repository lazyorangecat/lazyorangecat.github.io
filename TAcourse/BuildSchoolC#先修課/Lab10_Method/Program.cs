using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Program.Add(3, 5);

            double d = Program.Quotient(2.2, 3.2);

            Program.區分收入高低(80_0000);

            bool result = CheckIsPrime(70001);

            Console.ReadLine();
        }
        static bool CheckIsPrime(int number)
        {
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {//有整除就"非"質數
                    return false;
                }
            }
            //過關斬將，都沒被整除，那就"是"質數
            return true;
        }
        static void 區分收入高低(int yearIcncome)
        {
            if (yearIcncome > 70_0000)
            {
                Console.WriteLine("高收入");
                return;
            }
            Console.WriteLine("低收入");
        }
        static int Add(int left, int right)
        {
            return left + right;
        }
        static double Quotient(double left, double right)
        {
            return left / right;
        }
    }
}
