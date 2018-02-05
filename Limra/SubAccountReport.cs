using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Limra
{
    public partial class SubAccountReport : Form
    {
        private const string strconneciton = @"Data Source=SPECTRA5;Initial Catalog=Limra;Integrated Security=True;TrustServerCertificate=False";
        SqlConnection con = new SqlConnection(strconneciton);
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable;

        public SubAccountReport()
        {
            InitializeComponent();
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            string accNum_Text = textBox_AccNumber_AnalyticalSubaccountReport.Text;
            new SubAccReportForm(accNum_Text).Show();

        }

        private void loadSubAccountsDGV1()
        {
            if (radioButton_SubAccont.Checked)
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
        }


        private void loadMainAccountsDGV1()
        {
            if (radioButton_MainAccount.Checked)
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
            }

        }//end load

        private void textBox_AccNumber_AnalyticalSubaccountReport_TextChanged(object sender, EventArgs e)
        {

            if (radioButton_SubAccont.Checked)
            {
                dataGridView1.Visible = true;
                loadSubAccountsDGV1();

                dataGridView1.Visible = true;

                DataView DV = new DataView(dataTable);

                DV.RowFilter = string.Format("Convert([accoNum], System.String) LIKE '%{0}'", textBox_AccNumber_AnalyticalSubaccountReport.Text);
                dataGridView1.DataSource = DV;

                if (textBox_AccNumber_AnalyticalSubaccountReport.Text == "")
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Visible = false;
                }
            }
            else if (radioButton_MainAccount.Checked)
            {
                dataGridView1.Visible = true;
                loadMainAccountsDGV1();

                dataGridView1.Visible = true;

                DataView DV = new DataView(dataTable);

                DV.RowFilter = string.Format("Convert([accoNum], System.String) LIKE '%{0}'", textBox_AccNumber_AnalyticalSubaccountReport.Text);
                dataGridView1.DataSource = DV;

                if (textBox_AccNumber_AnalyticalSubaccountReport.Text == "")
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

        private void textBox_AccName_AnalyticalSubaccountReport_TextChanged(object sender, EventArgs e)
        {
            loadSubAccountsDGV1();
            dataGridView1.Visible = true;

            DataView DV = new DataView(dataTable);
            DV.RowFilter = string.Format("accoNameArabic LIKE '%{0}%'", textBox_AccName_AnalyticalSubaccountReport.Text);

            dataGridView1.DataSource = DV;

            if (textBox_AccName_AnalyticalSubaccountReport.Text == "")
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Visible = false;

            }
        }//end textBox_AccName_AnalyticalSubaccountReport_TextChanged

        
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox_AccName_AnalyticalSubaccountReport.TextChanged -= textBox_AccName_AnalyticalSubaccountReport_TextChanged;
            textBox_AccNumber_AnalyticalSubaccountReport.TextChanged -= textBox_AccNumber_AnalyticalSubaccountReport_TextChanged;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox_AccNumber_AnalyticalSubaccountReport.Text = row.Cells[0].Value.ToString();
                textBox_AccName_AnalyticalSubaccountReport.Text = row.Cells[1].Value.ToString();
            }

            textBox_AccName_AnalyticalSubaccountReport.TextChanged += textBox_AccName_AnalyticalSubaccountReport_TextChanged;
            textBox_AccNumber_AnalyticalSubaccountReport.TextChanged += textBox_AccNumber_AnalyticalSubaccountReport_TextChanged;
        }
    }//end class

}//end namespace