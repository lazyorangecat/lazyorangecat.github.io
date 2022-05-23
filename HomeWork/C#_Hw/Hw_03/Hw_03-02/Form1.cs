using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw_03_02
{
    public partial class Form1 : Form
    {
        List<FoodOrder> _foodOrders;
        List<int> _monetList;
        public Form1()
        {
            InitializeComponent();
            _foodOrders = new List<FoodOrder>
            {
                new FoodOrder(lbl_name1,lbl_price1,numericUpDown1),
                new FoodOrder(lbl_name2,lbl_price2,numericUpDown2),
                new FoodOrder(lbl_name3,lbl_price3,numericUpDown3),
                new FoodOrder(lbl_name4,lbl_price4,numericUpDown4),

            };
            _monetList = new List<int>
            { 1000,500,100,50,10,5,1};
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int total = _foodOrders.Sum(f => f.GetSubTotal());
            result.Text = $"總價:{total}元";

            //安排幣值
            ArrangePayment(total);

        }

        private void ArrangePayment(int total)
        {
            var infoList = _monetList
                .Select(money =>
                {
                    int count;
                    return $"\n{ money}元: {count }份";
                });
        }
    }
}
