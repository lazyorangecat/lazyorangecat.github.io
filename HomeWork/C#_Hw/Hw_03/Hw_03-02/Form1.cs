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
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            displayResult();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            displayResult();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            displayResult();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            displayResult();

        }
        private void displayResult()
        {     
            var moneyresult = 30 * (int.Parse(textBox1.Text)) + 17 * (int.Parse(textBox2.Text)) + 15 * (int.Parse(textBox3.Text)) + 40 * (int.Parse(textBox4.Text));
            int one = moneyresult / 1000;
            int two = moneyresult % 1000/500;
            int three = moneyresult % 500/100;
            int four = moneyresult % 100 / 50;
            int five = moneyresult % 50 / 10;
            int six = moneyresult % 10 / 5;
            int seven = moneyresult % 5;
            result.Text = $"{one}張千鈔,\n{two}張五百鈔,\n{three}張百鈔,\n{four}個50硬幣,\n{five}個10硬幣,\n{six}個5硬幣,\n{seven}個1硬幣";
        }

    }
}
