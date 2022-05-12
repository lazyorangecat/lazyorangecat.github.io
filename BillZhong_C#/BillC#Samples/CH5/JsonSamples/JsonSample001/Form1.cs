using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace JsonSample001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        async private void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            // 這個就是剛剛在公開資料平台的資料下載網址
            string uri =
                "https://odws.hccg.gov.tw/001/Upload/25/opendataback/9059/695/48770959-69d6-40ba-bcb8-d2307c1f692c.json";
            string data = await client.GetStringAsync(uri);
            var result = JsonConvert.DeserializeObject<Class1[]>(data);           
            dataGridView1.DataSource = result[0].result.records ;
        }
    }
}
