using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limra
{
    public partial class LeftSalesBillReport : Form
    {
        public LeftSalesBillReport()
        {
            InitializeComponent();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            label1.Text = "التاريخ";
            //////////////////////////
            label2.Visible = false;
            textBox2.Visible = false;
            comboBox2.Visible = false;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            label1.Text = "من";
            ////////////////////////////////
            label2.Visible = true;
            textBox2.Visible = true;
            comboBox2.Visible = false;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            label1.Text = "من";
            ////////////////////////////////
            label2.Visible = true;
            textBox2.Visible = true;
            comboBox2.Visible = true;
        }
    }
}
