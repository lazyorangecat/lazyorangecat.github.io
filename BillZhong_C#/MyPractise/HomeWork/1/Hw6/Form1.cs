using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw6
{
    public partial class Form1 : Form
    {
        private int[] _countArray;
        private Label[] _lableArray;
        
        public Form1()
        {
            InitializeComponent();
            button1.Text = "用迴圈算";
            button2.Text = "不用迴圈算";

            _countArray = new int[7];
            _lableArray = new Label[7]
            {
                label1,
                label2,
                label3,
                label4,
                label5,
                label6,
                label7,
            };
        }
       

        private void DisplayResult()
        {
            
            for(int i = 0; i < _lableArray.Length; i++)
            {
                _lableArray[i].Text =_countArray[i].ToString();
            }
            
        }

        private void CalculateByLoop(object sender, EventArgs e)
        {
            int year = int.Parse(textBox_year.Text);
            var date = new DateTime(year, 1,1);

            //遍歷今年每一天
            while(date.Year == year)
            {
                //檢查天是星期幾
                DayOfWeek dayOfWeek= date.DayOfWeek;
                
                //增加對應的計數器
                _countArray[(int)dayOfWeek]++;

                //改變判斷目標
                date = date.AddDays(1);
            }
            DisplayResult();

        }

        private void CalculateByAlgorithm(object sender, EventArgs e)
        {
            int year = int.Parse(textBox_year.Text);
            
            //初始化計數器
            for(int i=0;i<_countArray.Length;i++)
            {
                _countArray[i] = 52;
            }
            //_countArray = Enumerable.Repeat(52,7).ToArray();
            
            //無論如何1/1的周幾 一定會多一次
            var date1_1=new DateTime(year, 1, 1);
            _countArray[(int)date1_1.DayOfWeek]++;

            //若閏年1/2的周幾多一次
            if(DateTime.IsLeapYear(year))
            {
                var date1_2 = new DateTime(year, 1, 2);
                _countArray[(int)date1_2.DayOfWeek]++;
            }

            DisplayResult();
        }
    }
}
