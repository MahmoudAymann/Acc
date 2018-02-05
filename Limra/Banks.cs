using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Limra
{
    public partial class Banks : Form
    {
        private const string strconneciton = @"Data Source=SPECTRA5;Initial Catalog=Limra;Integrated Security=True;TrustServerCertificate=False";
        SqlConnection con = new SqlConnection(strconneciton);
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable, dataTable2;

        public Banks()
        {
            InitializeComponent();
            loadDataIntoGridView1();
            resizeGridView1();
        }

        private void resizeGridView1()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView1.Columns[0].HeaderText = "رقم";
            dataGridView1.Columns[1].HeaderText = "رقم حساب البنك";
            dataGridView1.Columns[2].HeaderText = "اسم حساب البنك";
            dataGridView1.Columns[3].HeaderText = "مسلسل";

        }//end resizeGridView1
        private void loadDataIntoGridView1()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT num, accNum, accName, serial FROM Banks";
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
                cmd.CommandText = "SELECT accoNum, accoNameArabic FROM CalculationGuide WHERE accoKind=@accoKind AND used = @used";
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@accoKind", "فرعى");
                cmd.Parameters.AddWithValue("@used", "0");

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                dataTable2 = new DataTable();
                adapter.Fill(dataTable2);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = dataTable2;
                dataGridView2.DataSource = bSource;
                adapter.Update(dataTable2);
                con.Close();
            }
            catch (Exception ed)
            {
                con.Close();
                MessageBox.Show(ed.Message);
            }
        }//end loadAccountsDGV2
        private void resizeGridView2()
        {
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView2.Columns[0].HeaderText = "رقم الحساب";
            dataGridView2.Columns[1].HeaderText = "اسم الحساب";
        }//end resizeGridView2
        
        private void buttonAdd_Bank_Click(object sender, EventArgs e)
        {//////////ADD/////////////

            if (textBoxAccoNum_Bank.Text != "" && checkForAccountNum())
            {
                insertDataIntoBanks();
                insertIntoCalculationGuide(textBoxAccoNum_Bank.Text);
                loadDataIntoGridView1();
                resizeGridView1();
            }
            else
                MessageBox.Show("ادخل رقم الحساب صحيحاً");

            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.Visible = false;
        }

        private bool checkForAccountNum()
        {
            con.Open();
            SqlCommand checkAccountNumber = new SqlCommand("SELECT * FROM CalculationGuide WHERE accoNum = @accoNum AND accoKind = 'فرعى' ", con);
            checkAccountNumber.Parameters.AddWithValue("@accoNum", textBoxAccoNum_Bank.Text);
            SqlDataReader reader = checkAccountNumber.ExecuteReader();
            if (reader.HasRows)
            {
                //User Exists
                con.Close();
                return true;
            }
            else
            {
                //User NOT Exists
                con.Close();
                return false;
            }
        }
        
        private void insertDataIntoBanks()
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO Banks VALUES(@num, @accNum, @accName, @serial, @used)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@num", textBoxBankNum_Bank.Text);
                cmd.Parameters.AddWithValue("@accNum", textBoxAccoNum_Bank.Text);
                cmd.Parameters.AddWithValue("@accName", textBoxAccoName_Bank.Text);
                cmd.Parameters.AddWithValue("@serial", textBoxSerial_Bank.Text);
                cmd.Parameters.AddWithValue("@used", "0");

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }//end insertDataIntoBanks()

        private void insertIntoCalculationGuide(string num)
        {
            try
            {
                con.Open();
                cmd.CommandText = "UPDATE CalculationGuide SET used = @used WHERE accoNum = @accoNum";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@used", "1");
                cmd.Parameters.AddWithValue("@accoNum", num);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        
        private void buttonLoad_Bank_Click(object sender, EventArgs e)
        {
            //loadDataIntoGridView1();
           // resizeGridView1();

            dataGridView2.Visible = false;
            
        }
        
        private void buttonDelete_Bank_Click(object sender, EventArgs e)
        {/////DELETE
            checkForUsingBeforeDelete();
        }

        private void checkForUsingBeforeDelete()
        {
            int i = dataGridView1.SelectedCells[0].RowIndex;
            string numBank = dataGridView1.Rows[i].Cells[0].Value.ToString();
            string numAccount = dataGridView1.Rows[i].Cells[1].Value.ToString();


            con.Open();
            SqlCommand cmdd = new SqlCommand("SELECT used FROM Banks WHERE num = @num", con);
            cmdd.Parameters.Clear();
            cmdd.Parameters.AddWithValue("@num", numBank);

            string res = cmdd.ExecuteScalar().ToString();

            if (res == "1") // used = 1
            {
                //Value Exists
                con.Close();
                MessageBox.Show("لا يمكن مسحه لانه مستخدم فى العمليات المحاسبية", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {    //
                //Value NOT Exists //used = 0
                con.Close();
                setUsedAccountToZero(numAccount);
                deleteBoxInfoFromGridView();
                loadDataIntoGridView1();
            }
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

        private void deleteBoxInfoFromGridView()
        {

            if (dataGridView1.SelectedCells.Count > 0)
            {

                try
                {
                    string value;

                    int i = dataGridView1.CurrentCell.RowIndex;
                    value = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    deleteRecordFromDatabase(value);
                    
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
                    MessageBox.Show("done");

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }

            }//end if


        }//end deleteCompnayInfoItems

        private void deleteRecordFromDatabase(string value)
        {
            con.Open();
            string sqlquery = "DELETE FROM Banks WHERE num = @num";
            SqlCommand command = new SqlCommand(sqlquery, con);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@num", value);
            command.ExecuteNonQuery();
            con.Close();
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxAccoNum_Bank.TextChanged -= textBoxAccoNum_Bank_TextChanged;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                textBoxAccoNum_Bank.Text = row.Cells[0].Value.ToString();
                textBoxAccoName_Bank.Text = "بنك" + " " + row.Cells[1].Value.ToString();
            }
            textBoxAccoNum_Bank.TextChanged += textBoxAccoNum_Bank_TextChanged;

        }

        private void buttonNew_Bank_Click(object sender, EventArgs e)
        {
            textBoxBankNum_Bank.Clear();
            textBoxAccoNum_Bank.Clear();
            textBoxAccoName_Bank.Clear();
            textBoxSerial_Bank.Clear();

            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();

            dataGridView2.Visible = false;
        }

        private void textBoxAccoNum_Bank_TextChanged(object sender, EventArgs e)
        {
            
            loadAccountsDGV2();
            resizeGridView2();
            
            dataGridView2.Visible = true;

            DataView DV = new DataView(dataTable2);

            DV.RowFilter = string.Format("Convert([accoNum], System.String) LIKE '%{0}%'", textBoxAccoNum_Bank.Text);
            dataGridView2.DataSource = DV;
        }

        private void textBoxAccoNum_Bank_Enter(object sender, EventArgs e)
        {
            if (textBoxBankNum_Bank.Text == "")
            {
                textBoxBankNum_Bank.Focus();
            }
        }


        private void textBoxSerial_Bank_Enter(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.Visible = false;
        }
        
    }
}
