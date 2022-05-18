using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw_03_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double halfHours =
                (dateTimePicker2.Value - dateTimePicker1.Value)
                .TotalHours * 2;
            //.Hours        =>取整數,多出的時間捨去
            //.TotalHours   =>小數

            //防呆
            if(halfHours<0)
            {
                MessageBox.Show("先進後出啦");
                return;
            }

            //計費 的時長 (題目說 不滿八小時的不算)
            lbl_fee.Text = CalcTotalFee((int)halfHours) + "元";

        }

        //法二.物件+Linq
        private List<ChargeLevel> _chargeLevels =
            new List<ChargeLevel>
            {
                new ChargeLevel(){HalfHourLowerBound半小時下限=8,ChargeBate半小時費率 = 60},
                new ChargeLevel(4,40){ChargeBate半小時費率=40},
                new ChargeLevel(0,30),
            };
        private int CalcTotalFee2(int halfHours)
        {
            //有計費的級距
            var validlevels = _chargeLevels.Where(lv =>
                              halfHours > lv.HalfHourLowerBound半小時下限);
            //每個級距加總出費用
            return validlevels.Sum(lv =>
            {
                //屬於此級的時長(超出下限)
                var over = halfHours - lv.HalfHourLowerBound半小時下限;

                //非此級的時長(剩下的)
                halfHours = lv.ChargeBate半小時費率;

            });
        }


        //法一
        private string CalcTotalFee(int halfHours)
        {
            int total = 0;
            if(halfHours >8)//四小時
            {
                total+=(halfHours-8)*60;
                halfHours = 8;
            }
            if(halfHours >4)//二小時
            {
                total += (halfHours - 4) * 60;
                halfHours = 8;
            }
            if (halfHours > 4)//二小時
            {
                total += (halfHours - 4) * 60;
                halfHours = 8;
            }

        }
    }
}
