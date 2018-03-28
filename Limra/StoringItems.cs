using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Configuration;

namespace Limra
{
    public partial class StoringItems : Form
    {
        static string strConneciton = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con = new SqlConnection(strConneciton);
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable;

        public StoringItems()
        {
            InitializeComponent();
            loadDataIntoGridView1();
            resizeGridView1();

            fillComboBox1();
        }

        private void resizeGridView1()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


            dataGridView1.Columns[0].HeaderText = "م";
            dataGridView1.Columns[1].HeaderText = "رقم الصنف";
            dataGridView1.Columns[2].HeaderText = "اسم الصنف";
            dataGridView1.Columns[3].HeaderText = "رقم المخزن";
            dataGridView1.Columns[4].HeaderText = "اسم المخزن";
            dataGridView1.Columns[5].HeaderText = "العبوة";
            dataGridView1.Columns[6].HeaderText = "المخزون الإفتتاحى";
            dataGridView1.Columns[7].HeaderText = "الكميات المتوفرة";



        }//end resizeGridView1

        private void loadDataIntoGridView1()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM StoringItems";
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

        private void resizeGridView2()
        {
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


            dataGridView2.Columns[0].HeaderText = "رقم الصنف";
            dataGridView2.Columns[1].HeaderText = "اسم الصنف";
            dataGridView2.Columns[2].HeaderText = "العبوة";
        }//end resizeGridView2

        private void loadDataIntoGridView2()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT num, nameArabic, packageName FROM ItemData WHERE groupNum=@groupNum";
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@groupNum",comboBox1.Text);

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

        private void resizeGridView3()
        {
            dataGridView3.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


            dataGridView3.Columns[0].HeaderText = "رقم المخزن";
            dataGridView3.Columns[1].HeaderText = "اسم المخزن";
            dataGridView3.Columns[2].HeaderText = "العنوان";

        }//end resizeGridView3

        private void loadDataIntoGridView3()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT num, arabicName, address FROM StoreInfo";
                cmd.Connection = con;
                cmd.Parameters.Clear();

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
                    comboBox1.Items.Add(col);
                }

                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }//end fillComboBox2()

        private void checkBox1_CheckedChanged(object sender, EventArgs e){
            if (checkBox1.Checked){
                loadDataIntoGridView3();
                resizeGridView3();
            }
            else{
                dataGridView3.DataSource = null;
                dataGridView3.Rows.Clear();
            }
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dataGridView2.SelectedCells[0].RowIndex;
            textBoxItemNum.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            textBoxItemName.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            textBoxPackage.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            
           // sumAllAvailQuantities();
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e){
            loadDataIntoGridView2();
            resizeGridView2();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            loadDataIntoGridView2();
            resizeGridView2();
        }

        private void dataGridView3_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dataGridView3.SelectedCells[0].RowIndex;
            textBoxStoreNum.Text = dataGridView3.Rows[i].Cells[0].Value.ToString();
            textBoxStoreName.Text = dataGridView3.Rows[i].Cells[1].Value.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            insertData();
            loadDataIntoGridView1();
            resizeGridView1();
        }

        private void insertData(){
            try{
                con.Open();
                cmd.CommandText = "INSERT INTO StoringItems VALUES(@itemNum, @itemName, @storeNum, @storeName," +
                    " @package, @firstStore,@availQuantity)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@itemNum", textBoxItemNum.Text);
                cmd.Parameters.AddWithValue("@itemName", textBoxItemName.Text);
                cmd.Parameters.AddWithValue("@storeNum", textBoxStoreNum.Text);
                cmd.Parameters.AddWithValue("@storeName", textBoxStoreName.Text);
                cmd.Parameters.AddWithValue("@package", textBoxPackage.Text);
                cmd.Parameters.AddWithValue("@firstStore", textBoxFirstStore.Text);
                cmd.Parameters.AddWithValue("@availQuantity", textBoxAvailQuantity.Text);
                
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

        private void deleteCompanyInfoItems(){
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
            try{
                con.Open();
                cmd.CommandText = "TRUNCATE TABLE StoringItems";
                cmd.ExecuteNonQuery();

                insertAfterDeleteIntoDb();
                con.Close();
                MessageBox.Show("deleted!");
            }
            catch (Exception er){
                con.Close();
                MessageBox.Show(er.Message);
            }
        }//end deleteCompnayInfoItems
        private void insertAfterDeleteIntoDb(){
            SqlCommand cmd2 = new SqlCommand("Insert into StoringItems(itemNum, itemName, storeNum, storeName, package, firstStore, availQuantity)" +
                " values(@itemNum, @itemName, @storeNum, @storeName," +
                    " @package, @firstStore,@availQuantity)", con);

            for (int i = 0; i < dataGridView1.Rows.Count; i++){
                cmd2.Parameters.Clear();
                cmd2.Parameters.AddWithValue("@itemNum", dataGridView1.Rows[i].Cells[1].Value);
                cmd2.Parameters.AddWithValue("@itemName", dataGridView1.Rows[i].Cells[2].Value);
                cmd2.Parameters.AddWithValue("@storeNum", dataGridView1.Rows[i].Cells[3].Value);
                cmd2.Parameters.AddWithValue("@storeName", dataGridView1.Rows[i].Cells[4].Value);
                cmd2.Parameters.AddWithValue("@package", dataGridView1.Rows[i].Cells[5].Value);
                cmd2.Parameters.AddWithValue("@firstStore", dataGridView1.Rows[i].Cells[6].Value);
                cmd2.Parameters.AddWithValue("@availQuantity", dataGridView1.Rows[i].Cells[7].Value);
                
                cmd2.ExecuteNonQuery();
            }//end for

        }//end insertAfterDeleteIntoDb

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            groupBox2.ForeColor = Color.Red;
            labelGroupNum.ForeColor = Color.Black;
            comboBox1.ForeColor = Color.Black;
            dataGridView2.ForeColor = Color.Black;
        }

        private void groupBox2_Leave(object sender, EventArgs e)
        {
            groupBox2.ForeColor = Color.Black;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            groupBox3.ForeColor = Color.Red;
            labelItemNum.ForeColor = Color.Black;
            labelItemName.ForeColor = Color.Black;
            labelAvailQuant.ForeColor = Color.Black;
            labelFirstStore.ForeColor = Color.Black;
            labelPackage.ForeColor = Color.Black;
            labelLine.ForeColor = Color.Black;
        }

        private void groupBox3_Leave(object sender, EventArgs e)
        {
            groupBox3.ForeColor = Color.Black;

        }

        private void groupBox4_Enter(object sender, EventArgs e){
            groupBox4.ForeColor = Color.Red;
            labelStoreNum.ForeColor = Color.Black;
            labelStoreName.ForeColor = Color.Black;
            dataGridView3.ForeColor = Color.Black;
            checkBox1.ForeColor = Color.Black;
        }

        private void groupBox4_Leave(object sender, EventArgs e)
        {
            groupBox4.ForeColor = Color.Black;
        }

       
    }
}
