using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayResult(true);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DisplayResult(false);

        }
        private void DisplayResult(bool isAdd)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox1.Text);
            if (!isAdd)
            {
                y = -y;
            }
            label1.Text= (x + y).ToString();
        }
    }
}
