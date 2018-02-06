using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Limra
{
    public partial class VocherOfRecievable : Form
    {
        #region connection settings
        private const string strconneciton = @"Data Source=SPECTRA5;Initial Catalog=Limra;Integrated Security=True;TrustServerCertificate=False";
        SqlConnection con = new SqlConnection(strconneciton);
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable, dataTableBoxes, dataTableBanks, dataTableAccounts;
        #endregion

        public VocherOfRecievable()
        {
            InitializeComponent();
            textBoxEnterDate.Text = DateTime.Now.ToString("dd / MM / yyyy");
        }

        #region resize and load data into DataGridView
        //OriginalDatBase
        private void resizeGridView1()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView1.Columns[0].HeaderText = "م";
            dataGridView1.Columns[1].HeaderText = "نوع المستند";
            dataGridView1.Columns[2].HeaderText = "التاريخ";
            dataGridView1.Columns[3].HeaderText = "البيان";
            dataGridView1.Columns[4].HeaderText = "رقم الحساب";
            dataGridView1.Columns[5].HeaderText = "اسم الحساب";
            dataGridView1.Columns[6].HeaderText = "ملاحظات";
            dataGridView1.Columns[7].HeaderText = "المبلغ";
            dataGridView1.Columns[8].HeaderText = "رقم المرجع";

        }//end resizeGridView1
        private void loadDataIntoGridView1()
        {
            if (textBoxDocNum.Text != "" && textBoxNum.Text != "")
            {
                string kind = "";
                if (radioButtonCash.Checked)
                {
                    kind = radioButtonCash.Text;
                }
                else if (radioButtonChique.Checked)
                {
                    kind = radioButtonChique.Text;
                }
                else
                {
                    MessageBox.Show("اختر نقدى او شيك");
                }
                try
                {
                    con.Open();
                    cmd.CommandText = "SELECT Id, docKind, enterDate, boxDescription, accNum," +
                        " accName, notes, cost, refrencer FROM VocherOfRecievable" +
                        " WHERE docID = @docID AND boxNum = @boxNum AND docKind = @docKind";

                    cmd.Connection = con;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@docId", textBoxDocNum.Text);
                    cmd.Parameters.AddWithValue("@boxNum", textBoxNum.Text);
                    cmd.Parameters.AddWithValue("@docKind", kind);

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
                    labelTotalSum.Text = sumBoxNumbersTOCreditor();
                }
                catch (Exception ed)
                {
                    con.Close();
                    MessageBox.Show(ed.Message);
                }
            }
            else
            {
                if (dataGridView1.DataSource != null)
                {

                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                }
            }
        }//end loadDataIntoGridView1

        //Box
        private void resizeGridView2_Box()
        {
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView2.Columns[0].HeaderText = "رقم الصندوق";
            dataGridView2.Columns[1].HeaderText = "اسم حساب الصندوق";


        }//end resizeGridView2_Box 
        private void loadDataIntoGridView2_Boxes()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT num, accName FROM Boxes";
                cmd.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                dataTableBoxes = new DataTable();
                adapter.Fill(dataTableBoxes);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = dataTableBoxes;

                dataGridView2.DataSource = bSource;
                adapter.Update(dataTableBoxes);
                con.Close();
            }
            catch (Exception ed)
            {
                con.Close();
                MessageBox.Show(ed.Message);
            }
        }//end loadDataIntoGridView2_Boxes

        //Bank
        private void resizeGridView2_Bank()
        {
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView2.Columns[0].HeaderText = "رقم البنك";
            dataGridView2.Columns[1].HeaderText = "اسم حساب البنك";

        }//end resizeGridView2_Bank 
        private void loadDataIntoGridView2_Banks()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT num, accName FROM Banks";
                cmd.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                dataTableBanks = new DataTable();
                adapter.Fill(dataTableBanks);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = dataTableBanks;

                dataGridView2.DataSource = bSource;
                adapter.Update(dataTableBanks);

                con.Close();
            }
            catch (Exception ed)
            {
                con.Close();
                MessageBox.Show(ed.Message);
            }
        }//end loadDataIntoGridView2_Banks

        //Accounts
        private void resizeGridView3()
        {
            dataGridView3.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView3.Columns[0].HeaderText = "رقم الحساب";
            dataGridView3.Columns[1].HeaderText = "اسم الحساب";
        }//end resizeGridView3
        private void loadDataIntoGridView3()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT accoNum, accoNameArabic FROM CalculationGuide WHERE accoKind=@accoKind AND used=@used";
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@accoKind", "فرعى");
                cmd.Parameters.AddWithValue("@used", "0");

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                dataTableAccounts = new DataTable();
                adapter.Fill(dataTableAccounts);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = dataTableAccounts;

                dataGridView3.DataSource = bSource;
                adapter.Update(dataTableAccounts);
                con.Close();
            }
            catch (Exception ed)
            {
                con.Close();
                MessageBox.Show(ed.Message);
            }
        }//end loadDataIntoGridView3
        #endregion

        private string getBankAccNumber()
        {
            string result;
            con.Open();
            string sqlquery = "SELECT accNum FROM Banks WHERE num=@num";
            SqlCommand command = new SqlCommand(sqlquery, con);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@num", textBoxNum.Text);
            result = command.ExecuteScalar().ToString();
            con.Close();
            return result;
        }//end getBoxAccNumber

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            loadDataIntoGridView1();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
          //  if (allCostsEqual()) //make sure totalCost = boxCost
           // {
                if (textBoxAccNum.Text != "" && textBoxNum.Text != "")
                {

                    insertIntoVocher();

                    insertIntoCalculationGuideDebitor(); //insert Debit in Acc //madin

                    loadDataIntoGridView1();
                    resizeGridView1();

                    labelTotalSum.Text = sumBoxNumbersTOCreditor();
                    insertIntoCalculationGuideCreditorForBox(textBoxBoxCost.Text); //da2n

                    if (radioButtonCash.Checked)
                        setBoxUsedToOne();

                    else if (radioButtonChique.Checked)
                        setBankUsedToOne();

                }
                else
                    MessageBox.Show("تاكد من ادخال البيانات كامله صحيحة");
          //  }
           // else
              //  MessageBox.Show("يجب ان يكون المبلغ متساوٍ");
        }

        private bool allCostsEqual()
        {
            int cost1 = int.Parse(textBoxBoxCost.Text);
            int cost2 = int.Parse(labelTotalSum.Text);
            if (cost1 == cost2)
                return true;
            else
                return false;
        }

        #region Boxes set Used 0 1
        private void setBoxUsedToOne()
        {
            con.Open();
            cmd.CommandText = "UPDATE Boxes SET used= @used WHERE num = @num";
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@used", "1");
            cmd.Parameters.AddWithValue("@num", textBoxNum.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void setBoxUsedToZero(string numBox)
        {
            con.Open();
            cmd.CommandText = "UPDATE Boxes SET used= @used WHERE num = @num";
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@used", "0");
            cmd.Parameters.AddWithValue("@num", numBox);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion

        #region Banks set Used 0 1
        private void setBankUsedToOne()
        {
            con.Open();
            cmd.CommandText = "UPDATE Banks SET used= @used WHERE num = @num";
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@used", "1");
            cmd.Parameters.AddWithValue("@num", textBoxNum.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void setBankUsedToZero(string numBox)
        {
            con.Open();
            cmd.CommandText = "UPDATE Banks SET used= @used WHERE num = @num";
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@used", "0");
            cmd.Parameters.AddWithValue("@num", textBoxNum.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        #endregion

        #region add methods
        private string lastNumberInDebitInCalculationGuide()
        {
            con.Open();
            string result;
            string sqlquery = "SELECT Debitor FROM CalculationGuide WHERE accoNum = @accoNum";
            SqlCommand command = new SqlCommand(sqlquery, con);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@accoNum", textBoxAccNum.Text);
            result = command.ExecuteScalar().ToString();
            con.Close();
            return result;
        }

        private void insertIntoCalculationGuideDebitor()
        {
            string res1 = lastNumberInDebitInCalculationGuide();
            string res2 = textBoxCost.Text;

            int resZ = int.Parse(res1) + int.Parse(res2);
            string debitor = resZ.ToString();

            con.Open();
            cmd.CommandText = "UPDATE CalculationGuide SET Debitor= @Debitor WHERE accoNum = @accoNum";
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Debitor", debitor);
            cmd.Parameters.AddWithValue("@accoNum", textBoxAccNum.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void insertIntoCalculationGuideCreditorForBox(string sumTotal)
        {
            string accNum;
            if (radioButtonCash.Checked)
                accNum = getBoxAccNumberFromBoxNumber();

            else if (radioButtonChique.Checked)
                accNum = getBankAccNumberFromBankNumber();
            else
                accNum = "";

            con.Open();
            cmd.CommandText = "UPDATE CalculationGuide SET Creditor= @Creditor WHERE accoNum = @accoNum";
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Creditor", sumTotal);
            cmd.Parameters.AddWithValue("@accoNum", accNum);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private string getBankAccNumberFromBankNumber()
        {
            con.Open();
            string sqlquery = "SELECT accNum FROM Banks WHERE num=@num";
            SqlCommand command = new SqlCommand(sqlquery, con);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@num", textBoxNum.Text);
            string accNum = command.ExecuteScalar().ToString();
            con.Close();
            return accNum;
        }

        private string getBoxAccNumberFromBoxNumber()
        {

            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            string sqlquery = "SELECT accNum FROM Boxes WHERE num=@num";
            SqlCommand command = new SqlCommand(sqlquery, con);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@num", textBoxNum.Text);
            string accNum = command.ExecuteScalar().ToString();
            con.Close();
            return accNum;
        }

        private string sumBoxNumbersTOCreditor() //method to sum to put in the box num related into CalculationGuide
        {
            string result = "";
            con.Open();
            cmd.CommandText = "SELECT SUM (cost) FROM VocherOfRecievable WHERE docID=@docID";
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@docID", textBoxDocNum.Text);
            SqlDataReader oReader = cmd.ExecuteReader();
            while (oReader.Read())
            {
                result = oReader[0].ToString();
            }
            con.Close();
            return result;
        }

        private void insertIntoVocher()
        {
            try
            {
                string docKind = "";
                string boxAccNum = getBoxAccNumberFromBoxNumber();
                if (radioButtonCash.Checked)
                    docKind = radioButtonCash.Text;

                else if (radioButtonChique.Checked)
                    docKind = radioButtonChique.Text;

                con.Open();
                cmd.CommandText = "INSERT INTO VocherOfRecievable" +
                " (docID, docKind, boxNum, boxAccNum, boxName, boxDescription, boxCost, accNum, accName, notes, cost, enterDate, refrencer)" +
                " VALUES(@docID, @docKind, @boxNum, @boxAccNum,@boxName, @boxDescription, @boxCost, @accNum, @accName, @notes, @cost,@enterDate,@refrencer)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@docID", textBoxDocNum.Text);
                cmd.Parameters.AddWithValue("@docKind", docKind);
                cmd.Parameters.AddWithValue("@boxNum", textBoxNum.Text);
                cmd.Parameters.AddWithValue("@boxAccNum", boxAccNum);
                cmd.Parameters.AddWithValue("@boxName", textBoxName.Text);
                cmd.Parameters.AddWithValue("@boxDescription", textBoxDescription.Text);
                cmd.Parameters.AddWithValue("@boxCost", textBoxBoxCost.Text);
                cmd.Parameters.AddWithValue("@accNum", textBoxAccNum.Text);
                cmd.Parameters.AddWithValue("@accName", textBoxAccName.Text);
                cmd.Parameters.AddWithValue("@notes", textBoxNotes.Text);
                cmd.Parameters.AddWithValue("@cost", textBoxCost.Text);
                cmd.Parameters.AddWithValue("@enterDate", textBoxEnterDate.Text);
                cmd.Parameters.AddWithValue("@refrencer", textBoxRef.Text);

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                int i;
                i = dataGridView1.SelectedCells[0].RowIndex;
                string value = dataGridView1.Rows[i].Cells[4].Value.ToString();
                //get value to store it 
                string boxNumber = getVocherOfRecievable_boxNumber(value);
                string docKind = dataGridView1.Rows[i].Cells[1].Value.ToString();
                //delete first
                deleteBoxInfoFromGridView();

                //then check for box exist
                if (searchForBoxExist(boxNumber) == true)
                {
                    MessageBox.Show("exist");
                }
                else
                {
                    if (docKind == radioButtonCash.Text)
                    {
                        setBoxUsedToZero(boxNumber);
                        MessageBox.Show("Box Account not exist now");
                    }
                    else if (docKind == radioButtonChique.Text)
                    {
                        setBankUsedToZero(boxNumber);
                        MessageBox.Show("Bank Account not exist now");
                    }
                }
                #region dataGridView For nullity aand RESEED counter (Id) to 1
                if (dataGridView1.Rows.Count > 1 && dataGridView1.Rows != null)
                {
                    loadDataIntoGridView1();
                    resizeGridView1();

                }
                else
                {
                    doTruncate();
                    loadDataIntoGridView1();
                    resizeGridView1();
                    MessageBox.Show("اضف بعض  ");

                }
                #endregion
            }
            else
                MessageBox.Show("اضف بعض العناصر اولاً");

        }//end button Delete

        #region delete methods
        private void deleteBoxInfoFromGridView()
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                try
                {
                    string value;
                    int i = dataGridView1.CurrentCell.RowIndex;
                    value = dataGridView1.Rows[i].Cells[0].Value.ToString(); //accNumber

                    deleteRecordFromDatabase(value);

                    MessageBox.Show("تم المسح");
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
            string sqlquery = "DELETE FROM VocherOfRecievable WHERE id = @id";
            SqlCommand command = new SqlCommand(sqlquery, con);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", value);
            command.ExecuteNonQuery();
            con.Close();
        }
        private bool searchForBoxExist(string boxNumber)
        {
            con.Open();
            SqlCommand check_Box_Num = new SqlCommand("SELECT * FROM VocherOfRecievable WHERE boxNum=@boxNum", con);
            check_Box_Num.Parameters.Clear();
            check_Box_Num.Parameters.AddWithValue("@boxNum", boxNumber);
            SqlDataReader reader = check_Box_Num.ExecuteReader();
            if (reader.HasRows)
            {
                //User Exists
                con.Close();
                return true;
            }
            else
            {
                //User NOT Exists
                //.............
                con.Close();
                return false;
            }
        }
        private void doTruncate()
        {
            con.Open();
            string sql = "Truncate Table VocherOfRecievable";
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion

        #region radioButton Events
        private void radioButtonCash_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCash.Checked)
            {
                labelBoxAccNum.Text = "رقم حساب الصندوق:";
                labelBoxAccName.Text = "اسم حساب الصندوق:";
                labelDescription.Text = "بيان صندوق:";

                groupBoxInfo2.Text = "بيانات الصندوق(الصادر" + ")";

                textBoxNum.Enabled = true;
                textBoxName.Enabled = true;
            }

            if (dataGridView2.DataSource != null)
            {
                dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();
            }
        }

        private void radioButtonChique_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonChique.Checked)
            {
                labelBoxAccNum.Text = "رقم حساب البنك:";
                labelBoxAccName.Text = "اسم حساب البنك:";
                labelDescription.Text = "بيان بنك:";

                groupBoxInfo2.Text = "بيانات البنك(الصادر" + ")";

                textBoxNum.Enabled = true;
                textBoxName.Enabled = true;
            }

            if (dataGridView2.DataSource != null)
            {
                dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();
            }
        }
        #endregion

        private void buttonNew_Click(object sender, EventArgs e)
        {
            //textboxNum & Name
            textBoxNum.Enabled = true;
            textBoxName.Enabled = true;
            textBoxName.Clear();
            textBoxNum.Clear();

            //docNumber
            textBoxDocNum.Clear();
            textBoxDocNum.Enabled = true;


        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            new CrysRepVocherOfExchangeFrom().Show();
        }

        private void textBoxDocNum_Leave(object sender, EventArgs e)
        {
            if (textBoxDocNum.Text != "")
            {
                textBoxDocNum.Enabled = false;
            }
        }

        #region dataGridView CellDoubleClick

        #region dataGridView1_CellMouseDoubleClick
        private string getVocherOfRecievable_docID(string num)
        { // get docID
            string results;
            con.Open();
            string sqlquery = "SELECT docID FROM VocherOfRecievable WHERE accNum=@accNum";
            SqlCommand command = new SqlCommand(sqlquery, con);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@accNum", num);
            results = command.ExecuteScalar().ToString();
            con.Close();
            return results;
        }

        private string getVocherOfRecievable_boxNumber(string num)
        { // get boxNumber
            string results;
            con.Open();
            string sqlquery = "SELECT boxNum FROM VocherOfRecievable WHERE accNum=@accNum";
            SqlCommand command = new SqlCommand(sqlquery, con);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@accNum", num);
            results = command.ExecuteScalar().ToString();
            con.Close();
            return results;
        }
        private string getVocherOfRecievable_boxName(string num)
        { // get boxName
            string results;
            con.Open();
            string sqlquery = "SELECT boxName FROM VocherOfRecievable WHERE accNum=@accNum";
            SqlCommand command = new SqlCommand(sqlquery, con);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@accNum", num);
            results = command.ExecuteScalar().ToString();
            con.Close();
            return results;
        }

        private string getVocherOfRecievable_boxCost(string num)
        { // get boxName
            string results;
            con.Open();
            string sqlquery = "SELECT boxCost FROM VocherOfRecievable WHERE accNum=@accNum";
            SqlCommand command = new SqlCommand(sqlquery, con);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@accNum", num);
            results = command.ExecuteScalar().ToString();
            con.Close();
            return results;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxNum.TextChanged -= textBoxNum_TextChanged;
            textBoxName.TextChanged -= textBoxName_TextChanged;
            textBoxAccNum.TextChanged -= textBoxAccNum_TextChanged;
            textBoxAccName.TextChanged -= textBoxAccName_TextChanged;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string kind;
                kind = row.Cells[1].Value.ToString();
                if (kind == radioButtonCash.Text)
                    radioButtonCash.Checked = true;
                else
                    radioButtonChique.Checked = true;

                string accNumber = row.Cells[4].Value.ToString();

                textBoxEnterDate.Text = row.Cells[2].Value.ToString();      //date
                textBoxDescription.Text = row.Cells[3].Value.ToString();
                textBoxAccNum.Text = accNumber;
                textBoxAccName.Text = row.Cells[5].Value.ToString();
                textBoxNotes.Text = row.Cells[6].Value.ToString();
                textBoxCost.Text = row.Cells[7].Value.ToString();
                textBoxRef.Text = row.Cells[8].Value.ToString();

                textBoxDocNum.Text = getVocherOfRecievable_docID(accNumber); //docID
                textBoxNum.Text = getVocherOfRecievable_boxNumber(accNumber);
                textBoxName.Text = getVocherOfRecievable_boxName(accNumber);
                textBoxCost.Text = getVocherOfRecievable_boxCost(accNumber); //boxCost
            }
        }
        #endregion

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxNum.TextChanged -= textBoxNum_TextChanged;
            textBoxName.TextChanged -= textBoxName_TextChanged;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                textBoxNum.Text = row.Cells[0].Value.ToString();
                textBoxName.Text = row.Cells[1].Value.ToString();
            }
            textBoxNum.TextChanged += textBoxNum_TextChanged;
            textBoxName.TextChanged += textBoxName_TextChanged;

            textBoxNum.Enabled = false;
            textBoxName.Enabled = false;
        }
        private void dataGridView3_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxAccNum.TextChanged -= textBoxAccNum_TextChanged;
            textBoxAccName.TextChanged -= textBoxAccName_TextChanged;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView3.Rows[e.RowIndex];

                textBoxAccNum.Text = row.Cells[0].Value.ToString();
                textBoxAccName.Text = row.Cells[1].Value.ToString();
            }
            textBoxAccNum.TextChanged += textBoxAccNum_TextChanged;
            textBoxAccName.TextChanged += textBoxAccName_TextChanged;
        }
        #endregion

        private void textBoxDocNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        #region //Boxes//OR//Banks //TextBoxEvents
        private void groupBoxInfo2_Leave(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();

            dataGridView2.Visible = false;
        }

        private void textBoxNum_Enter(object sender, EventArgs e)
        {
            if (radioButtonCash.Checked != true && radioButtonChique.Checked != true)
            {
                MessageBox.Show("الرجاء اختيار عملية الصرف: نقدى او شيك");
                radioButtonCash.Focus();
            }
        }//end 

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (radioButtonCash.Checked != true && radioButtonChique.Checked != true)
            {
                MessageBox.Show("الرجاء اختيار عملية الصرف: نقدى او شيك");
                radioButtonCash.Focus();
            }
        }

        private void textBoxNum_TextChanged(object sender, EventArgs e) //nums
        {
            if (radioButtonCash.Checked)
            {
                if (dataGridView2.DataSource == null)
                {
                    loadDataIntoGridView2_Boxes();
                    resizeGridView2_Box();
                }

                dataGridView2.Visible = true;

                DataView DV = new DataView(dataTableBoxes);

                DV.RowFilter = string.Format(" Convert([num], System.String) LIKE '%{0}%' ", textBoxNum.Text);

                dataGridView2.DataSource = DV;
            }

            else if (radioButtonChique.Checked)
            {
                if (dataGridView2.DataSource == null)
                {
                    loadDataIntoGridView2_Banks();
                    resizeGridView2_Bank();
                }

                dataGridView2.Visible = true;

                DataView DV = new DataView(dataTableBanks);

                DV.RowFilter = string.Format(" Convert([num], System.String) LIKE '%{0}%' ", textBoxNum.Text);
                dataGridView2.DataSource = DV;
            }//end else if
            else
            {
                MessageBox.Show("الرجاء اختيار عملية الصرف: نقدى او شيك");
                radioButtonCash.Focus();
            }

            if (dataGridView1.DataSource != null || textBoxNum.Text == "")
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
            }
            if (textBoxNum.Text != "")
            {
                loadDataIntoGridView1();
                resizeGridView1();
            }
        }//end txt event

        private void textBoxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonCash.Checked)
            {
                if (dataGridView2.DataSource == null)
                {
                    loadDataIntoGridView2_Boxes();
                    resizeGridView2_Box();
                }

                dataGridView2.Visible = true;

                DataView DV = new DataView(dataTableBoxes);
                DV.RowFilter = string.Format("accName LIKE '%{0}%'", textBoxName.Text);
                dataGridView2.DataSource = DV;

            }//end if

            else if (radioButtonChique.Checked)
            {
                if (dataGridView2.DataSource == null)
                {
                    loadDataIntoGridView2_Banks();
                    resizeGridView2_Bank();
                }

                dataGridView2.Visible = true;

                DataView DV = new DataView(dataTableBanks);

                DV.RowFilter = string.Format("accName LIKE '%{0}%'", textBoxName.Text);
                dataGridView2.DataSource = DV;

                if (dataGridView1.DataSource != null || textBoxName.Text == "")
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                }
                if (textBoxName.Text != "")
                {
                    loadDataIntoGridView1();
                    resizeGridView1();
                }

            }//end if else
            else
            {
                MessageBox.Show("الرجاء اختيار عملية الصرف: نقدى او شيك");
                radioButtonCash.Focus();
            }//end else

        }//end text event
        #endregion

        #region Acoounts Info
        private void textBoxAccNum_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAccName.Text == "" && textBoxAccNum.Text == "")
            {
                dataGridView3.Visible = false;
            }

            if (dataGridView3.DataSource == null)
            {
                loadDataIntoGridView3();
                resizeGridView3();
            }
            DataView DV = new DataView(dataTableAccounts);

            DV.RowFilter = string.Format(" Convert([accoNum], System.String) LIKE '{0}%' ", textBoxAccNum.Text);
            dataGridView3.DataSource = DV;

            dataGridView3.Visible = true;

        }

        private void needUpdate(string txtAccNum, string txtAccName)
        {
            dataTableAccounts.Rows.Add(new Object[] {
                txtAccNum,txtAccName
            });

        }

        private void groupBox5_Leave(object sender, EventArgs e)
        {
            dataGridView3.Visible = false;
        }
        
        private void textBoxAccName_Enter(object sender, EventArgs e)
        {
            if (textBoxAccName.Text == "" && textBoxAccNum.Text == "")
            {
                dataGridView3.Visible = false;
            }
        }

        private void textBoxAccName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAccName.Text == "" && textBoxAccNum.Text == "")
            {
                dataGridView3.Visible = false;
            }
            if (dataGridView3.DataSource == null)
            {
                loadDataIntoGridView3();
                resizeGridView3();
            }

            DataView DV = new DataView(dataTableAccounts);

            DV.RowFilter = string.Format("accoNameArabic LIKE '%{0}%' ", textBoxAccName.Text);
            dataGridView3.DataSource = DV;

            dataGridView3.Visible = true;
        }

        private void textBoxAccNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        #endregion



    }//end class
}//end namespace