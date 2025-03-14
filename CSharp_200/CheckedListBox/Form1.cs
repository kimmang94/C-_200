using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBox
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cListBox.Items.Add("오스트리아, 빈");
            cListBox.Items.Add("호주, 애틀레이드");

            lstBox.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            foreach(var city in cListBox.CheckedItems)
            {
                lstBox.Items.Add(city);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            foreach (var city in cListBox.Items)
            {
                lstBox.Items.Add(city);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            List<string> listRemove = new List<string>();

            foreach (string city in lstBox.SelectedItems)
            {
                listRemove.Add(city);
            }

            foreach (string city in listRemove)
            {
                lstBox.Items.Remove(city);
            }
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
        }
    }
}
