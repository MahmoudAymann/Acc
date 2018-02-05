using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Limra
{
    public partial class DailyRestrictions : Form
    {
        private const string strconneciton = @"Data Source=SPECTRA5;Initial Catalog=Limra;Integrated Security=True;TrustServerCertificate=False";
        SqlConnection con = new SqlConnection(strconneciton);
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable;

        public DailyRestrictions()
        {
            InitializeComponent();
            
        }
        
        private void checkForTatalCost()
        {
            if (textBoxCost.Text != textBoxTotalCost.Text)
            {
                MessageBox.Show("هناك تعارض بين المبلغ واجمالى المبلغ ","تحذير",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void resizeGridView1(){
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            
            dataGridView1.Columns[0].HeaderText = "م";
            dataGridView1.Columns[1].HeaderText = "رقم المستند";
            dataGridView1.Columns[2].HeaderText = "رقم الحساب";
            dataGridView1.Columns[3].HeaderText = "اسم الحساب";
            dataGridView1.Columns[4].HeaderText = "بيان";
            dataGridView1.Columns[5].HeaderText = "مدين";
            dataGridView1.Columns[6].HeaderText = "دائن";
        }//end resizeGridView1

        private void loadDataIntoGridView1()
        {
            if (textBoxDocumentNum.Text != "")
            {
                try
                {
                    con.Open();
                    cmd.CommandText = "SELECT id, docId, accNum, accName, description, credit, debit  FROM DailyRestrictions WHERE docId=@docId";
                    cmd.Connection = con;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@docId", textBoxDocumentNum.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;

                    dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dataTable;
                    dataGridView1.DataSource = bSource;
                    adapter.Update(dataTable);
                    con.Close();

                    sumNumbers();
                }
                catch (Exception ed)
                {
                    con.Close();
                    MessageBox.Show(ed.Message);
                }
            }
            else
                MessageBox.Show("ادخل رقم المستند");
        }//end loadDataIntoGridView1
        
        private void resizeGridView2()
        {
            if (isTextBoxAccNum())
            {
                dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dataGridView2.Columns[0].HeaderText = "رقم الحساب";
                dataGridView2.Columns[1].HeaderText = "اسم الحساب";
            }
            else {
                dataGridView3.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dataGridView3.Columns[0].HeaderText = "رقم الحساب";
                dataGridView3.Columns[1].HeaderText = "اسم الحساب";
            }

        }//end resizeGridView2

        private void loadDataIntoGridView2()
        {
            if (isTextBoxAccNum())
            {
                try
                {
                    con.Open();
                    cmd.CommandText = "SELECT accoNum, accoNameArabic FROM CalculationGuide WHERE used=@used";
                    cmd.Connection = con;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@used", "0");

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
            }//end if
            else
            {   
                try
                {
                    con.Open();
                    cmd.CommandText = "SELECT accoNum, accoNameArabic FROM CalculationGuide WHERE used = @used";
                    cmd.Connection = con;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@used", "0");

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;

                    dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dataTable;
                    dataGridView3.DataSource = bSource;
                    adapter.Update(dataTable);
                    con.Close();
                    resizeGridView2();
                }
                catch (Exception ed)
                {
                    con.Close();
                    MessageBox.Show(ed.Message);
                }

            }//end else

        }//end loadDataIntoGridView23

        private bool isTextBoxAccNum()
        {
            if (textBox_AccNum.Focused == true)
                return true;
            else
                return false;
        }

        private void DailyRestrictions_Load(object sender, EventArgs e){

            textBoxDate.Text = DateTime.Now.ToString("dd / MM / yyyy"); //Date

            if (dataGridView1.RowCount != 0)
                sumNumbers();
            
        }//current date

        private void buttonAdd_DR_Click(object sender, EventArgs e)
        {
            if (textBox_AccNum.Text == "")
            {
                MessageBox.Show("من فضلك تاكد من رقم الحساب");
            }
            else
            {
                insertData();
                loadDataIntoGridView1();
                resizeGridView1();
                sumNumbers();
            }          
        }

        private void insertIntoCalculationGuideDebitor()
        {
            string res1 = getLastNumberInDebitInCalculationGuide();
            string res2 = textBoxCost.Text;

            int resZ = int.Parse(res1) + int.Parse(res2);
            string debitor = resZ.ToString();

            con.Open();
            cmd.CommandText = "UPDATE CalculationGuide SET Debitor= @Debitor WHERE accoNum = @accoNum";
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Debitor", debitor);
            cmd.Parameters.AddWithValue("@accoNum", textBox_AccNum.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private string getLastNumberInDebitInCalculationGuide()
        {
            con.Open();
            string result;
            string sqlquery = "SELECT Debitor FROM CalculationGuide WHERE accoNum = @accoNum";
            SqlCommand command = new SqlCommand(sqlquery, con);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@accoNum", textBox_AccNum.Text);
            result = command.ExecuteScalar().ToString();
            con.Close();
            return result;
        }

        private void sumNumbers(){
            int sumCredit = 0;
            int sumDebit = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i){
                sumCredit += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                sumDebit += Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
            }//end for
            textBoxCredit.Text = sumCredit.ToString();
            textBoxDebit.Text = sumDebit.ToString();
            textBoxTotalCost.Text = (sumDebit - sumCredit).ToString();
        }

        private void insertData(){
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO DailyRestrictions VALUES(@docId, @accNum, @accName," +
                    " @description, @credit, @debit, @enterDate, @refNum, @cost)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@docId", textBoxDocumentNum.Text);
                cmd.Parameters.AddWithValue("@accNum", textBox_AccNum.Text);
                cmd.Parameters.AddWithValue("@accName", textBoxAccName.Text);
                cmd.Parameters.AddWithValue("@description", textBoxDescription.Text);
                cmd.Parameters.AddWithValue("@credit", textBoxEnterCredit.Text);
                cmd.Parameters.AddWithValue("@debit", textBoxEnterDebit.Text);
                cmd.Parameters.AddWithValue("@enterDate", textBoxDate.Text);
                cmd.Parameters.AddWithValue("@refNum", textBoxRefNum.Text);
                cmd.Parameters.AddWithValue("@cost", textBoxCost.Text);
                
                cmd.ExecuteNonQuery();
                con.Close();
            }
            
            catch (Exception ex){
                con.Close();
                MessageBox.Show(ex.Message);
            }
            
        }//end insertData()
        
        private void buttonLoad_DR_Click(object sender, EventArgs e){
            loadDataIntoGridView1();
            resizeGridView1();
            if (dataGridView1.RowCount != 0)
                sumNumbers();
        }

        private void buttonNew_DR_Click(object sender, EventArgs e){
            textBoxDocumentNum.Clear();
            textBoxDocumentNum.Enabled = true;
            buttonAdd_DR.Enabled = true;
        }

        private void buttonDelete_DR_Click(object sender, EventArgs e){
            checkForUsing();
            loadDataIntoGridView1();
            resizeGridView1();
        }
        private void checkForUsing()
        {
            con.Open();
            SqlCommand check_User_Name = new SqlCommand("SELECT * FROM CurrencyInfo WHERE (used = @used)", con);
            check_User_Name.Parameters.AddWithValue("@used", "1");
            SqlDataReader reader = check_User_Name.ExecuteReader();
            if (reader.HasRows)
            {
                //Value Exists
                con.Close();
                MessageBox.Show("لا يمكن مسحها لانها مستخدمة فى العمليات المحاسبية", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //Value NOT Exists
                con.Close();
                deleteDailyRestriction();
                loadDataIntoGridView1();
            }
        }//end checkForUsing()

        #region delete methods the add to database

        private void deleteDailyRestriction()
        {
            //delete multiple rows
            if (dataGridView1.SelectedCells.Count > 0 && dataGridView1.SelectedCells.Count < 2)
            {

                try
                {
                    string value;

                    int i = dataGridView1.CurrentCell.RowIndex;
                    value = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    deleteRecord(value);

                    con.Close();
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
                    MessageBox.Show("تم الحذف");

                }
                catch (Exception er)
                {
                    con.Close();
                    MessageBox.Show(er.Message);
                }

            }//end if
             //THEN
             //////////////////////////////////////

        }//end deleteDailyRestriction

        private void deleteRecord(string value)
        {
            con.Open();
            string sqlquery = "DELETE FROM DailyRestrictions WHERE id = @id";
            SqlCommand command = new SqlCommand(sqlquery, con);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", value);
            command.ExecuteNonQuery();
            con.Close();
        }
        
        private void insertAfterDeleteIntoDb()
        {
            SqlCommand cmd2 = new SqlCommand
                ("Insert into CurrencyInfo(docId, accNum, accName, description, credit, debit) " +
                "values(@docId, @accNum, @accName, @description, @credit, @debit)");
            cmd2.Connection = con;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                cmd2.Parameters.Clear();
                cmd2.Parameters.AddWithValue("@docId", dataGridView1.Rows[i].Cells[1].Value);
                cmd2.Parameters.AddWithValue("@accNum", dataGridView1.Rows[i].Cells[2].Value);
                cmd2.Parameters.AddWithValue("@accName", dataGridView1.Rows[i].Cells[3].Value);
                cmd2.Parameters.AddWithValue("@description", dataGridView1.Rows[i].Cells[4].Value);
                cmd2.Parameters.AddWithValue("@credit", dataGridView1.Rows[i].Cells[5].Value);
                cmd2.Parameters.AddWithValue("@debit", dataGridView1.Rows[i].Cells[6].Value);
                
                cmd2.ExecuteNonQuery();
            }//end for
        }

        #endregion

        private void textBoxAccNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void buttonEdit_DR_Click(object sender, EventArgs e)
        {
            buttonAdd_DR.Enabled = false;
            if (dataGridView1.SelectedCells == null)
            {
                MessageBox.Show("اختر للتعديل");
            }
            else
            {
                int i;
                i = dataGridView1.SelectedCells[0].RowIndex;
                groupBox4.Text = "ستقوم بتعديل بيانات المسلسل:  " + dataGridView1.Rows[i].Cells[0].Value.ToString();
                textBoxDocumentNum.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBox_AccNum.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                textBoxAccName.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                textBoxDescription.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                textBoxEnterDebit.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                textBoxEnterCredit.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();

                if (buttonEdit_DR.Text == "تعديل")
                {
                    buttonEdit_DR.Text = "الغاء التعديل";
                    buttonEditApprove_DR.Enabled = true;
                    dataGridView1.CellClick += dataGridView1_CellClick;

                }
                else if (buttonEdit_DR.Text == "الغاء التعديل")
                {
                    buttonEdit_DR.Text = "تعديل";
                    buttonEditApprove_DR.Enabled = false;
                    groupBox4.Text = null;
                    dataGridView1.CellClick -= dataGridView1_CellClick;

                }
            }
        }//end buttonEdit

        private void buttonEditApprove_DR_Click(object sender, EventArgs e)
        {
            int i  = dataGridView1.SelectedCells[0].RowIndex;
            string number = dataGridView1.Rows[i].Cells[0].Value.ToString();
            editFunction(number);
            loadDataIntoGridView1();
        }

        private void editFunction(string id)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            try
            {
                string sqlquery = "UPDATE DailyRestrictions SET accNum = @accNum, " +
                    " accName = @accName, description = @description," +
                    " credit = @credit, debit = @debit," +
                    " enterDate = @enterDate, refNum = @refNum," +
                    " cost = @cost WHERE id = @id";

                SqlCommand cmd = new SqlCommand(sqlquery, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@accoNum", textBox_AccNum.Text);
                cmd.Parameters.AddWithValue("@accName", textBoxAccName.Text);
                cmd.Parameters.AddWithValue("@description", textBoxDescription.Text);
                cmd.Parameters.AddWithValue("@credit", textBoxEnterCredit.Text);
                cmd.Parameters.AddWithValue("@debit", textBoxEnterDebit.Text);
                cmd.Parameters.AddWithValue("@enterDate", textBoxDate.Text);
                cmd.Parameters.AddWithValue("@refNum", textBoxRefNum.Text);
                cmd.Parameters.AddWithValue("@cost", textBoxCost.Text);
                cmd.Parameters.AddWithValue("@id", id);
                
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم التعديل");
            }
            catch (Exception)
            {
                MessageBox.Show("لا يوجد حساب بهذا الرقم");
            }
        }//edit function

        private void textBoxDocumentNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        
        private void textBoxDocumentNum_Leave(object sender, EventArgs e)
        {
            if (textBoxDocumentNum.Text != "")
            {
                textBoxDocumentNum.Enabled = false;
                loadDataIntoGridView1();
                resizeGridView1();
            }
        }

        private void textBoxEnterDebit_Enter(object sender, EventArgs e)
        {
           // if (textBoxEnterCredit.Text == "" || textBoxEnterCredit.Text == "0")
                //  textBoxEnterCredit.Focus();
            
        }

        private void textBoxEnterCredit_Enter(object sender, EventArgs e)
        {
           // if (textBoxEnterDebit.Text == "" || textBoxEnterDebit.Text != "0")
              //  textBoxEnterDebit.Focus();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;
            groupBox4.Text = "ستقوم بتعديل بيانات المسلسل:  " + dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBoxDocumentNum.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox_AccNum.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBoxAccName.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBoxDescription.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBoxEnterDebit.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            textBoxEnterCredit.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;
            groupBox4.Text = "ستقوم بتعديل بيانات المسلسل:  " + dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBoxDocumentNum.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox_AccNum.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBoxAccName.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBoxDescription.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBoxEnterDebit.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            textBoxEnterCredit.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();

        }

        private void textBox_AccNum_TextChanged(object sender, EventArgs e)
        {
            if (textBox_AccNum.Text == "")
            {
                dataGridView2.Visible = false;
            }
            else
            {
                loadDataIntoGridView2();
                dataGridView2.Visible = true;

                DataView DV = new DataView(dataTable);

                DV.RowFilter = string.Format("Convert([accoNum], System.String) LIKE '{0}%'", textBox_AccNum.Text);
                dataGridView2.DataSource = DV;
            }
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dataGridView2.SelectedCells[0].RowIndex;
            textBox_AccNum.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            textBoxAccName.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            dataGridView2.Visible = false;
            
        }

        private void dataGridView3_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dataGridView3.SelectedCells[0].RowIndex;
            textBox_AccNum.Text = dataGridView3.Rows[i].Cells[0].Value.ToString();
            textBoxAccName.Text = dataGridView3.Rows[i].Cells[1].Value.ToString();
            dataGridView3.Visible = false;
        }

        private void textBoxAccName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAccName.Text == "")
            {
                dataGridView3.Visible = false;
            }
            else
            {
                loadDataIntoGridView2();
                dataGridView3.Visible = true;

                DataView DV = new DataView(dataTable);

                DV.RowFilter = string.Format("accoNameArabic LIKE '%{0}%'", textBoxAccName.Text);
                dataGridView3.DataSource = DV;
            }
        }
        
        private void textBox_AccNum_Leave(object sender, EventArgs e)
        {
            if(dataGridView2.Focused != true)
            dataGridView2.Visible = false;
        }

        private void textBoxAccName_Leave(object sender, EventArgs e)
        {
            if (dataGridView3.Focused != true)
                dataGridView3.Visible = false;
        }

        private void textBoxEnterDebit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
           // if (textBoxEnterCredit.Text !=""|| textBoxEnterCredit.Text != "0")
               // e.Handled = false;
            
    
        }

        private void textBoxEnterCredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxEnterDebit_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEnterCredit.Text != "" || textBoxEnterCredit.Text != "0")
            {
                textBoxEnterDebit.Focus();
            }
        }

        private void textBoxEnterCredit_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEnterDebit.Text != "" || textBoxEnterDebit.Text != "0")
            {
                textBoxEnterCredit.Focus();
            }
        }
    }
}