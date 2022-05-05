using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
    public partial class Form1 : Form
    {
        List<int> _ans;
        private int _min;
        private int _max;

        public Form1()
        {
            InitializeComponent();
            _ans= new List<int>();
            
            Restart();
            
            
        }

        private void Restart()
        {
            //Data資料
            ProduceAnswer();

            //UI介面
            SetButtons(true);
            txt_Input.t
        }

        private void SetButtons(bool isGaming)
        {
            bool isGaming;
            txt_Input.Enabled = isGaming;
            btn_Guess.Enabled = isGaming;

            btn_Peek.Enabled = isGaming;
        }

        private void ProduceAnswer()
        {
            _ans.Clear();
            Random rnd = new Random(); 

            //法一
            _ans =
                Enumerable.Range(_min, _max - _min + 1)     //不要有魔術字元
                .OrderBy(x => rnd.Next())
                .Take(4)
                .ToList();

            //法二        抽牌法
            //candidate=候選人
            List<int> candidate=Enumerable.Range(_min,_)







            int i;
            i = 0;
            Data[i] = rnd.Next(0, 9); //取得第一个随机数 (0至9之间)

            int y;
            while (i < 4)   //循环,取够4位为止
            {
                Data[i] = rnd.Next(0, 9);//取得下一位随机数
                for (y = 0; y < i; y++)// 循环判断
                {
                    if (Data[i] == Data[y])//如果以前取得的重复了,
                    {
                        i = i - 1;  //重新取随机数
                    }
                }
                i++; //不重复.取下一位
            }

        }

        private void watchAns_Click(object sender, EventArgs e)
        {
            string Ans=string.Empty;
            foreach (int i in Data)
            {
                Ans=Ans+i;                
            }
            MessageBox.Show(Ans);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            _ans.Clear();
            
        }

        private void btn_Guess_Click(object sender, EventArgs e)
        {
            string input = txt_Input.Text;

            //(一)防呆

            if(input.Length)

            //(二)計算nAnB
            int a=0,b=0;
            //先把猜測字串轉成四個整數，方便和_ans比對
            var guess = input.Select(c => c - '0').ToList();

            //法一、直觀寫法
            a = _ans.Count(n => _ans.IndexOf(n) == guess.IndexOf(n));

            b = _ans.Count(n => _ans.IndexOf(n) == guess.IndexOf(n) && guess.IndexOf(n)!=-1);
            //法二、利用【交集】
            //交集的長度==a+b
            var intersected = _ans.Intersect(guess);
            //a=上面的算法
            a = _ans.Count(n => _ans.IndexOf(n) == guess.IndexOf(n));
            b = intersected.Count() - a;

            //(三)更新UI
            txt.Input.Text = string.Empty;
            txt_Record.Text += $"{input}";
            
            //(四)檢查勝敗
            if(a==4)
            {
                MessageBox.Show("猜中了");
                SetButtons(false);
            }
        }
    }
}
