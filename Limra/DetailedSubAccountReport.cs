using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limra
{
    public partial class DetailedSubAccountReport : Form
    {
        private const string strconneciton = @"Data Source=SPECTRA5;Initial Catalog=Limra;Integrated Security=True;TrustServerCertificate=False";
        SqlConnection con = new SqlConnection(strconneciton);
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable;

        public DetailedSubAccountReport()
        {
            InitializeComponent();
        }

        private void loadSubAccountsDGV1()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT accoNum, accoNameArabic FROM CalculationGuide WHERE accoKind=@accoKind";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@accoKind", "فرعى");
                cmd.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                dataTable = new DataTable();
                adapter.Fill(dataTable);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dataTable;

                dataGridView1.DataSource = bSource;
                adapter.Update(dataTable);
                con.Close();

                resizeGridView1();
            }
            catch (Exception ed)
            {
                con.Close();
                MessageBox.Show(ed.Message);
            }
        }

        private void loadMainAccountsDGV1()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT accoNum, accoNameArabic FROM CalculationGuide WHERE accoKind=@accoKind";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@accoKind", "رئيسى");
                cmd.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                dataTable = new DataTable();
                adapter.Fill(dataTable);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dataTable;
                dataGridView1.DataSource = bSource;
                adapter.Update(dataTable);
                con.Close();

                resizeGridView1();
            }
            catch (Exception ed)
            {
                con.Close();
                MessageBox.Show(ed.Message);
            }
        }//end loadMain

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox_AccName_DetailedSubAccReport.TextChanged -= textBox_AccName_DetailedSubAccReport_TextChanged;
            textBox_AccNumber_DetailedSubAccReport.TextChanged -= textBox_AccNumber_DetailedSubAccReport_TextChanged;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox_AccNumber_DetailedSubAccReport.Text = row.Cells[0].Value.ToString();
                textBox_AccName_DetailedSubAccReport.Text = row.Cells[1].Value.ToString();
            }

            textBox_AccName_DetailedSubAccReport.TextChanged += textBox_AccName_DetailedSubAccReport_TextChanged;
            textBox_AccNumber_DetailedSubAccReport.TextChanged += textBox_AccNumber_DetailedSubAccReport_TextChanged;
        }

        private void textBox_AccNumber_DetailedSubAccReport_TextChanged(object sender, EventArgs e)
        {
            if (radioButton_SubAccont.Checked)
            {
                dataGridView1.Visible = true;
                loadSubAccountsDGV1();

                dataGridView1.Visible = true;

                DataView DV = new DataView(dataTable);

                DV.RowFilter = string.Format("Convert([accoNum], System.String) LIKE '%{0}%'", textBox_AccNumber_DetailedSubAccReport.Text);
                dataGridView1.DataSource = DV;

                if (textBox_AccNumber_DetailedSubAccReport.Text == "")
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Visible = false;
                }
            }
            else if(radioButton_MainAccount.Checked)
            {
                dataGridView1.Visible = true;
                loadMainAccountsDGV1();

                dataGridView1.Visible = true;

                DataView DV = new DataView(dataTable);

                DV.RowFilter = string.Format("Convert([accoNum], System.String) LIKE '%{0}%'", textBox_AccNumber_DetailedSubAccReport.Text);
                dataGridView1.DataSource = DV;

                if (textBox_AccNumber_DetailedSubAccReport.Text == "")
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Visible = false;
                }
            }
            
        }
        private void resizeGridView1()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns[0].HeaderText = "رقم حساب";
            dataGridView1.Columns[1].HeaderText = "اسم حساب";
        }//end resizeGridView1
        

        private void textBox_AccName_DetailedSubAccReport_TextChanged(object sender, EventArgs e)
        {
            if (radioButton_SubAccont.Checked)
            {
                loadSubAccountsDGV1();
                dataGridView1.Visible = true;

                DataView DV = new DataView(dataTable);
                DV.RowFilter = string.Format("accoNameArabic LIKE '%{0}%'", textBox_AccName_DetailedSubAccReport.Text);

                dataGridView1.DataSource = DV;

                if (textBox_AccName_DetailedSubAccReport.Text == "")
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Visible = false;
                }
            }
            else if (radioButton_MainAccount.Checked)
            {
                loadMainAccountsDGV1();
                dataGridView1.Visible = true;

                DataView DV = new DataView(dataTable);
                DV.RowFilter = string.Format("accoNameArabic LIKE '%{0}%'", textBox_AccName_DetailedSubAccReport.Text);

                dataGridView1.DataSource = DV;

                if (textBox_AccName_DetailedSubAccReport.Text == "")
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Visible = false;
                }
            }
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            string accNum_Text = textBox_AccNumber_DetailedSubAccReport.Text;
            new DetailedSubAccReportForm(accNum_Text).Show();
        }
    }
}