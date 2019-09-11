using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;


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

        private void Button4_Click_1(object sender, EventArgs e)
        {
            int contador = 0;
            for (int i = 0; i <= checkedListBox1.Items.Count; i++)
            {
                contador = i;
            }
            MessageBox.Show("total " +contador);
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == (char)Keys.Return)
            {
                this.button2.PerformClick();
            }

        }

        private void Button3_ControlRemoved(object sender, ControlEventArgs e)
        {
          
        }
    }
}



            
        

