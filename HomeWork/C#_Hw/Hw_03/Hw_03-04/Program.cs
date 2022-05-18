using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var ans = "";
            //一.無腦
            ans = input
                .Replace('0', '零')
                .Replace('1', '一')
                //.....
                .Replace('9', '九');
            Console.WriteLine(ans);

            //二.迴圈
            List<string> zhTW_Number = new List<string>
            {
                "零","一","二","三","四","五","六","七","八","九",
            };
            var ans2 = input;
            for (int i = 0;i<10;i++)//效能為10*字串長
            {
                ans2 = ans2.Replace(i.ToString(),zhTW_Number[i]);
            }
            Console.WriteLine(ans2);
            
            
            //三.Linq字元逐一處理
            var ans3=input.Select(c=>
            zhTW_Number[c - '0']                             //優點: 跨語言
            //zhTW_Number[int.Parse(c.ToString())]          //缺點:得先轉成字串
            //zhTW_Number[(int)char.GetNumericValue(c)]      //優點: 易讀
            );


            Console.ReadLine();
        }
    }
}
