﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventSample001
{
    public partial class Form1 : Form
    {
        private MyCalss obj;
        public Form1()
        {
            InitializeComponent();
            obj = new MyCalss();
            obj.XChange += obj_XChanged;
            obj.XChange -= obj_XChanged;

        }

        private void obj_XChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"X的值改變了");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.X += 1;
        }
    }
}
