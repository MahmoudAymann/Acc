using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Limra
{
    public partial class StoreExchangeOrders : Form
    {
        static string strConneciton = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con = new SqlConnection(strConneciton);
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable;

        public StoreExchangeOrders()
        {
            InitializeComponent();

            loadDataIntoGridView1();
            resizeGridView1();

            fillComboBox1();
        }

        #region load DataGridViews and setup checkBoxes
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
            dataGridView1.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView1.Columns[0].HeaderText = "رقم الصرف";
            dataGridView1.Columns[1].HeaderText = "التاريخ";
            dataGridView1.Columns[2].HeaderText = "رقم الحساب";
            dataGridView1.Columns[3].HeaderText = "اسم الحساب";
            dataGridView1.Columns[4].HeaderText = "رقم المخزن";
            dataGridView1.Columns[5].HeaderText = "اسم المخزن";
            dataGridView1.Columns[6].HeaderText = "رقم المجموعة";
            dataGridView1.Columns[7].HeaderText = "رقم الصنف";
            dataGridView1.Columns[8].HeaderText = "اسم الصنف";
            dataGridView1.Columns[9].HeaderText = "الوحدة";
            dataGridView1.Columns[10].HeaderText = "الكمية";
            dataGridView1.Columns[11].HeaderText = "التكلفة";
            dataGridView1.Columns[12].HeaderText = "الإجمالى";
            dataGridView1.Columns[13].HeaderText = "البيان";
            dataGridView1.Columns[14].HeaderText = "المجوع الكلى";
            dataGridView1.Columns[15].HeaderText = "رقم المرجع";

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
                cmd.CommandText = "SELECT * FROM StoreExchangeOrders";
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
                cmd.CommandText = "SELECT accoNum, accoNameArabic FROM CalculationGuide WHERE accoKind=@accoKind";
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
            }
            catch (Exception ed)
            {
                con.Close();
                MessageBox.Show(ed.Message);
            }
        }//end loadDataIntoGridView2

        private void fillComboBox1()
        {
            string query = "select * from StoringDataGroups";
            cmd.CommandText = query;
            cmd.Connection = con;

            SqlDataReader sqlReader;
            try
            {
                con.Open();
                sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    string col = sqlReader["num"].ToString();
                    comboBox4.Items.Add(col);
                }
                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }//end fillComboBox1()

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxItemNum.Clear();
            textBoxItemName.Clear();
            textBoxPackage.Clear();

            loadDataIntoGridView4();
            resizeGridView4();
        }

        private void loadDataIntoGridView4()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT num, nameArabic, packageName FROM ItemData WHERE groupNum=@groupNum";
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@groupNum", comboBox4.Text);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                dataTable = new DataTable();
                adapter.Fill(dataTable);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dataTable;
                dataGridView4.DataSource = bSource;
                adapter.Update(dataTable);
                con.Close();
            }
            catch (Exception ed)
            {
                con.Close();
                MessageBox.Show(ed.Message);
            }
        }//end loadDataIntoGridView2

        private void resizeGridView4()
        {
            dataGridView4.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView4.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView4.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView4.Columns[0].HeaderText = "رقم الصنف";
            dataGridView4.Columns[1].HeaderText = "اسم الصنف";
            dataGridView4.Columns[2].HeaderText = "الوحدة";
        }//end resizeGridView2

        private void dataGridView4_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dataGridView4.SelectedCells[0].RowIndex;
            textBoxItemNum.Text = dataGridView4.Rows[i].Cells[0].Value.ToString();
            textBoxItemName.Text = dataGridView4.Rows[i].Cells[1].Value.ToString();
            textBoxPackage.Text = dataGridView4.Rows[i].Cells[2].Value.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                loadDataIntoGridView2();
                resizeGridView2();
            }
            else
            {
                dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();
            }
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dataGridView2.SelectedCells[0].RowIndex;
            textBoxAccouNum.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            textBoxAccoName.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                loadDataIntoGridView3();
                resizeGridView3();
            }
            else
            {
                dataGridView3.DataSource = null;
                dataGridView3.Rows.Clear();
            }
        }//end 

        private void resizeGridView3()
        {
            dataGridView3.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView3.Columns[0].HeaderText = "رقم المخزن";
            dataGridView3.Columns[1].HeaderText = "اسم المخزن";

        }//end resizeGridView3

        private void loadDataIntoGridView3()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT num, arabicName FROM StoreInfo";
                cmd.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                dataTable = new DataTable();
                adapter.Fill(dataTable);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dataTable;
                dataGridView3.DataSource = bSource;
                adapter.Update(dataTable);
                con.Close();
            }
            catch (Exception ed)
            {
                con.Close();
                MessageBox.Show(ed.Message);
            }
        }//end loadDataIntoGridView3

        private void dataGridView3_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dataGridView3.SelectedCells[0].RowIndex;
            textBoxStoreNum.Text = dataGridView3.Rows[i].Cells[0].Value.ToString();
            textBoxStoreName.Text = dataGridView3.Rows[i].Cells[1].Value.ToString();
        }

        #endregion

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            insertData();
            loadDataIntoGridView1();
            resizeGridView1();
        }

        private void insertData()
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO StoreExchangeOrders VALUES(@supplyDocNum, @date, @accNum, @accName, @storeNum, @storeName," +
                    " @groupNum, @itemNum,@itemName, @package, @quantity, @cost, @totalCost," +
                    " @description,@totalSum,@refrencerNumber)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@supplyDocNum", textBoxSupplyNum.Text);
                cmd.Parameters.AddWithValue("@date", textBoxCurrentDate.Text);
                cmd.Parameters.AddWithValue("@accNum", textBoxAccouNum.Text);
                cmd.Parameters.AddWithValue("@accName", textBoxAccoName.Text);
                cmd.Parameters.AddWithValue("@storeNum", textBoxStoreNum.Text);
                cmd.Parameters.AddWithValue("@storeName", textBoxStoreName.Text);
                cmd.Parameters.AddWithValue("@groupNum", comboBox4.Text);
                cmd.Parameters.AddWithValue("@itemNum", textBoxItemNum.Text);
                cmd.Parameters.AddWithValue("@itemName", textBoxItemName.Text);
                cmd.Parameters.AddWithValue("@package", textBoxPackage.Text);
                cmd.Parameters.AddWithValue("@quantity", textBoxQuantity.Text);
                cmd.Parameters.AddWithValue("@cost", textBoxCost.Text);
                cmd.Parameters.AddWithValue("@totalCost", textBoxTotalCost.Text);
                cmd.Parameters.AddWithValue("@description", textBoxDescription.Text);
                cmd.Parameters.AddWithValue("@totalSum", textBoxTotalSum.Text);
                cmd.Parameters.AddWithValue("@refrencerNumber", textBoxRefNum.Text);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }//end insertData()

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
                cmd.CommandText = "TRUNCATE TABLE StoreExchangeOrders";
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
            SqlCommand cmd2 = new SqlCommand("INSERT INTO StoreExchangeOrders (supplyDocNum, date, accNum, accName, storeNum, storeName," +
                "groupNum,itemNum,itemName,package,quantity,cost,totalCost," +
                "description,totalSum,refrencerNumber)" +
                " VALUES (@supplyDocNum, @date, @accNum, @accName, @storeNum, @storeName," +
                " @groupNum, @itemNum, @itemName, @package, @quantity," +
                " @cost, @totalCost, @description, @totalSum, @refrencerNumber)", con);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                cmd2.Parameters.Clear();
                cmd2.Parameters.AddWithValue("@supplyDocNum", dataGridView1.Rows[i].Cells[0].Value);
                cmd2.Parameters.AddWithValue("@date", dataGridView1.Rows[i].Cells[1].Value);
                cmd2.Parameters.AddWithValue("@accNum", dataGridView1.Rows[i].Cells[2].Value);
                cmd2.Parameters.AddWithValue("@accName", dataGridView1.Rows[i].Cells[3].Value);
                cmd2.Parameters.AddWithValue("@storeNum", dataGridView1.Rows[i].Cells[4].Value);
                cmd2.Parameters.AddWithValue("@storeName", dataGridView1.Rows[i].Cells[5].Value);
                cmd2.Parameters.AddWithValue("@groupNum", dataGridView1.Rows[i].Cells[6].Value);
                cmd2.Parameters.AddWithValue("@itemNum", dataGridView1.Rows[i].Cells[7].Value);
                cmd2.Parameters.AddWithValue("@itemName", dataGridView1.Rows[i].Cells[8].Value);
                cmd2.Parameters.AddWithValue("@package", dataGridView1.Rows[i].Cells[9].Value);
                cmd2.Parameters.AddWithValue("@quantity", dataGridView1.Rows[i].Cells[10].Value);
                cmd2.Parameters.AddWithValue("@cost", dataGridView1.Rows[i].Cells[11].Value);
                cmd2.Parameters.AddWithValue("@totalCost", dataGridView1.Rows[i].Cells[12].Value);
                cmd2.Parameters.AddWithValue("@description", dataGridView1.Rows[i].Cells[13].Value);
                cmd2.Parameters.AddWithValue("@totalSum", dataGridView1.Rows[i].Cells[14].Value);
                cmd2.Parameters.AddWithValue("@refrencerNumber", dataGridView1.Rows[i].Cells[15].Value);

                cmd2.ExecuteNonQuery();
            }//end for

        }//end insertAfterDeleteIntoDb

        private void StoreExchangeOrders_Load(object sender, EventArgs e)
        {
            textBoxCurrentDate.Text = DateTime.Now.ToString("dd / MM / yyyy");
        }
    }
}
