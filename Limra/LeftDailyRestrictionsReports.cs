using System;

using System.Windows.Forms;

namespace Limra
{
    public partial class LeftDailyRestrictionsReports : Form
    {
        public LeftDailyRestrictionsReports()
        {
            InitializeComponent();
        }

        

        private void radioButton1_Click(object sender, EventArgs e){
            label1.Visible = true;
            textBox1.Visible = true;
            /////////////////////////////////
            comboBox1.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            textBox3.Visible = false;
        }

        private void radioButton2_Click(object sender, EventArgs e){
            label1.Visible = false;
            textBox1.Visible = false;
            comboBox1.Visible = false;
            ///////////////////////////////
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            textBox3.Visible = true;
        }

        private void radioButton3_Click(object sender, EventArgs e){
            label1.Visible = false;
            textBox1.Visible = false;
            /////////////////////////////////
            comboBox1.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            textBox3.Visible = true;
        }

        
    }
}