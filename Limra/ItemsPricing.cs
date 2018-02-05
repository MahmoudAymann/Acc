using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Limra
{
    public partial class ItemsPricing : Form
    {
        private const string strconneciton = @"Data Source=SPECTRA5;Initial Catalog=Limra;Integrated Security=True;TrustServerCertificate=False";
        SqlConnection con = new SqlConnection(strconneciton);
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable;

        public ItemsPricing(){
            InitializeComponent();

            loadDataIntoGridView1();
            resizeGridView1();

            fillComboBox1();
            fillComboBox2();
            
        }

        private void resizeGridView1(){
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                                    
            dataGridView1.Columns[0].HeaderText = "رقم الصنف";
            dataGridView1.Columns[1].HeaderText = "اسم الصنف";
            dataGridView1.Columns[2].HeaderText = "التكلفة";
            dataGridView1.Columns[3].HeaderText = "سعر التجزئة";
            dataGridView1.Columns[4].HeaderText = "سعر الجملة";
            dataGridView1.Columns[5].HeaderText = "السعر الخاص";


        }//end resizeGridView1

        private void resizeGridView2(){
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            
            dataGridView2.Columns[0].HeaderText = "رقم الصنف";
            dataGridView2.Columns[1].HeaderText = "اسم الصنف";
            dataGridView2.Columns[2].HeaderText = "الوحدة";
        }//end resizeGridView2
        
        private void loadDataIntoGridView1()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM ItemsPricing";
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
                cmd.CommandText = "SELECT num, nameArabic, packageName FROM ItemData WHERE groupNum=@groupNum";
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@groupNum",comboBox2.Text);

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

        private void fillComboBox2(){
            string query = "select * from StoringDataGroups";
            cmd.CommandText = query;
            cmd.Connection = con;

            SqlDataReader sqlReader;
            try{
                con.Open();
                sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read()){
                    string col = sqlReader["num"].ToString();
                    comboBox2.Items.Add(col);
                }

                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }//end fillComboBox2()

        private void fillComboBox1()
        {
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
                    string col = sqlReader["nickname"].ToString();
                    comboBox1.Items.Add(col);
                }

                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }//end fillComboBox1()


        private void comboBox2_TextChanged(object sender, EventArgs e){
            loadDataIntoGridView2();
            resizeGridView2();
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dataGridView2.SelectedCells[0].RowIndex;
            textBoxItemNum.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            textBoxItemName.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            textBoxItemPackage.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();

            fillItemCost(dataGridView2.Rows[i].Cells[0].Value.ToString());
        }

        private void fillItemCost(string asd){
            con.Open();
            string sqlquery = "SELECT cost FROM ItemData WHERE num=@num";
            SqlCommand command = new SqlCommand(sqlquery, con);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@num", asd);
            textBoxItemCost.Text = command.ExecuteScalar().ToString();
            con.Close();
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
                cmd.CommandText = "INSERT INTO ItemsPricing VALUES(@num, @name, @cost, @retailCost, @originalCost, @specialCost)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@num", textBoxItemNum.Text);
                cmd.Parameters.AddWithValue("@name", textBoxItemName.Text);
                cmd.Parameters.AddWithValue("@cost", textBoxItemCost.Text);
                cmd.Parameters.AddWithValue("@retailCost", textBoxRetailPricing.Text);
                cmd.Parameters.AddWithValue("@originalCost", textBoxOriginalPrice.Text);
                cmd.Parameters.AddWithValue("@specialCost", textBoxSpecialPrice.Text);

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
                cmd.CommandText = "TRUNCATE TABLE ItemsPricing";
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
            SqlCommand cmd2 = new SqlCommand("Insert into ItemsPricing(num, name, cost, retailCost, originalCost, specialCost)" +
                " values(@num, @name, @cost, @retailCost, @originalCost, @specialCost)", con);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                cmd2.Parameters.Clear();
                cmd2.Parameters.AddWithValue("@num", dataGridView1.Rows[i].Cells[0].Value);
                cmd2.Parameters.AddWithValue("@name", dataGridView1.Rows[i].Cells[1].Value);
                cmd2.Parameters.AddWithValue("@cost", dataGridView1.Rows[i].Cells[2].Value);
                cmd2.Parameters.AddWithValue("@retailCost", dataGridView1.Rows[i].Cells[3].Value);
                cmd2.Parameters.AddWithValue("@originalCost", dataGridView1.Rows[i].Cells[4].Value);
                cmd2.Parameters.AddWithValue("@specialCost", dataGridView1.Rows[i].Cells[5].Value);
                cmd2.ExecuteNonQuery();
            }//end for

        }//end insertAfterDeleteIntoDb

    }
}
