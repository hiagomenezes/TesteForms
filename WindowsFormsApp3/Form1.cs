using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hiago");
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(textBox1.Text);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(textBox1.Text);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");

        }
    }
}
