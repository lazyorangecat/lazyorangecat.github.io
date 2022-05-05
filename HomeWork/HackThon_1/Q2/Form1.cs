using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void InputTextBox(char num)
        {
            switch (num)
            {
               case '1': 
                    textBox1.Text+=1;
                        break;
               case '2': 
                    textBox1.Text +=2;
                        break;
               case '3': 
                    textBox1.Text +=3;
                        break;
               case '4': 
                    textBox1.Text +=4;
                        break;
               case '5': 
                    textBox1.Text +=5;
                        break;
               case '6': 
                    textBox1.Text +=6;
                        break;
               case '7': 
                    textBox1.Text +=7;
                        break;
               case '8': 
                    textBox1.Text +=8;
                        break;
               case '9': 
                    textBox1.Text +=9;
                        break;
               case '0': 
                    textBox1.Text +=0;
                        break;
               case '.':
                    if (textBox1.Text != "")
                    {
                        textBox1.Text += ".";
                        button11.Enabled = false;
                    }
                    else
                        MessageBox.Show("輸入錯誤");
                    break;
                case 'D':
                    {
                        textBox1.Clear();
                        break;
                    }
                case 'T':
                    {
                        int numArray = int.Parse(textBox1.Text);
                        if (radioButton1.Checked == false && radioButton2.Checked == false)
                            MessageBox.Show("請選擇一個轉換");
                        else
                        {
                            if (radioButton1.Checked == true)
                            {
                                double F = numArray;
                                double C = (F - 32) * 5 / 9;
                                label1.Text = ($"攝氏溫度:{C}℃");
                            }

                            else
                            {
                                double C = numArray;
                                double F = C * 9 / 5 + 35;
                                label1.Text = ($"攝氏溫度:{F}℉");
                            }                           
                        }
                        break;
                    }
                    

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputTextBox('1');
        }


        private void button2_Click(object sender, EventArgs e)
        {
            InputTextBox('2');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InputTextBox('3');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InputTextBox('4');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InputTextBox('5');
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InputTextBox('6');
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InputTextBox('7');
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InputTextBox('8');
        }

        private void button9_Click(object sender, EventArgs e)
        {
            InputTextBox('9');
        }

        private void button10_Click(object sender, EventArgs e)
        {
            InputTextBox('0');
        }

        private void button11_Click(object sender, EventArgs e)
        {            
            InputTextBox('.');            
        }


        private void button12_Click(object sender, EventArgs e)
        {
            InputTextBox('T');
        }
        private void button13_Click(object sender, EventArgs e)
        {
            InputTextBox('D');

        }
    }
}
