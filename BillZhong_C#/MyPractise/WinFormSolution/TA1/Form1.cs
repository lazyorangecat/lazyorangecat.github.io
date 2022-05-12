using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void DisplayResult (string op)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox1.Text);
            if (op == "+" || op == "-")
            {
                if (op == "-")
                    y = -y;
                label1.Text = (x+y).ToString();
            }
            else
            {
                if (op == "/")
                    y = 1 / y;
                label1.Text = (x * y).ToString();
            }
        }
    }
}
