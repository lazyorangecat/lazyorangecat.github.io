using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("輸入一段文字");
            //string x = Console.ReadLine();
            
            //int i = 0;
            //int j = 0;
            //int yes = 0;



            ////for (int j = x.Length - 1; j > x.Length / 2; j--)
            ////{
            ////    Console.Write(x[j]);
            ////}
            //for (int k = 0; k < x.Length; k++)
            //{
            //    for (j = x.Length - 1 - k; j > x.Length - 2 - k; j--) //j = x.Length-2-k;
            //    {
            //        if (x[k] == x[j])
            //            yes++;
            //    }                
            //}
            //if (yes == x.Length)
            //    Console.WriteLine("是迴文");
            //else
            //    Console.WriteLine("不是迴文");

            string word= Console.ReadLine();
            bool isPalindrome =true;
            for (int i = 0; i < word.Length; i++)
            {
                if(word[0+i]!=word[word.Length-1]-i)
                {
                    isPalindrome = false;
                    break;
                }
            }
            if(isPalindrome)
                Console.WriteLine("是迴文");
            else
                Console.WriteLine("不是迴文");

            Console.ReadLine();


        }
    }
}
