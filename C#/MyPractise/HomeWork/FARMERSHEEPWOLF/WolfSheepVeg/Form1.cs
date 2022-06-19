using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolfSheepVeg
{
    public partial class Form1 : Form
    {
        private string F { get;}
        private string W { get;}
        private string S { get;}
        private string V { get;}

        private List<string> _left;
        private List<string> _right;
        private bool _isFarmerLeft;

        
        public Form1()
        {
            InitializeComponent();
            F = "農夫";
            W = "狼";
            S = "羊";
            V = "蔬菜";
            listBox_L.DataSource = _left;
            listBox_R.DataSource = _right;
            listBox_L.SelectionMode = SelectionMode.One;
            listBox_R.SelectionMode = SelectionMode.One;
            ResetGame();           
        }


        private void RefreshUI()
        {
            listBox_L.DataSource = null;
            listBox_R.DataSource = null;
            listBox_L.DataSource = _left;
            listBox_R.DataSource = _right;
        }

        private void InitializeData()
        {
            _left= new List<string> { F, W ,S ,V };
            _right = new List<string>();
            _isFarmerLeft = true;
        }

        private void btn_Across_Click(object sender, EventArgs e)
        {
            var farmerSideListBox = listBox_R;
            if (_isFarmerLeft)
                farmerSideListBox = listBox_L;

            string selectedName = (string)farmerSideListBox.SelectedItem;
            if (selectedName ==null)
                return;
            if(selectedName != F)
            {
                AcrossData(selectedName);
            }

            AcrossData(F);//農夫過河
            _isFarmerLeft = !_isFarmerLeft;
            RefreshUI();

            if(CheckGameOver())
            {
                btn_Across.Enabled = false;
            }
        }

        private bool CheckGameOver()
        {
            if(_right.Count==4)
            {
                MessageBox.Show("Win");
                return true;
            }

            var noFarmerSideList = _left;
            if(_isFarmerLeft)
                noFarmerSideList = _right;
            
            if(noFarmerSideList.Contains(S))
            {
                if(noFarmerSideList.Contains(W))
                {
                    MessageBox.Show($"{W}吃{S}");
                    return true;
                }
                if (noFarmerSideList.Contains(V))
                {
                    MessageBox.Show($"{S}吃{V}");
                    return true;
                }

            }

            return false;
        }

        private void AcrossData(string selectedName)
        {
            var go = _right;
            var to = _left;

            if(_isFarmerLeft)
            {
                go = _left;
                to = _right;
            }

            go.Remove(selectedName);
            to.Add(selectedName);    
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ResetGame()
        {
            InitializeData();
            RefreshUI();
            btn_Across.Enabled = true;            
        }

    }
}
