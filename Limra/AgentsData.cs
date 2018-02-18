using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Limra
{
    public partial class AgentsData : Form
    {
        static string strConneciton = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con = new SqlConnection(strConneciton);
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable;
        public AgentsData()
        {
            InitializeComponent();
            loadDataIntoGridView1();
            resizeGridView1();
            
        }


        private void resizeGridView1()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView1.Columns[0].HeaderText = "رقم العميل";
            dataGridView1.Columns[1].HeaderText = "رقم حساب العميل";
            dataGridView1.Columns[2].HeaderText = "اسم العميل";
            dataGridView1.Columns[3].HeaderText = "العنوان";
            dataGridView1.Columns[4].HeaderText = "التليفون";
            dataGridView1.Columns[5].HeaderText = "الاسم الاجنبى";
            dataGridView1.Columns[6].HeaderText = "رقم الفاكس";
            dataGridView1.Columns[7].HeaderText = "الرمز البريدى";
            dataGridView1.Columns[8].HeaderText = "المدينة";
            dataGridView1.Columns[9].HeaderText = "الدولة";
            dataGridView1.Columns[10].HeaderText = "حد الديوان";
            dataGridView1.Columns[11].HeaderText = "عن طريق";
            
        }//end resizeGridView1

        private void resizeGridView2()
        {
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView2.Columns[0].HeaderText = "رقم الحساب";
            dataGridView2.Columns[1].HeaderText = "اسم الحساب";



        }//end resizeGridView2
        
        private void loadDataIntoGridView1()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM AgentsData";
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
        }//end loadDataIntoGridView1

        private void loadAccountsDGV2()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT accoNum, accoNameArabic FROM CalculationGuide WHERE accoKind=@accoKind AND used=@used";
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@accoKind", "فرعى");
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                dataTable = new DataTable();
                adapter.Fill(dataTable);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dataTable;
                dataGridView2.DataSource = bSource;
                adapter.Update(dataTable);
                con.Close();
                resizeGridView2();
            }
            catch (Exception ed)
            {
                con.Close();
                MessageBox.Show(ed.Message);
            }
        }//end loadDataIntoGridView2

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            insertData();
            setUsedAccountToOne(textBoxAccoNum.Text);
            loadDataIntoGridView1();
            resizeGridView1();
        }

        private void setUsedAccountToZero(string num)
        {
            cmd.CommandText = "UPDATE CalculationGuide SET used='0' WHERE accoNum = @accoNum AND accoKind='فرعى'";
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@accoNum", num);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void setUsedAccountToOne(string num)
        {
            cmd.CommandText = "UPDATE CalculationGuide SET used='1' WHERE accoNum = @accoNum AND accoKind='فرعى'";
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@accoNum", num);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void insertData()
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO AgentsData VALUES(@id, @accNum, @nameArabic, @address, @phone," +
                    " @nameEnglish, @fax, @postalCode, @city, @country, @deptLimit, @fromWay)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@id", textBoxAgentNum.Text);
                cmd.Parameters.AddWithValue("@accNum", textBoxAccoNum.Text);
                cmd.Parameters.AddWithValue("@nameArabic", textBoxAgentNameArabic.Text);
                cmd.Parameters.AddWithValue("@address", textBoxAddress.Text);
                cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                cmd.Parameters.AddWithValue("@nameEnglish", textBoxNameEnglish.Text);
                cmd.Parameters.AddWithValue("@fax", textBoxFax.Text);
                cmd.Parameters.AddWithValue("@postalCode", textBoxZipCode.Text);
                cmd.Parameters.AddWithValue("@city", textBoxCity.Text);
                cmd.Parameters.AddWithValue("@country", textBoxCountry.Text);
                cmd.Parameters.AddWithValue("@deptLimit", textBoxDebitLimit.Text);
                cmd.Parameters.AddWithValue("@fromWay", textBoxFrom.Text);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }//end insertData()

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxAccoNum.TextChanged -= textBoxAccoNum_TextChanged;
           
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                textBoxAccoNum.Text = row.Cells[0].Value.ToString();
                textBoxAgentNameArabic.Text = row.Cells[1].Value.ToString();
            }

            textBoxAccoNum.TextChanged += textBoxAccoNum_TextChanged;

            dataGridView2.Visible = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            deleteCompanyInfoItems();
            loadDataIntoGridView1();
        }

        private void deleteCompanyInfoItems()
        {
            
            //delete multiple rows
            if (dataGridView1.SelectedCells.Count > 0)
            {
                setUsedAccountToZero(dataGridView1.CurrentRow.Cells[1].Value.ToString());

                foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
                {
                    if (oneCell.Selected)
                        dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                }
            }//end if
             //THEN
             //////////////////////////////////////
            try
            {
                con.Open();
                cmd.CommandText = "TRUNCATE TABLE AgentsData";
                cmd.ExecuteNonQuery();

                insertAfterDeleteIntoDb();
                con.Close();
                MessageBox.Show("deleted!");
            }
            catch (Exception er)
            {
               con.Close();
                MessageBox.Show(er.Message);
            }
        }//end deleteCompnayInfoItems

        private void insertAfterDeleteIntoDb()
        {
            SqlCommand cmd2 = new SqlCommand("Insert into AgentsData(id, accNum, nameArabic, address, phone,nameEnglish" +
                ", fax, postalCode, city, country, deptLimit, fromWay)" +
                " values (@id, @accNum, @nameArabic, @address, @phone," +
                " @nameEnglish, @fax, @postalCode, @city, @country, @deptLimit, @fromWay)", con);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                cmd2.Parameters.Clear();
                cmd2.Parameters.AddWithValue("@id", dataGridView1.Rows[i].Cells[0].Value);
                cmd2.Parameters.AddWithValue("@accNum", dataGridView1.Rows[i].Cells[1].Value);
                cmd2.Parameters.AddWithValue("@nameArabic", dataGridView1.Rows[i].Cells[2].Value);
                cmd2.Parameters.AddWithValue("@address", dataGridView1.Rows[i].Cells[3].Value);
                cmd2.Parameters.AddWithValue("@phone", dataGridView1.Rows[i].Cells[4].Value);
                cmd2.Parameters.AddWithValue("@nameEnglish", dataGridView1.Rows[i].Cells[5].Value);
                cmd2.Parameters.AddWithValue("@fax", dataGridView1.Rows[i].Cells[6].Value);
                cmd2.Parameters.AddWithValue("@postalCode", dataGridView1.Rows[i].Cells[7].Value);
                cmd2.Parameters.AddWithValue("@city", dataGridView1.Rows[i].Cells[8].Value);
                cmd2.Parameters.AddWithValue("@country", dataGridView1.Rows[i].Cells[9].Value);
                cmd2.Parameters.AddWithValue("@deptLimit", dataGridView1.Rows[i].Cells[10].Value);
                cmd2.Parameters.AddWithValue("@fromWay", dataGridView1.Rows[i].Cells[11].Value);

                cmd2.ExecuteNonQuery();
            }//end for

        }//end insertAfterDeleteIntoDb

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            loadDataIntoGridView1();
        }

        private void textBoxAgentNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;
            groupBox2.Text = "ستقوم بتعديل بيانات العميل رقم:  " + dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBoxAgentNum.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBoxAgentNameArabic.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBoxAddress.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBoxPhone.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();

            buttonEditApprove.Enabled = true;
            textBoxAgentNum.Enabled = false;
        }

        private void buttonEditApprove_Click(object sender, EventArgs e)
        {
            editFunction();
            loadDataIntoGridView1();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            textBoxAgentNum.Enabled = true;
        }

        private void editFunction()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            try
            {
                string sqlquery = "UPDATE AgentsData SET accNum = @accNum, " +
                    " nameArabic = @nameArabic, address = @address," +
                    " phone = @phone, nameEnglish = @nameEnglish," +
                    " fax = @fax, postalCode = @postalCode," +
                    " city = @city , country = @country," +
                    " deptLimit = @deptLimit, fromWay=@fromWay WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(sqlquery, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id", textBoxAgentNum.Text);
                cmd.Parameters.AddWithValue("@accNum", textBoxAccoNum.Text);
                cmd.Parameters.AddWithValue("@nameArabic", textBoxAgentNameArabic.Text);
                cmd.Parameters.AddWithValue("@address", textBoxAddress.Text);
                cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                cmd.Parameters.AddWithValue("@nameEnglish", textBoxNameEnglish.Text);
                cmd.Parameters.AddWithValue("@fax", textBoxFax.Text);
                cmd.Parameters.AddWithValue("@postalCode", textBoxZipCode.Text);
                cmd.Parameters.AddWithValue("@city", textBoxCity.Text);
                cmd.Parameters.AddWithValue("@country", textBoxCountry.Text);
                cmd.Parameters.AddWithValue("@deptLimit", textBoxDebitLimit.Text);
                cmd.Parameters.AddWithValue("@fromWay", textBoxFrom.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم التعديل");
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("لا يوجد عميل بهذا الرقم");
            }
        }

        private void textBoxAccoNum_TextChanged(object sender, EventArgs e)
        {
            loadAccountsDGV2();

            dataGridView2.Visible = true;

            DataView DV = new DataView(dataTable);

            DV.RowFilter = string.Format("Convert([accoNum], System.String) LIKE '%{0}'", textBoxAccoNum.Text);
            dataGridView2.DataSource = DV;
        }
    }
}