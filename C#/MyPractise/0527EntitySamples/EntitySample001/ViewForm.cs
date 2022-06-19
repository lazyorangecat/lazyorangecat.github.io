using EntitySample001.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitySample001
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
            BinData();
        }

        private void BinData()
        {
            var context = new ContactsModel();
            var list=context.ContactsTable.ToList();
            dataGridView1.DataSource= list;
        }
    }
}
