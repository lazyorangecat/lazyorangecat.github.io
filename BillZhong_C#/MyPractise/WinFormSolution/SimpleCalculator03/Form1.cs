using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator03
{
    public partial class Form1 : Form
    {
        private MyData _data;
        public Form1()
        {
            InitializeComponent();
            _data = new MyData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate(1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculate(2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Calculate(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculate(4);
        }

        private void Calculate(int abcd)
        {
            _data.X=int.Parse(textBox1.Text);
            _data.Y=int.Parse(textBox2.Text);
            switch(abcd)
            { 
                case 1:
                    {
                        label1.Text = _data.Add().ToString();
                        break;
                    }
                case 2:
                    {
                        label1.Text = _data.Less().ToString();
                        break ;
                    }
                case 3:
                    {
                        label1.Text = _data.Multiplication().ToString();
                        break;
                    }
                case 4:
                    {
                        
                        label1.Text = _data.Division().ToString();
                        break;
                        
                    }

                    
            }
                
            
        }

    }
}
