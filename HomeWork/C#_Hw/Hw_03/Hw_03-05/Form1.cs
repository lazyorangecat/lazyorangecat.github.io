using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw_03_05
{
    public partial class Form1 : Form
    {
        //規劃
        //起站 永遠是全滿的
        //迄站 隨 方向，選定的起站 變化

        //depart arrive
        //from to
        //go to
        List<string> _fromStation;
        List<string> _toStation;
        List<List<int>> _ticketPriceTable;
        public Form1()
        {
            InitializeComponent();

            _fromStation = new List<string>
            {
                "台北","新竹","台中","嘉義","台南","高雄"
            };
            _ticketPriceTable = new List<List<int>>
            {
                new List<int>{0},
                new List<int>{177,},
                new List<int>{375, 197 ,},
                new List<int>{598, 421 ,224 ,},
                new List<int>{738, 560 ,363 ,139},
                new List<int>{842, 755 ,469,245 ,106},
            };
            //預選一個方向後才刷新combox
            radioBtn_N2S.Checked = true;
            combox_from.DataSource = _fromStation;
            //迄站...等啟戰改變後再隨之改變
        }

        private void comboBox_from_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeToStations();
        }
        
        private void radioBtn_N2S_CheckedChanged(object sender, EventArgs e)
        {
            ChangeToStations();
        }

        private void ChangeToStations()
        {
            //要相應地 改變迄站資料列表
            int idx = combox_from.SelectedIndex;
            //選了北到南
            if (radioBtn_N2S.Checked)
                _toStation = _fromStation.Skip(idx + 1).ToList();
            else
                _toStation = _fromStation.Take(idx+1 ).ToList();
            //迄站UI綁迄站列表資料
            combox_to.DataSource = _toStation;

            //預設沒選兩種都行
            //combox_to.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //防呆
            if(combox_from.SelectedIndex==-1||combox_to.SelectedIndex==-1)
            {
                lbl_price.Text = "無法計算";
                return;
            }
            //拿combobox選重的索引值 去查 原價
            int fromIndex=combox_from.SelectedIndex;
            int toIndex = combox_to.SelectedIndex+
                (radioBtn_N2S.Checked? fromIndex +1: 0);

            //table[大][小]
            //      [靠南][靠北]
            decimal price=radioBtn_N2S.Checked?
                _ticketPriceTable[toIndex][fromIndex]://南下，終點較南
                _ticketPriceTable[fromIndex][toIndex];//北上，起點較南

            //折扣
            if (ckBox_2Direction.Checked) price = price * 9 / 5;
            if (ckBox_discount.Checked) price = price * 9 / 10;

            lbl_price.Text = Math.Ceiling(price)+"元";


        }

    }
}
