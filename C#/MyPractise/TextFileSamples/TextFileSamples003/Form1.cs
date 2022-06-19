using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileSamples003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var list = CreateData();
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private List<Restaurant> CreateData()
        {
            string fileName = "BBB.csv";
            if(File.Exists(fileName))
            {
                return File.ReadLines(fileName).Skip(1)
                    .Select(x => x.Split(','))
                    .Select(x => new Restaurant
                    { 
                        Seq=int.Parse(x[0]),
                        DishName=x[1],
                        Shop=x[3],
                        Address=x[4],
                        Tel=x[5],
                    }).ToList();
            }
            return null;
        }
    }
}
