using System;
using System.Data;
using System.Drawing;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Limra
{
    public partial class ItemData : Form
    {
        static string strConneciton = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con = new SqlConnection(strConneciton);
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable;

        public ItemData()
        {
            InitializeComponent();
            loadDataIntoGridView1();
            resizeGridView1();
            fillComboBox();
        }

        private void fillComboBox()
        {
            string query = "select * from StoringMeasurments";
            cmd.CommandText = query;
            cmd.Connection = con;

            SqlDataReader sqlReader;
            try{
                con.Open();
                sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    string col = sqlReader["nickname"].ToString();
                    comboBox1.Items.Add(col);
                }

                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }//end fillComboBox()

        private void resizeGridView1(){
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
            dataGridView1.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView1.Columns[0].HeaderText = "رقم المجموعة";
            dataGridView1.Columns[1].HeaderText = "اسم المجموعة";
            dataGridView1.Columns[2].HeaderText = "رقم الصنف";
            dataGridView1.Columns[3].HeaderText = "اسم الصنف العربى";
            dataGridView1.Columns[4].HeaderText = "الاسم الاجنبى";
            dataGridView1.Columns[5].HeaderText = "وحدة القياس";
            dataGridView1.Columns[6].HeaderText = "عدد العبوة";
            dataGridView1.Columns[7].HeaderText = "اسم العبوة الواحدة";
            dataGridView1.Columns[8].HeaderText = "حد الطلب";
            dataGridView1.Columns[9].HeaderText = "الحد الادنى";
            dataGridView1.Columns[10].HeaderText = "الحد الاكبر";
            dataGridView1.Columns[11].HeaderText = "التكلفة";
            dataGridView1.Columns[12].HeaderText = "العملة";
        }//end resizeGridView1

        private void resizeGridView2()
        {
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView2.Columns[0].HeaderText = "رقم المجموعة";
            dataGridView2.Columns[1].HeaderText = "اسم المجموعة";



        }//end resizeGridView2

        private void loadDataIntoGridView1()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM ItemData";
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

        private void loadDataIntoGridView2()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT num,nameArabic FROM StoringDataGroups";
                cmd.Connection = con;

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
        }//end loadDataIntoGridView2

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            groupBox2.ForeColor = Color.Red;
            labelGroupName.ForeColor = Color.Black;
            labelGroupNum.ForeColor = Color.Black;
            checkBoxShowGroupInfo.ForeColor = Color.Black;
            dataGridView2.ForeColor = Color.Black;
        }

        private void groupBox2_Leave(object sender, EventArgs e)
        {
            groupBox2.ForeColor = Color.Black;
        }
        
        private void checkBoxShowGroupInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowGroupInfo.Checked)
            {
                loadDataIntoGridView2();
                resizeGridView2();
            }
            else if (checkBoxShowGroupInfo.Checked == false)
            {
                dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            insertData();
            loadDataIntoGridView1();
            resizeGridView1();
        }

        private void insertData(){
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO ItemData VALUES(@groupNum, @groupName, @num, @nameArabic,@nameEnglish," +
                    " @measurmentUnit, @packageNum,@packageName,@limitRequest,@minNum,@maxNum,@cost,@currency)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@groupNum", textBoxGroupNum.Text);
                cmd.Parameters.AddWithValue("@groupName", textBoxGroupName.Text);
                cmd.Parameters.AddWithValue("@num", textBoxItemNum.Text);
                cmd.Parameters.AddWithValue("@nameArabic", textBoxItemNameArabic.Text);
                cmd.Parameters.AddWithValue("@nameEnglish", textBoxItemNameEnglish.Text);
                cmd.Parameters.AddWithValue("@measurmentUnit", comboBox1.Text);
                cmd.Parameters.AddWithValue("@packageNum", textBoxPackageNum.Text);
                cmd.Parameters.AddWithValue("@packageName", textBoxPackageName.Text);
                cmd.Parameters.AddWithValue("@limitRequest", textBoxLimitRequest.Text);
                cmd.Parameters.AddWithValue("@minNum", textBoxMinNum.Text);
                cmd.Parameters.AddWithValue("@maxNum", textBoxMaxNum.Text);
                cmd.Parameters.AddWithValue("@cost", textBoxCost.Text);
                cmd.Parameters.AddWithValue("@currency", textBoxCurrency.Text);

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
            deleteCompanyInfoItems();
            loadDataIntoGridView1();
        }

        private void deleteCompanyInfoItems()
        {
            //delete multiple rows
            if (dataGridView1.SelectedCells.Count > 0)
            {
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
                cmd.CommandText = "TRUNCATE TABLE ItemData";
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
            SqlCommand cmd2 = new SqlCommand("Insert into ItemData(groupNum, groupName, num, nameArabic," +
                "nameEnglish, measurmentUnit, packageNum, packageName, limitRequest," +
                " minNum, maxNum, cost, currency)" +
                " values(@groupNum, @groupName, @num, @nameArabic,@nameEnglish," +
                    " @measurmentUnit, @packageNum,@packageName,@limitRequest,@minNum,@maxNum,@cost,@currency)");
            cmd2.Connection = con;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                cmd2.Parameters.Clear();
                cmd2.Parameters.AddWithValue("@groupNum", dataGridView1.Rows[i].Cells[0].Value);
                cmd2.Parameters.AddWithValue("@groupName", dataGridView1.Rows[i].Cells[1].Value);
                cmd2.Parameters.AddWithValue("@num", dataGridView1.Rows[i].Cells[2].Value);
                cmd2.Parameters.AddWithValue("@nameArabic", dataGridView1.Rows[i].Cells[3].Value);
                cmd2.Parameters.AddWithValue("@nameEnglish", dataGridView1.Rows[i].Cells[4].Value);
                cmd2.Parameters.AddWithValue("@measurmentUnit", dataGridView1.Rows[i].Cells[5].Value);
                cmd2.Parameters.AddWithValue("@packageNum", dataGridView1.Rows[i].Cells[6].Value);
                cmd2.Parameters.AddWithValue("@packageName", dataGridView1.Rows[i].Cells[7].Value);
                cmd2.Parameters.AddWithValue("@limitRequest", dataGridView1.Rows[i].Cells[8].Value);
                cmd2.Parameters.AddWithValue("@minNum", dataGridView1.Rows[i].Cells[9].Value);
                cmd2.Parameters.AddWithValue("@maxNum", dataGridView1.Rows[i].Cells[10].Value);
                cmd2.Parameters.AddWithValue("@cost", dataGridView1.Rows[i].Cells[11].Value);
                cmd2.Parameters.AddWithValue("@currency", dataGridView1.Rows[i].Cells[12].Value);
                
                cmd2.ExecuteNonQuery();
            }//end for

        }//end insertAfterDeleteIntoDb

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e){
            int i;
            i = dataGridView2.SelectedCells[0].RowIndex;
            textBoxGroupNum.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            textBoxGroupName.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //.....
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            groupBox3.ForeColor = Color.Red;
            labelItemNum.ForeColor = Color.Black;
            labelItemNameArabic.ForeColor = Color.Black;
            labelItemNameEnglish.ForeColor = Color.Black;
            labelDescription.ForeColor = Color.Black;
            labelMeasurmentUnit.ForeColor = Color.Black;
            labelPackageNum.ForeColor = Color.Black;
            labelPackageName.ForeColor = Color.Black;
            labelLimitRequest.ForeColor = Color.Black;
            labelMinNum.ForeColor = Color.Black;
            labelMaxNum.ForeColor = Color.Black;
            labelCost.ForeColor = Color.Black;
            labelCurrency.ForeColor = Color.Black;
            
        }

        private void groupBox3_Leave(object sender, EventArgs e)
        {
            groupBox3.ForeColor = Color.Black;
        }
    }
}
