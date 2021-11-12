using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Data;
using WinFormsApp1.FormClass;
using WinFormsApp1.Tools;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormsStorage.Form1 = this;
            label2.Visible = false;
            label3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb1.Text))
                return;
            DataTool.ExtractNumbersFromString(tb1.Text);
            FormsStorage.Form1.Hide();
            FormsStorage.Form2.Show();
        }

        private void tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;

            label3.Text = StaticData.InputResult;
        }
    }
}
