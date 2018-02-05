using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Limra
{
    public partial class CurrencyInfo : Form
    {
        private const string strconneciton = @"Data Source=SPECTRA5;Initial Catalog=Limra;Integrated Security=True;TrustServerCertificate=False";
        SqlConnection con = new SqlConnection(strconneciton);
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable;

        public CurrencyInfo()
        {
            InitializeComponent();
            loadDataIntoGridView();
            resizeGridView();
            cancelTextEvents();
            //dataGridView1.CellClick -= dataGridView1_CellClick;
        }

        private void resizeGridView()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns[0].HeaderText = "م";
            dataGridView1.Columns[1].HeaderText = "اسم العملة";
            dataGridView1.Columns[2].HeaderText = "الرمز";
            dataGridView1.Columns[3].HeaderText = "الفكة";
            dataGridView1.Columns[4].HeaderText = "نوع العملة";

        }

        private void loadDataIntoGridView()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT id, name, nickname, change, currencykind FROM CurrencyInfo";
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
                MessageBox.Show(ed.Message);
                con.Close();
            }
        }

        private void buttonSearch_CI_Click(object sender, EventArgs e)
        {//////SEARCH////////////
            if (buttonSearch_CI.Text == "بحث")
            {
                buttonSearch_CI.Text = "الغاء البحث";
                activateTextEvents();
                radioButtonAll.Enabled = true;
                textBoxCurrencyName.Enabled = true;
                textBoxNickname.Enabled = true;
            }
            else if (buttonSearch_CI.Text == "الغاء البحث")
            {
                buttonSearch_CI.Text = "بحث";
                cancelTextEvents();
                radioButtonAll.Enabled = false;
            }
        }

        private void cancelTextEvents()
        {
            textBoxCurrencyName.TextChanged -= textBoxCurrencyName_TextChanged;
            textBoxNickname.TextChanged -= textBoxNickname_TextChanged;
            textBoxChange.TextChanged -= textBoxChange_TextChanged;

            radioButton_local.CheckedChanged -= radioButton_local_CheckedChanged;
            radioButtonForeign.CheckedChanged -= radioButtonForeign_CheckedChanged;
            radioButtonForeign.Checked = false;
            radioButton_local.Checked = false;
            radioButtonAll.Checked = false;
            loadDataIntoGridView();
        }//end

        private void activateTextEvents()
        {
            textBoxCurrencyName.TextChanged += textBoxCurrencyName_TextChanged;
            textBoxNickname.TextChanged += textBoxNickname_TextChanged;
            textBoxChange.TextChanged += textBoxChange_TextChanged;

            radioButton_local.CheckedChanged += radioButton_local_CheckedChanged;
            radioButtonForeign.CheckedChanged += radioButtonForeign_CheckedChanged;
            radioButtonForeign.Checked = false;
            radioButton_local.Checked = false;
            radioButtonAll.Checked = false;
        }//end

        private void buttonLoad_CI_Click(object sender, EventArgs e)
        {//////LOAD//////////////
            loadDataIntoGridView();
        }

        private void buttonAdd_CI_Click(object sender, EventArgs e)
        {//////////ADD////////////

            if (radioButton_local.Checked == true)
            {
                checkForValueinDb();
            }
            else if (radioButtonForeign.Checked == true)
            {
                #region  insert
                try
                {
                    con.Open();

                    string kind = "اجنبية";

                    cmd.CommandText = "INSERT INTO CurrencyInfo VALUES(@name, @nickname, @change, " +
                        "@CurrencyKind, @used)";
                    cmd.Connection = con;
                    cmd.Parameters.Clear(); //very important
                    cmd.Parameters.AddWithValue("@name", textBoxCurrencyName.Text);
                    cmd.Parameters.AddWithValue("@nickname", textBoxNickname.Text);
                    cmd.Parameters.AddWithValue("@change", textBoxChange.Text);
                    cmd.Parameters.AddWithValue("@CurrencyKind", kind);
                    cmd.Parameters.AddWithValue("@used", "0");

                    cmd.ExecuteNonQuery();
                    con.Close();

                    clearTextBoxes();

                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message);
                }
                #endregion
            }
            else
                MessageBox.Show("اختر نوع العملة");

            loadDataIntoGridView();
            resizeGridView();

        }
        private void checkForValueinDb()
        {
            con.Open();
            SqlCommand check_User_Name = new SqlCommand("SELECT * FROM CurrencyInfo WHERE (currencykind = @currencykind)", con);
            check_User_Name.Parameters.AddWithValue("@currencykind", "محلية");
            SqlDataReader reader = check_User_Name.ExecuteReader();
            if (reader.HasRows)
            {
                //User Exists
                con.Close();
                MessageBox.Show("العملة المحلية مضافة حاليا");
            }
            else
            {
                //User NOT Exists
                con.Close();
                #region  insert
                try
                {
                    con.Open();
                    string kind = "محلية";

                    cmd.CommandText = "INSERT INTO CurrencyInfo VALUES(@name, @nickname, @change, @CurrencyKind, @used)";
                    cmd.Connection = con;
                    cmd.Parameters.Clear(); //very important
                    cmd.Parameters.AddWithValue("@name", textBoxCurrencyName.Text);
                    cmd.Parameters.AddWithValue("@nickname", textBoxNickname.Text);
                    cmd.Parameters.AddWithValue("@change", textBoxChange.Text);
                    cmd.Parameters.AddWithValue("@CurrencyKind", kind);
                    cmd.Parameters.AddWithValue("@used", "0");

                    cmd.ExecuteNonQuery();
                    con.Close();
                    clearTextBoxes();

                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message);
                }
                #endregion
            }
        }//end checkForValueinDb()

        private void clearTextBoxes()
        {
            textBoxCurrencyName.Clear();
            textBoxNickname.Clear();
            textBoxChange.Clear();
        }

        private void buttonNew_CI_Click(object sender, EventArgs e)
        {
            textBoxCurrencyName.Enabled = true;
            textBoxNickname.Enabled = true;
            textBoxChange.Enabled = true;
            buttonAdd_CI.Enabled = true;
            
        }

        private void buttonDelete_CI_Click(object sender, EventArgs e)
        {
            checkForUsing();
        }

        private void checkForUsing()
        {
            int i = dataGridView1.SelectedCells[0].RowIndex;
            con.Open();
            SqlCommand cmdd = new SqlCommand("SELECT used FROM CurrencyInfo WHERE id = @id", con);
            cmdd.Parameters.Clear();
            cmdd.Parameters.AddWithValue("@id", dataGridView1.Rows[i].Cells[0].Value.ToString());
            string res = cmdd.ExecuteScalar().ToString();
            if (res == "1") // used = 1
            {
                //Value Exists
                con.Close();
                MessageBox.Show("لا يمكن مسحها لانها مستخدمة فى العمليات المحاسبية", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //Value NOT Exists
                con.Close();
                deleteCurrencyInfo();
                rebuildDataBase();
                loadDataIntoGridView();
            }
        }

        #region delete methods the add to database

        private void deleteCurrencyInfo()
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
                    MessageBox.Show("done");

                }
                catch (Exception er)
                {
                    con.Close();
                    MessageBox.Show(er.Message);
                }

            }//end if
             //THEN
             //////////////////////////////////////

        }//end deleteCurrencyInfo

        private void deleteRecord(string value)
        {
            con.Open();
            string sqlquery = "DELETE FROM CurrencyInfo WHERE id = @id";
            SqlCommand command = new SqlCommand(sqlquery, con);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", value);
            command.ExecuteNonQuery();
            con.Close();
        }

        private void rebuildDataBase() // just for sorting nums
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Close();
                    con.Open();
                }
                cmd.CommandText = "TRUNCATE TABLE CurrencyInfo";
                cmd.ExecuteNonQuery();

                insertAfterDeleteIntoDb();
                con.Close();
            }
            catch (Exception er)
            {
                con.Close();
                MessageBox.Show(er.Message);
            }
        }

        private void insertAfterDeleteIntoDb()
        {
            SqlCommand cmd2 = new SqlCommand
                ("Insert into CurrencyInfo(name, nickname, change, currencykind) " +
                "values(@name, @nickname, @change, @currencykind)");
            cmd2.Connection = con;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                cmd2.Parameters.Clear();
                cmd2.Parameters.AddWithValue("@name", dataGridView1.Rows[i].Cells[1].Value);
                cmd2.Parameters.AddWithValue("@nickname", dataGridView1.Rows[i].Cells[2].Value);
                cmd2.Parameters.AddWithValue("@change", dataGridView1.Rows[i].Cells[3].Value);
                cmd2.Parameters.AddWithValue("@currencykind", dataGridView1.Rows[i].Cells[4].Value);

                cmd2.ExecuteNonQuery();
            }//end for
        }
        #endregion

        private void buttonEditApproval_CI_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand check_User_Name = new SqlCommand("SELECT * FROM CurrencyInfo WHERE (currencykind = @currencykind)", con);
            check_User_Name.Parameters.AddWithValue("@currencykind", "محلية");
            SqlDataReader reader = check_User_Name.ExecuteReader();
            if (reader.HasRows)
            {
                //User Exists
                con.Close();
                MessageBox.Show("العملة المحلية مضافة حاليا");
            }
            else
            {
                //User NOT Exists
                editFuction();
            }
        }

        private void editFuction()
        {
            int id = 0;
            Regex re = new Regex(@"\d+");
            Match m = re.Match(groupBox3.Text);

            if (m.Success)
            {
                id = int.Parse(m.Value);
            }
            else
            {
                MessageBox.Show("You didn't enter a string containing a number!");
            }
            ////////////////////////////////////////
            string kinda = "";
            if (radioButton_local.Checked == true)
            {
                kinda = "محلية";
            }
            else if (radioButtonForeign.Checked == true)
            {
                kinda = "اجنبية";
            }

            con.Open();
            SqlCommand cmd = new SqlCommand("Update CurrencyInfo set name=@name, nickname=@nickname, change=@change, currencykind=@currencykind Where(id=@id)", con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", textBoxCurrencyName.Text);
            cmd.Parameters.AddWithValue("@nickname", textBoxNickname.Text);
            cmd.Parameters.AddWithValue("@change", textBoxChange.Text);
            cmd.Parameters.AddWithValue("@currencykind", kinda);
            cmd.ExecuteNonQuery();

            con.Close();
            loadDataIntoGridView();
            clearTextBoxes();
        }//end EditFunction()
        bool needEdit = false;
        private void buttonEdit_CI_Click(object sender, EventArgs e)
        {////////EDIT///////////

            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;
            string id = dataGridView1.Rows[i].Cells[0].Value.ToString();

            con.Open();
            SqlCommand cmdd = new SqlCommand("SELECT used FROM CurrencyInfo WHERE id = @id", con);
            cmdd.Parameters.Clear();
            cmdd.Parameters.AddWithValue("@id", id);
            string res = cmdd.ExecuteScalar().ToString();

            if (res == "1") // used = 1
            {
                //Value Exists
                con.Close();
                MessageBox.Show("لا يمكن التعديل لانها مستخدمة فى العمليات المحاسبية", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //Value NOT Exists
                groupBox3.Text = "ستقوم بتعديل بيانات المسلسل:  " + id;
                textBoxCurrencyName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBoxNickname.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                textBoxChange.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();

                if (buttonEdit_CI.Text == "تعديل")
                {
                    buttonEdit_CI.Text = "الغاء التعديل";
                    buttonEditApproval_CI.Enabled = true;
                    dataGridView1.CellClick += dataGridView1_CellClick;

                    textBoxCurrencyName.Enabled = true;
                    textBoxNickname.Enabled = true;
                    textBoxChange.Enabled = true;
                    needEdit = true;

                    buttonAdd_CI.Enabled = false;
                }
                else if (buttonEdit_CI.Text == "الغاء التعديل")
                {
                    buttonEdit_CI.Text = "تعديل";
                    buttonEditApproval_CI.Enabled = false;
                    groupBox3.Text = null;
                    dataGridView1.CellClick -= dataGridView1_CellClick;

                    textBoxCurrencyName.Enabled = false;
                    textBoxNickname.Enabled = false;
                    textBoxChange.Enabled = false;
                    needEdit = false;

                    buttonAdd_CI.Enabled = true;
                }
            }
            
        }//end button

        private void textBoxCurrencyName_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dataTable);
            DV.RowFilter = string.Format("name LIKE '%{0}%'", textBoxCurrencyName.Text);
            dataGridView1.DataSource = DV;
        }

        private void textBoxNickname_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dataTable);
            DV.RowFilter = string.Format("nickname LIKE '%{0}%'", textBoxNickname.Text);
            dataGridView1.DataSource = DV;
        }

        private void textBoxChange_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dataTable);
            DV.RowFilter = string.Format("change LIKE '%{0}%'", textBoxChange.Text);
            dataGridView1.DataSource = DV;
        }

        private void radioButton_local_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton_local.Checked == true)
            {
                DataView DV = new DataView(dataTable);
                DV.RowFilter = string.Format("CurrencyKind LIKE '%{0}%'", "محلية");
                dataGridView1.DataSource = DV;
            }

        }

        private void radioButtonForeign_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonForeign.Checked == true)
            {
                DataView DV = new DataView(dataTable);
                DV.RowFilter = string.Format("CurrencyKind LIKE '%{0}%'", "اجنبية");
                dataGridView1.DataSource = DV;
            }
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            loadDataIntoGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;
            if (needEdit)
            {
                groupBox3.Text = "ستقوم بتعديل بيانات المسلسل:  " + dataGridView1.Rows[i].Cells[0].Value.ToString();
            }
            textBoxCurrencyName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBoxNickname.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBoxChange.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            string res = dataGridView1.Rows[i].Cells[4].Value.ToString();
            ///////////////////////

            if (res == "محلية")
            {
                radioButton_local.Checked = true;
            }
            else if (res == "اجنبية")
            {
                radioButtonForeign.Checked = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;
            if (needEdit)
            {
                groupBox3.Text = "ستقوم بتعديل بيانات المسلسل:  " + dataGridView1.Rows[i].Cells[0].Value.ToString();
            }
            textBoxCurrencyName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBoxNickname.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBoxChange.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            string res = dataGridView1.Rows[i].Cells[4].Value.ToString();
            ///////////////////////
            if (res == "محلية")
            {
                radioButton_local.Checked = true;
            }
            else if (res == "اجنبية")
            {
                radioButtonForeign.Checked = true;
            }
            else
            {
                radioButton_local.Checked = false;
                radioButtonForeign.Checked = false;
                radioButtonAll.Checked = false;
            }
        }

    }
}