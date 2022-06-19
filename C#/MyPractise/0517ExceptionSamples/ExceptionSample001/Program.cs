using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionSample001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string s = "ABC";
                int i = int.Parse(s);
            }
            catch (Exception ex)
            {
                Console.WriteLine("發生例外");
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("執行了 finally 區塊");
            }
            Console.ReadLine();

        }
    }
}
