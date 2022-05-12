using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("輸入一串以逗號分隔的整數");
            //string one = "奇數:" ;
            //string two = "偶數:" ;
            //string input=Console.ReadLine();
            //char takeOut = ',';
            //string[] strintinput=input.Split(takeOut);
            
            //for(int i=0; i<strintinput.Length; i++)
            //{
            //    int number=int.Parse(strintinput[i]);
            //    if (number % 2 == 0)
            //    {
            //        two = two+strintinput[i]+',';
            //    }
            //    else
            //    {
            //        one = one+strintinput[i]+',';
            //    }
            //}
            //Console.WriteLine(one);
            //Console.WriteLine(two);
            //Console.ReadLine();

            //string input = Console.ReadLine();

            string input=Console.ReadLine();
            string[] numberStrArray = input.Split(',');
            //1.排序
            int[] numberArray = new int [numberStrArray.Length];
            for(int i = 0; i < numberStrArray.Length; i++)
            {
                numberArray[i] = int.Parse(numberStrArray[i]);
            }
            Array.Sort(numberArray);


            //2.拆奇偶數
            string oneNumbers=string.Empty;
            string twoNumbers=string.Empty;
            
            string target;
            foreach (int number in numberArray)
            {

                if (number % 2 == 0)
                {
                    if (twoNumbers == string.Empty)
                    {
                        twoNumbers += number;
                    }
                    else
                    {
                        twoNumbers += "," + number;

                    }
                    target = twoNumbers;
                }
                else
                {
                    if (oneNumbers == string.Empty)
                    {
                        oneNumbers += number;
                    }
                    else
                    {
                        oneNumbers += "," + number;

                    }
                }                
            }
            Console.WriteLine("奇數:"+oneNumbers);
            Console.WriteLine("偶數:"+twoNumbers);
            Console.ReadLine();

        }
               
    }
}
