using BuildSchoolBizApp.Services;
using BuildSchoolBizApp.ViewModels;
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
    public partial class AddSalesManForm : Form
    {
        public AddSalesManForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("業務員姓名不可空白");
            }
            else
            {
                var name = textBox1.Text.Trim();
                var service = new SalesManService();
                var viewModel = new SalesManViewModel()
                {
                    Name = textBox1.Text.Trim(),
                };
                if(service.IsNameExist(viewModel))
                {
                    MessageBox.Show("業務員已經存在資料庫");
                    return;
                }
                var result = service.Create(viewModel);
                if(result.IsSuccessful)
                {
                    MessageBox.Show("業務員加入成功");
                }
                else
                {
                    var path = result.WriteLog();
                    MessageBox.Show($"發生錯誤，請參考{path}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
