using System;
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
        private MyCalss another;
        public Form1()
        {
            InitializeComponent();
            obj = new MyCalss();
            obj.XChanged += Obj_XChanged;
           
        }

        private void Obj_XChanged(object sender, EventArgs e)
        {
            MessageBox.Show(object.ReferenceEquals(sender, obj).ToString());
            MessageBox.Show($"X 的值改變了 {object.ReferenceEquals(obj, sender) }");           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.X += 1;            
        }
    }

   
   
}
