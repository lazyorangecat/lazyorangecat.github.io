using BuildSchoolBizApp.Services;
using BuildSchoolBizApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildSchoolBizApp
{
    public partial class AddSellingForm : Form
    {
        public AddSellingForm()
        {
            InitializeComponent();
        }

        private void AddSellingForm_Load(object sender, EventArgs e)
        {
            BindProductListBox();
            BindSalesManListBox();
        }
        private void BindProductListBox()
        {
            var service = new ProductService();
            var data = service.GetProducts();
            listBox1.DataSource = data.ToList();
            listBox1.DisplayMember = "PartName";
            listBox1.ValueMember = "PartNo";
        }
        private void BindSalesManListBox()
        {
            var service = new SalesManService();
            var data = service.GetSalesMen();
            listBox2.DataSource = data.ToList();
            listBox2.DisplayMember = "Name";
            listBox2.ValueMember = "JobNumber";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var partNo = (string)listBox1.SelectedValue;
            var quantity = (int)numericUpDown1.Value;
            if (!CanSell(partNo, quantity))
            {
                MessageBox.Show("庫存不足");
                return;
            }
            var viewModel = new SellingViewModel
            {
                PartNo = partNo,
                SalesJobNumber = (int)listBox2.SelectedValue,
                Quantity = quantity,
                UnitPrice = (int)numericUpDown2.Value,
                SellingDay = dateTimePicker1.Value,
            };
            var service = new SellingService();
            var result = service.Create(viewModel);
            if (result.IsSuccessful)
            {
                MessageBox.Show("新增出貨資料成功");
            }
            else
            {
                var path = result.WriteLog();
                MessageBox.Show($"發生錯誤，請參考 {path}");
            }

        }

        private static bool CanSell(string partNo, int quantity)
        {
            var service = new ProcurementService();
            Debug.WriteLine(service.GetStock(partNo));
            return (service.GetStock(partNo) >= quantity);
        }

    }
}
