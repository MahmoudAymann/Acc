using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Configuration;

namespace Limra
{
    public partial class Boxes : Form
    {
        static string strConneciton = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con = new SqlConnection(strConneciton);
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable, dataTable2;

        public Boxes()
        {
            InitializeComponent();
            loadDataIntoGridView1();
            resizeGridView1();
        }

        //DGV-1
        private void loadDataIntoGridView1()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT num, accNum, accName, serial FROM Boxes";
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
        private void resizeGridView1()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


            dataGridView1.Columns[0].HeaderText = "رقم";
            dataGridView1.Columns[1].HeaderText = "رقم حساب الصندوق";
            dataGridView1.Columns[2].HeaderText = "اسم حساب الصندوق";
            dataGridView1.Columns[3].HeaderText = "مسلسل";

        }//end resizeGridView1

        //DGV-2
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
        private void resizeGridView2(){
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
          
            dataGridView2.Columns[0].HeaderText = "رقم الحساب";
            dataGridView2.Columns[1].HeaderText = "اسم الحساب";
         
        }//end resizeGridView2
       
        private void buttonLoad_Box_Click(object sender, EventArgs e)
        {
            ///////////// LOAD ///////////
            loadDataIntoGridView1();
        }
            
        private void buttonDelete_Box_Click(object sender, EventArgs e)
        {///DELETE///////////
            checkForUsingBeforeDelete();

            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.Visible = false;
        }

        private void checkForUsingBeforeDelete()
        {
            int i = dataGridView1.SelectedCells[0].RowIndex;
            string numBoxes = dataGridView1.Rows[i].Cells[0].Value.ToString();
            string numAccount = dataGridView1.Rows[i].Cells[1].Value.ToString();
            
            con.Open();
            SqlCommand cmdd = new SqlCommand("SELECT used FROM Boxes WHERE num = @num", con);
            cmdd.Parameters.Clear();
            cmdd.Parameters.AddWithValue("@num", numBoxes);

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
                }//end try
                catch (Exception er)
                {                
                   MessageBox.Show(er.Message);
                }
            }//end if
           
        }//end deleteCompnayInfoItems

        private void deleteRecordFromDatabase(string value)
        {
            con.Open();
            string sqlquery = "DELETE FROM Boxes WHERE num = @num";
            SqlCommand command = new SqlCommand(sqlquery, con);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@num", value);
            command.ExecuteNonQuery();
            con.Close();
        }
        
        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxAccNum.TextChanged -= textBoxAccNum_TextChanged;
           
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textBoxAccNum.Text = row.Cells[0].Value.ToString();
                textBoxAccName.Text = "صندوق" + " " + row.Cells[1].Value.ToString();
            }
            textBoxAccNum.TextChanged += textBoxAccNum_TextChanged;

        }

        private void buttonNew_Box_Click(object sender, EventArgs e)
        {   // clear text    
            textBoxNum.Clear();
            textBoxAccNum.Clear();
            textBoxAccName.Clear();
            textBoxSerial.Clear();

            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            
            dataGridView2.Visible = false;
        }

        private void buttonAdd_Boxes_Click(object sender, EventArgs e)
        {
            ////////// ADD /////////////////
            if(textBoxAccNum.Text != "" && checkForAccountNum())
            { 
                 insertIntoBoxes();
                 insertIntoCalculationGuide(textBoxAccNum.Text);
                 loadDataIntoGridView1();
                 resizeGridView1();
            }
            else
                MessageBox.Show("ادخل الحساب صحيحا");
            
        }//end buttonADD


        private bool checkForAccountNum()
        {
            con.Open();
            SqlCommand checkAccountNumber = new SqlCommand("SELECT * FROM CalculationGuide WHERE accoNum = @accoNum AND accoKind = 'فرعى' ", con);
            checkAccountNumber.Parameters.AddWithValue("@accoNum", textBoxAccNum.Text);
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
        private void insertIntoBoxes()
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO Boxes VALUES(@num, @accNum, @accName, @serial, @used)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@num", textBoxNum.Text);
                cmd.Parameters.AddWithValue("@accNum", textBoxAccNum.Text);
                cmd.Parameters.AddWithValue("@accName", textBoxAccName.Text);
                cmd.Parameters.AddWithValue("@serial", textBoxSerial.Text);
                cmd.Parameters.AddWithValue("@used", "0");
                
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }//end insertData()
        
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


        private void buttonEdit_Click(object sender, EventArgs e)
        {//////////EDIT////////////
            
        }

        private void Boxes_Load(object sender, EventArgs e)
        {
            loadDataIntoGridView1();
            resizeGridView1();

            dataGridView2.Visible = false;
        }

        private void textBoxSerial_Enter(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.Visible = false;
        }

       
        private void textBoxAccNum_Enter(object sender, EventArgs e)
        {
            if (textBoxNum.Text == "")
            {
                textBoxNum.Focus();
            }
        }
        
        private void textBoxAccNum_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView2.DataSource == null)
            {
                loadAccountsDGV2();
                resizeGridView2();
            }

            dataGridView2.Visible = true;

            DataView DV = new DataView(dataTable2);

            DV.RowFilter = string.Format("Convert([accoNum], System.String) LIKE '%{0}%'", textBoxAccNum.Text);
            dataGridView2.DataSource = DV;
        }
        
    }//end class    
}//end namespace