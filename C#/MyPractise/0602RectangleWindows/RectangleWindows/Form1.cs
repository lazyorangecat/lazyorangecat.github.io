using RectangleLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectangleWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var width=numericUpDown1.Value;
            var height=numericUpDown2.Value;

            RectangleLibrary.Rectangle rect = new RectangleLibrary.Rectangle() { Width = (int)width, Height = (int)height };
            RectangleOperation operation = new RectangleOperation();
            operation.Target = rect;
            label3.Text = "長方形的面積為"+operation.ComputeArea();
        }
    }
}
