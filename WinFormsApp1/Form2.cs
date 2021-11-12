using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Controller;
using WinFormsApp1.Data;
using WinFormsApp1.FormClass;
using WinFormsApp1.Tools;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        CalculateController controller;

        public Form2()
        {
            InitializeComponent();
            selectedOperation.Items.AddRange(Enum.GetNames(typeof(Operation)));
            controller = new CalculateController();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedOperation.SelectedItem == null) { return; }
            var result = controller.Calculate((Operation)Enum.Parse(typeof(Operation), selectedOperation.SelectedItem.ToString()));
            resultLable.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormsStorage.Form1.Show();
            FormsStorage.Form2.Hide();

            if (string.IsNullOrEmpty(resultLable.Text))
                return;
            DataTool.GetResult(resultLable.Text);
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            label4.Text = StaticData.Input;
        }

    }
}
