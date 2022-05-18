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
            //自己做
            //int inputInt;
            //bool isInputInt;
            //int ans=0;
            //do
            //{
            //    Console.WriteLine("請輸入一個大於1整數");
            //    inputInt = 0;
            //    isInputInt = int.TryParse(Console.ReadLine(), out inputInt);
            //} while (isInputInt != true || inputInt <= 1);

            //if(inputInt%2==1)
            //{
            //    ans=-(inputInt-1)/2+inputInt;

            //}
            //else
            //{
            //    ans = -(inputInt / 2);
            //}
            //Console.WriteLine(ans);

            //助教解

            int max = int.Parse(Console.ReadLine());

            //演算法 兩兩一組
            int pairs = max / 2;//整數除法 會算出完整有幾組
            int ansTA = -pairs;

            if (max % 2 != 0)
                ansTA += max;

            Console.WriteLine(ansTA);
            //暴力by Linq
            int ansTA2=Enumerable.Range(1,max)
                .Sum(x => x%2==0? -x:x);        //偶數為負 奇數為正
            Console.WriteLine(ansTA2);

            Console.ReadLine();
        }
    }
}
