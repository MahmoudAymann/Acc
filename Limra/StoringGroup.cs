using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;


using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Limra
{
    public partial class StoringGroup : Form
    {
        static string strConneciton = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con = new SqlConnection(strConneciton);
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable;
        string cuurency;
        public StoringGroup()
        {
            InitializeComponent();
            loadDataIntoGridView();
            resizeGridView();
        }

        private void resizeGridView()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            
            dataGridView1.Columns[0].HeaderText = "رقم المجموعة";
            dataGridView1.Columns[1].HeaderText = "اسم المجموعة العربى";
            dataGridView1.Columns[2].HeaderText = "اسم المجموعة الاجنبى";
            dataGridView1.Columns[3].HeaderText = "رقم حساب المجموعة";
            dataGridView1.Columns[4].HeaderText = "حساب مبيعات المجموعة";
            dataGridView1.Columns[5].HeaderText = "حساب تكلفة المبيعات";
            dataGridView1.Columns[6].HeaderText = "حساب مردود المبيعات";
            dataGridView1.Columns[7].HeaderText = "حساب الخصم المسموح به";
            
        }

        private void resizeGridView2()
        {
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


            dataGridView2.Columns[0].HeaderText = "رقم الحساب";
            dataGridView2.Columns[1].HeaderText = "اسم الحساب";
            dataGridView2.Columns[2].HeaderText = "العملة";


        }//end resizeGridView2

        private void loadDataIntoGridView()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM StoringDataGroups";
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
            }
            catch (Exception ed)
            {
                con.Close();
                MessageBox.Show(ed.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            insertData();
            loadDataIntoGridView();
            resizeGridView();
        }

        private void insertData()
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO StoringDataGroups VALUES(@num, @nameArabic, @nameEnglish, @accNum, @salesAccountNum, @salesCostAccountNum, @salesReturnAccountNum, @discountAllowedAccountNum)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@num",textBoxNum.Text);
                cmd.Parameters.AddWithValue("@nameArabic", textBoxNameArabic.Text);
                cmd.Parameters.AddWithValue("@nameEnglish", textBoxNameEnglish.Text);
                cmd.Parameters.AddWithValue("@accNum", textBoxAccNum.Text);
                cmd.Parameters.AddWithValue("@salesAccountNum", textBoxSalesAccountNum.Text);
                cmd.Parameters.AddWithValue("@salesCostAccountNum", textBoxSalesCostAccountNum.Text);
                cmd.Parameters.AddWithValue("@salesReturnAccountNum", textBoxSalesReturnAccountNum.Text);
                cmd.Parameters.AddWithValue("@discountAllowedAccountNum", textBoxDiscountAllowedAccountNum.Text);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }//end insertData()

        private void buttonDelete_Click(object sender, EventArgs e){
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                getCurrency();
                showData();
                resizeGridView2();
            }
            else if (checkBox1.Checked == false)
            {
                dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();
            }
        }
        
        private void getCurrency()
        {
            con.Open();
            string sqlquery = "Select name FROM StoringCurrency";
            SqlCommand command = new SqlCommand(sqlquery, con);
            cuurency = command.ExecuteScalar().ToString();
            con.Close();
        }

        private void showData()
        {
            
            try
            {
                con.Open();
                cmd.CommandText = "SELECT accoNum,accoNameArabic,cuurency FROM CalculationGuide WHERE cuurency=@cuurency";
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cuurency",cuurency);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                dataTable = new DataTable();
                adapter.Fill(dataTable);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dataTable;
                dataGridView2.DataSource = bSource;
                adapter.Update(dataTable);
                con.Close();
            }
            catch (Exception ed)
            {
                con.Close();
                MessageBox.Show(ed.Message);
            }
            
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView2.SelectedCells[0].RowIndex;
            textBoxAccNum.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
        }
    }
}
