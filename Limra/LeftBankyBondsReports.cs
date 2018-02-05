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
    public partial class LeftBankyBondsReports : Form
    {
        public LeftBankyBondsReports()
        {
            InitializeComponent();
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox3.Visible = true;
            label2.Text = "التاريخ";
            //////////////////////////
            label3.Visible = false;
            textBox4.Visible = false;
            comboBox2.Visible = false;
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox3.Visible = true;
            //////////////////////////
            label2.Text = "من";
            label3.Visible = true;
            textBox4.Visible = true;
            comboBox2.Visible = false;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox3.Visible = true;
            //////////////////////////
            label2.Text = "من";
            label3.Visible = true;
            textBox4.Visible = true;
            comboBox2.Visible = true;
        }
    }
}