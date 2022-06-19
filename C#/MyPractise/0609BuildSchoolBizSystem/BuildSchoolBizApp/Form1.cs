using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildSchoolBizApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowSubForm(new AddProductForm());
            //var form =new AddProductForm();
            //form.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ShowSubForm(new AddSalesManForm());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ShowSubForm(new AddProcurementForm());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ShowSubForm(new AddSellingForm());
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ShowSubForm(new QuerySellingBySalesForm());
        }
        private void button6_Click(object sender, EventArgs e)
        {
            ShowSubForm(new QueryStockForm());
        }
        private void ShowSubForm(Form form)
        {
            form.ShowDialog();
        }

    }
}
