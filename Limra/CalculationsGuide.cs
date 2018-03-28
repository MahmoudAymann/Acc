using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Limra
{
    public partial class CalculationsGuide : Form
    {
        static string strConneciton = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con = new SqlConnection(strConneciton);
        SqlCommand cmd = new SqlCommand();
               
        public CalculationsGuide(){
            InitializeComponent();
            fillComboBoxCurrency();

            // start off by adding a base treeview node
            addMainNode();
            loadTreeViewFromDataBase();

            checkForActiveNodeAndColorItRed();
            checkForUnActiveNodeAndColorItGreen();
        }

        private void checkForUnActiveNodeAndColorItGreen()
        {
            string value;
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            string sqlquery = "SELECT accoNum FROM CalculationGuide WHERE used = @used";
            SqlCommand command = new SqlCommand(sqlquery, con);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@used", "0");
            SqlDataReader sqlReader;
            sqlReader = command.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dt = new DataTable();
            dt.Load(sqlReader);

            foreach (DataRow row in dt.Rows)
            {
                value = row["accoNum"].ToString();
                TreeNode[] found = treeView1.Nodes.Find(value, true);
                if (!treeView1.Nodes.ContainsKey(value))
                {
                    found[0].ForeColor = Color.Green;
                }
            }//end foreach
        }

        private void checkForActiveNodeAndColorItRed()
        {
            string value;
                if (con.State != ConnectionState.Open)
                {
                    con.Close();
                    con.Open();
                }
                string sqlquery = "SELECT accoNum FROM CalculationGuide WHERE used = @used";
                SqlCommand command = new SqlCommand(sqlquery, con);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@used", "1");
                SqlDataReader sqlReader;
                sqlReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                foreach (DataRow row in dt.Rows)
                {
                    value = row["accoNum"].ToString();
                    TreeNode[] found = treeView1.Nodes.Find(value, true);
                    if (!treeView1.Nodes.ContainsKey(value))
                    {
                            found[0].ForeColor = Color.Red;
                    }
                }//end foreach
        }//end checkForActiveNodeAndColorItRed()
        
        private void addMainNode() {
            TreeNode mainNode = new TreeNode();
            mainNode.Name = "0";
            mainNode.Text = "القائمة الرئيسية";
            mainNode.ForeColor = Color.Blue;
            treeView1.Nodes.Add(mainNode);
        }

        private void fillComboBoxCurrency(){
            string query = "select * from CurrencyInfo";
            cmd.CommandText = query;
            cmd.Connection = con;

            SqlDataReader sqlReader;
            try
            {
                con.Open();
                sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    string col = sqlReader["name"].ToString();
                    comboBoxCuurency.Items.Add(col);
                }

                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }//end fillComboBoxCompanyInfo

        private void buttonAdd_CG_Click(object sender, EventArgs e)
        {
            //////////ADD/////////////

            //addInTreeView();
            string keyNum = textBoxMainAccNum.Text;
            checkForAccountKindAndInsert(keyNum);           
            loadTreeViewFromDataBase();
            textBoxLevel.Clear();
        }//end buttonAdd

        private void checkForAccountKindAndInsert(string key)
        {
            
            if (textBoxMainAccNum.Text != "0")
            {
                string kind;
                
                con.Open();
                string sqlquery = "SELECT accoKind FROM CalculationGuide WHERE accoNum=@accoNum";
                SqlCommand command = new SqlCommand(sqlquery, con);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@accoNum", key);
                kind = command.ExecuteScalar().ToString();
                con.Close();

                if (kind == "رئيسى")
                {
                    insertData();
                }
                else
                {
                    MessageBox.Show("لا يمكن الاضافة على الحساب الفرعى", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
                insertData();

        }

        int level = 1;
        string tmp;

        private void addLevelValue()
        {

            if (textBoxMainAccNum.Text == "0")
            {
                level = 1;
                
                textBoxLevel.Text = level.ToString(); 
            }
            else
            {
                tmp = textBoxAccNum.Text;

                if (textBoxMainAccNum.Text != tmp)
                {
                    getLastLevelValue(textBoxMainAccNum.Text);
                    level += 1; 
                    textBoxLevel.Text = level.ToString();
                }
            }
        }//end method addLevelValue

        private void getLastLevelValue(string asd)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }

            string sqlquery = "SELECT level FROM CalculationGuide WHERE accoNum = @accoNum";
            SqlCommand command = new SqlCommand(sqlquery, con);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@accoNum", asd);
            
            string result = command.ExecuteScalar().ToString();

            level = int.Parse(result);
            con.Close();
        }

        private void insertData()
        {
            try
            {
                string used = "non";

                con.Open();
                cmd.CommandText = "INSERT INTO CalculationGuide VALUES(@mainNum, @accNum," +
                    " @accoNameArabic, @accoKind, @level, @cuurency, @accoNameEnglish," +
                    " @enterDate, @lastClosedMonth, @report," +
                    " @currentCredit, @openningCredit, @Debitor, @Creditor, @used)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@mainNum", textBoxMainAccNum.Text);
                cmd.Parameters.AddWithValue("@accNum", textBoxAccNum.Text);
                cmd.Parameters.AddWithValue("@accoNameArabic", textBoxAccNameArabic.Text);
                cmd.Parameters.AddWithValue("@accoKind", comboBoxKind.Text);
                if (comboBoxKind.Text == "فرعى")
                    used = "0";
                cmd.Parameters.AddWithValue("@level", textBoxLevel.Text);
                cmd.Parameters.AddWithValue("@cuurency", comboBoxCuurency.Text);
                cmd.Parameters.AddWithValue("@accoNameEnglish", textBoxAccNameEnglish.Text);
                cmd.Parameters.AddWithValue("@enterDate", DateTime.Parse(dateTimePicker1.Text));
                cmd.Parameters.AddWithValue("@lastClosedMonth", textBoxLastClosedMonth.Text);
                cmd.Parameters.AddWithValue("@report", comboBoxReport.Text);
                cmd.Parameters.AddWithValue("@currentCredit", textBoxCurrentCredit.Text);
                cmd.Parameters.AddWithValue("@openningCredit", textBoxOpenningCredit.Text);
                cmd.Parameters.AddWithValue("@Debitor", textBoxDebitor.Text);
                cmd.Parameters.AddWithValue("@Creditor", textBoxCreditor.Text);
                cmd.Parameters.AddWithValue("@used", used);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }//end insertData()
        
        private void loadTreeViewFromDataBase(){
            treeView1.Nodes.Clear();
            addMainNode();
            string query = "select mainNum, accoNum, accoNameArabic from CalculationGuide";
            cmd.CommandText = query;
            cmd.Connection = con;

            SqlDataReader sqlReader;
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Close();
                    con.Open();
                }
                sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    string mainNumber = sqlReader["mainNum"].ToString();
                    string accountNumber = sqlReader["accoNum"].ToString();
                    string accountTextName = sqlReader["accoNameArabic"].ToString();

                    // now, do something what you want
                    TreeNode[] found = treeView1.Nodes.Find(mainNumber, true);

                    // Do something with the found node - e.g. add just another node to the found node.
                    try
                    {
                        if (!treeView1.Nodes.ContainsKey(accountNumber))
                        {
                            TreeNode newChild = new TreeNode();
                            newChild.Name = accountNumber;
                            newChild.Text = accountNumber + " " + accountTextName;
                            found[0].Nodes.Add(newChild);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("هذا الحساب موجود");
                    }

                }//end while
                con.Close();
                treeView1.ExpandAll();
                //color nodes
                checkForActiveNodeAndColorItRed();
                checkForUnActiveNodeAndColorItGreen();
            }
            catch (Exception exc)
            {
                con.Close();
                MessageBox.Show(exc.Message);
            }

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            loadTreeViewFromDataBase();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedNodeText = e.Node.Name;
            getAccountInfo(selectedNodeText);
            string num = textBoxAccNum.Text;

            if (buttonEditApprove.Enabled)
                groupBox3.Text = "ستقوم بتعديل حساب رقم: " + num;
            
        }//end AfterSelect

        private void getAccountInfo(string key)
        {
            
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            
            string sqlquery = "SELECT * FROM CalculationGuide WHERE accoNum = @accoNum";
            cmd.Connection = con;
            cmd.CommandText = sqlquery;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@accoNum", key);

            SqlDataReader oReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dt = new DataTable();
            dt.Load(oReader);
            
            foreach (DataRow row in dt.Rows)
            {
                textBoxMainAccNum.Text = row["mainNum"].ToString();
                textBoxAccNum.Text = row["accoNum"].ToString();
                textBoxAccNameArabic.Text = row["accoNameArabic"].ToString();
                comboBoxKind.Text = row["accoKind"].ToString();
                textBoxLevel.Text = row["level"].ToString();
                comboBoxCuurency.Text = row["cuurency"].ToString();
                textBoxAccNameEnglish.Text = row["accoNameEnglish"].ToString();
                DateTime fixedAmountEndDate = (DateTime) row["enterDate"];
                dateTimePicker1.Text = fixedAmountEndDate.ToString();
                textBoxLastClosedMonth.Text = row["lastClosedMonth"].ToString();
                comboBoxReport.Text = row["report"].ToString();
                textBoxCurrentCredit.Text = row["currentCredit"].ToString();
                textBoxOpenningCredit.Text = row["openningCredit"].ToString();
                textBoxDebitor.Text = row["Debitor"].ToString();
                textBoxCreditor.Text = row["Creditor"].ToString();
            }

            con.Close();
        }//end method getAccountInfo

        private void textBoxMainAccNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxAccNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string accountNumber = textBoxAccNum.Text;
            if (checkBeforeDelete(accountNumber))  //true
            {
                deleteApproach();
            }
            else {
                MessageBox.Show("لا يمكن مسح حساب مربوط");
            }
            
        }

        private bool checkBeforeDelete(string accountNum)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            string sqlquery = "SELECT used FROM CalculationGuide WHERE accoNum=@accoNum";
            SqlCommand command = new SqlCommand(sqlquery, con);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@accoNum", accountNum);
            string result = command.ExecuteScalar().ToString();
            if (result == "1")
            {
                con.Close();
                return false;
            }
            else
            {
                con.Close();
                return true;
            }
        }

        private void deleteApproach()
        {
            if (textBoxAccNum.Text != null)
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Close();
                    con.Open();
                }

                //delete child first
                try
                {
                    string sqlquery1 = "DELETE FROM CalculationGuide WHERE mainNum = @mainNum";
                    SqlCommand command1 = new SqlCommand(sqlquery1, con);
                    command1.Parameters.Clear();
                    command1.Parameters.AddWithValue("@mainNum", textBoxAccNum.Text);
                    command1.ExecuteNonQuery();
                }
                catch
                {
                    return;
                }
                //delete the node
                string sqlquery = "DELETE FROM CalculationGuide WHERE accoNum = @accoNum";
                SqlCommand command = new SqlCommand(sqlquery, con);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@accoNum", textBoxAccNum.Text);
                command.ExecuteNonQuery();
                con.Close();

                loadTreeViewFromDataBase();
            }
            else
            {
                MessageBox.Show("ادخل رقم الحساب المراد حذفه اولا");
            }
        }

        private void comboBoxKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBoxMainAccNum != null && textBoxAccNum != null)
            {
                addLevelValue();
            }
        }

        private void buttonNew_CG_Click(object sender, EventArgs e)
        {
            clearAllField();
            buttonAdd.Enabled = true;
        }

        private void clearAllField(){
            textBoxAccNum.Clear();
            textBoxMainAccNum.Clear();
            textBoxAccNameArabic.Clear();
            comboBoxKind.Text = " ";
            textBoxLevel.Clear();
            comboBoxCuurency.Text = " ";
            textBoxAccNameEnglish.Clear();
            textBoxLastClosedMonth.Clear();
            comboBoxReport.Text = " ";
            textBoxCurrentCredit.Clear();
            textBoxOpenningCredit.Clear();
            textBoxDebitor.Clear();
            textBoxCreditor.Clear();
        }

        private void textBoxAccNameArabic_Leave(object sender, EventArgs e)
        {
            if (textBoxMainAccNum != null && textBoxAccNum != null)
            {
                addLevelValue();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxAccNum.Text != "")
            {
                string num = textBoxAccNum.Text;
                if (buttonEdit.Text == "تعديل")
                {
                    MessageBox.Show("تم فتح التعديل الان", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ///////////////
                    buttonEdit.Text = "الغاء التعديل";
                    buttonEditApprove.Enabled = true;
                    /////////////////
                    textBoxMainAccNum.Enabled = false;
                    buttonAdd.Enabled = false;
                    /////////////////
                    groupBox3.Text = "ستقوم بتعديل حساب رقم: " + num;
                    changeGroupBox3Colors("1");
                }
                else
                {
                    buttonEdit.Text = "تعديل";
                    buttonEditApprove.Enabled = false;
                    ////////////////////////////
                    textBoxMainAccNum.Enabled = true;
                    groupBox3.Text = "بيانات الحساب الاساسية";
                    changeGroupBox3Colors("0");
                }
            }
            else
            {
                MessageBox.Show("ادخل رقم الحساب للتعديل", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void changeGroupBox3Colors(string num)
        {
            if (num == "1")
            {
                groupBox3.ForeColor = Color.Red;
                labelMainAccNum.ForeColor = Color.Black;
                labelAccoNum.ForeColor = Color.Black;
                labelNameArab.ForeColor = Color.Black;
                labelAccKind.ForeColor = Color.Black;
                labelLevel.ForeColor = Color.Black;
                labelCurrency.ForeColor = Color.Black;
            }
            else
                groupBox3.ForeColor = Color.Black;
            

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
                string sqlquery = "UPDATE CalculationGuide SET accoNameArabic = @accoNameArabic, " +
                    " accoKind = @accoKind, level = @level," +
                    " cuurency = @cuurency, accoNameEnglish = @accoNameEnglish," +
                    " enterDate = @enterDate, lastClosedMonth = @lastClosedMonth," +
                    " report = @report , currentCredit = @currentCredit," +
                    " openningCredit = @openningCredit, Debitor = @Debitor," +
                    " Creditor = @Creditor WHERE accoNum = @accoNum";

                SqlCommand cmd = new SqlCommand(sqlquery, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@accoNum", textBoxAccNum.Text);
                cmd.Parameters.AddWithValue("@accoNameArabic", textBoxAccNameArabic.Text);
                cmd.Parameters.AddWithValue("@accoKind", comboBoxKind.Text);
                cmd.Parameters.AddWithValue("@level", textBoxLevel.Text);
                cmd.Parameters.AddWithValue("@cuurency", comboBoxCuurency.Text);
                cmd.Parameters.AddWithValue("@accoNameEnglish", textBoxAccNameEnglish.Text);
                cmd.Parameters.AddWithValue("@enterDate", DateTime.Parse(dateTimePicker1.Text));
                cmd.Parameters.AddWithValue("@lastClosedMonth", textBoxLastClosedMonth.Text);
                cmd.Parameters.AddWithValue("@report", comboBoxReport.Text);
                cmd.Parameters.AddWithValue("@currentCredit", textBoxMainAccNum.Text);
                cmd.Parameters.AddWithValue("@openningCredit", textBoxMainAccNum.Text);
                cmd.Parameters.AddWithValue("@Debitor", textBoxMainAccNum.Text);
                cmd.Parameters.AddWithValue("@Creditor", textBoxMainAccNum.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم التعديل");
            }
            catch (Exception)
            {
                MessageBox.Show("لا يوجد حساب بهذا الرقم");
            }
        }//edit function

        private void buttonEditApprove_Click(object sender, EventArgs e)
        {
            editFunction();
            loadTreeViewFromDataBase();
            buttonEditApprove.Enabled = false;
            textBoxMainAccNum.Enabled = true;
        }

        private void textBoxAccNum_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxMainAccNum.Text) && !string.IsNullOrEmpty(textBoxAccNum.Text))
            {
                addLevelValue();
            }
        }

        private void textBoxMainAccNum_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxMainAccNum.Text))
            {
                if (textBoxMainAccNum.Text != "0")
                {
                    con.Open();
                    SqlCommand check_User_Name = new SqlCommand("SELECT * FROM CalculationGuide WHERE (accoNum = @accoNum)", con);
                    check_User_Name.Parameters.AddWithValue("@accoNum", textBoxMainAccNum.Text);
                    SqlDataReader reader = check_User_Name.ExecuteReader();
                    if (reader.HasRows)
                    {
                        //User Exists
                        con.Close();
                        try
                        {
                            string kind;
                            con.Open();
                            string sqlquery = "SELECT accoKind FROM CalculationGuide WHERE accoNum=@accoNum";
                            SqlCommand command = new SqlCommand(sqlquery, con);
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@accoNum", textBoxMainAccNum.Text);
                            kind = command.ExecuteScalar().ToString();
                            con.Close();

                            if (kind == "فرعى")
                            {
                                MessageBox.Show("لا يمكن الاضافة على الحساب الفرعى", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("تاكد من ادخال الرقم بشكل صحيح", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //User NOT Exists
                        //........................
                        MessageBox.Show("هذا الرقم غير موجود");
                    }
                }//end if
            }//end if   
        }
    }//end class
}//end namespace