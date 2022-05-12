using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample003
{
    public partial class Form1 : Form
    {
        private List<MyRectangle> _list;
        private List<MyRectangle> _list2;
        private void CreateList()
        {
            _list = new List<MyRectangle>()
            {
                new MyRectangle { Name = "D1", Width = 5, Height= 5},
                new MyRectangle { Name = "D2", Width = 10, Height= 10},
                new MyRectangle { Name = "D3", Width = 20, Height= 20},
                new MyRectangle { Name = "D4", Width = 100, Height= 100}
            };
            _list2 = new List<MyRectangle>()
            {
                new MyRectangle { Name = "D1", Width = 5, Height= 5},
                new MyRectangle { Name = "D2", Width = 10, Height= 10},
                new MyRectangle { Name = "D3", Width = 20, Height= 20},
                new MyRectangle { Name = "D4", Width = 100, Height= 100}
            };

        }
        //private void CreateList2()
        //{
            
        //    _list2 = new List<MyRectangle>()
        //    {
        //        new MyRectangle { Name = "D1", Width = 5, Height= 5},
        //        new MyRectangle { Name = "D2", Width = 10, Height= 10},
        //        new MyRectangle { Name = "D3", Width = 20, Height= 20},
        //        new MyRectangle { Name = "D4", Width = 100, Height= 100}
        //    };
        //}



        public Form1()
        {
            InitializeComponent();
            CreateList();            
            SetCombobox();
            SetCombobox2();
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
        }
        private void SetCombobox()
        {
            comboBox1.DataSource = _list;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Area";
        }
        private void SetCombobox2()
        {
            comboBox2.DataSource = _list2;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Area";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox theComboBox = (ComboBox)sender;
            int index = theComboBox.SelectedIndex;
            List<MyRectangle>target=(List<MyRectangle>)theComboBox.DataSource;
            MyRectangle item = target[index];

            //MyRectangle item = _list[index];
            MessageBox.Show($"取得索引{index},{item.Name}的面積為:{item.Area}");

        }




        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox theComboBox = (ComboBox)sender;
            int index = theComboBox.SelectedIndex;
            List<MyRectangle> target = (List<MyRectangle>)theComboBox.DataSource;
            MyRectangle item = target[index];

            //MyRectangle item = _list[index];
            MessageBox.Show($"取得索引{index},{item.Name}的面積為:{item.Area}");
        }
    }
}
