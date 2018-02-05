using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Limra
{
    public partial class StoreInfo : Form
    {
        private const string strconneciton = @"Data Source=SPECTRA5;Initial Catalog=Limra;Integrated Security=True;TrustServerCertificate=False";
        SqlConnection con = new SqlConnection(strconneciton);
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable;

        public StoreInfo()
        {
            InitializeComponent();
            loadDataIntoGridView();
            resizeGridView();
            textBoxNum_SI.TextChanged -= textBoxNum_SI_TextChanged;
        }

        private void resizeGridView()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView1.Columns[0].HeaderText = "رقم المخزن";
            dataGridView1.Columns[1].HeaderText = "اسم المخزن العربى";
            dataGridView1.Columns[2].HeaderText = "الإسم الأجنبى";
            dataGridView1.Columns[3].HeaderText = "العنوان";
            dataGridView1.Columns[4].HeaderText = "التليفون";
            dataGridView1.Columns[5].HeaderText = "الفاكس";
           
        }

        private void loadDataIntoGridView()
        {
            try
            {
                con.Open();
                //cmd.CommandText = "SELECT [branch_num],[arabic_name],[english_name],[phone],[address],[fax_num],[zipcode] FROM MaintenanceOfBranches";
                cmd.CommandText = "SELECT * FROM StoreInfo";
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
        }//end loadData()

        private void buttonAdd_SI_Click(object sender, EventArgs e)
        {
            insertData();
            loadDataIntoGridView();
            resizeGridView();
        }

        private void insertData()
        {
            try
            {
                
                con.Open();
                cmd.CommandText = "INSERT INTO StoreInfo VALUES(@num,@arabicName,@englishName,@address,@phone,@fax)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@num", textBoxNum_SI.Text);
                cmd.Parameters.AddWithValue("@arabicName", textBoxArabicName_SI.Text);
                /////////////
                if (textBoxEnglishName_SI.Text == "")
                    cmd.Parameters.AddWithValue("@englishName", "----");
                else
                    cmd.Parameters.AddWithValue("@englishName", textBoxEnglishName_SI.Text);
                /////////////
                cmd.Parameters.AddWithValue("@address", textBoxAddress_SI.Text);
                cmd.Parameters.AddWithValue("@phone", textBoxPhone_SI.Text);
                cmd.Parameters.AddWithValue("@fax", textBoxFax_SI.Text);
                
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }//end insertData()
         
        private void textBoxNum_SI_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_SI_Click(object sender, EventArgs e)
        {
            deleteMultipleRowsFromGrid();

            try
            {
                con.Open();
                cmd.CommandText = "TRUNCATE TABLE StoreInfo";
                cmd.ExecuteNonQuery();
                con.Close();
                insertAfterDeleteIntoDb();
                loadDataIntoGridView();
            }
            catch (Exception er)
            {
                con.Close();
                MessageBox.Show(er.Message);
            }
        }

        private void insertAfterDeleteIntoDb()
        {
            con.Open();
            cmd.CommandText = "INSERT INTO StoreInfo(num,arabicName,englishName,address," +
                    "phone,fax) values(@num,@arabicName,@englishName,@address," +
                    "@phone,@fax)";
            cmd.Connection = con;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                cmd.Parameters.Clear(); //(y)
                cmd.Parameters.AddWithValue("num", dataGridView1.Rows[i].Cells[0].Value);
                cmd.Parameters.AddWithValue("@arabicName", dataGridView1.Rows[i].Cells[1].Value);
                cmd.Parameters.AddWithValue("@englishName", dataGridView1.Rows[i].Cells[2].Value);
                cmd.Parameters.AddWithValue("@address", dataGridView1.Rows[i].Cells[3].Value);
                cmd.Parameters.AddWithValue("@phone", dataGridView1.Rows[i].Cells[4].Value);
                cmd.Parameters.AddWithValue("@fax", dataGridView1.Rows[i].Cells[5].Value);
                cmd.ExecuteNonQuery();

            }//end for
            con.Close();
        }

        private void deleteMultipleRowsFromGrid()
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
                {
                    if (oneCell.Selected)
                        dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                }//end foereach
            }//end if
        }//end deleteMultiple

        private void buttonEdit_SI_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update StoreInfo set num=@num, arabicName=@arabicName, englishName=@englishName, address=@address, phone=@phone, fax=@fax  Where(num=@num)", con);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@num", textBoxNum_SI.Text);
            cmd.Parameters.AddWithValue("@arabicName", textBoxArabicName_SI.Text);
            cmd.Parameters.AddWithValue("@englishName", textBoxEnglishName_SI.Text);
            cmd.Parameters.AddWithValue("@address", textBoxEnglishName_SI.Text);
            cmd.Parameters.AddWithValue("@phone", textBoxEnglishName_SI.Text);
            cmd.Parameters.AddWithValue("@fax", textBoxEnglishName_SI.Text);
            
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم تعديل البيانات");
            //Bind();
            loadDataIntoGridView();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;
            textBoxNum_SI.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBoxArabicName_SI.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBoxEnglishName_SI.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBoxAddress_SI.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBoxPhone_SI.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBoxFax_SI.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;
            textBoxNum_SI.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBoxArabicName_SI.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBoxEnglishName_SI.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBoxAddress_SI.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBoxPhone_SI.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBoxFax_SI.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

    }//end class
}//end namespace