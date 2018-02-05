using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;

namespace Limra
{
    public partial class MaintenanceOfBranches : Form
    {
        private const string strconneciton = @"Data Source=SPECTRA5;Initial Catalog=Limra;Integrated Security=True;TrustServerCertificate=False";
        SqlConnection con = new SqlConnection(strconneciton);
        SqlCommand cmd = new SqlCommand();
        string imagePath = "";
        DataTable dataTable;
        public MaintenanceOfBranches()
        {
            InitializeComponent();
            loadDataIntoGridView();
            resizeGridView();
            textBoxNumber.TextChanged -= textBoxNumber_TextChanged;
        }

        private void resizeGridView()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[0].HeaderText = "رقم";
            dataGridView1.Columns[1].HeaderText = "اسم الفرع العربى";
            dataGridView1.Columns[2].HeaderText = "اسم الفرع الاجنبى";
            dataGridView1.Columns[3].HeaderText = "رقم التليفون";
            dataGridView1.Columns[4].HeaderText = "عنوان الفرع";
            dataGridView1.Columns[5].HeaderText = "رقم الفاكس";
            dataGridView1.Columns[6].HeaderText = "رقم صندوق البريد";
        }

        private void loadDataIntoGridView()
        {
            try
            {
                con.Open();
                //cmd.CommandText = "SELECT [branch_num],[arabic_name],[english_name],[phone],[address],[fax_num],[zipcode] FROM MaintenanceOfBranches";
                cmd.CommandText = "SELECT * FROM MaintenanceOfBranches";
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

        private void buttonNew_MOB_Click(object sender, EventArgs e)
        {//////////////NEW///////////////////
            buttonAdd_MOB.Enabled = true;
            buttonImg_MOB.Enabled = true;
            clearTextBoxes();
        }

        private void buttonAdd_MOB_Click(object sender, EventArgs e)
        {     /////////////ADD///////////////
            if (textBoxArabicName.Text != null && textBoxAddress.Text != null && textBoxNumber.Text != null)
            {
                insertData();
                loadDataIntoGridView();
                resizeGridView();
                clearTextBoxes();
                con.Close();
            }
            else
                MessageBox.Show("ادخل كل البيانات");
            con.Close();
        }

        private void clearTextBoxes()
        {
            textBoxNumber.Clear();
            textBoxArabicName.Clear();
            textBoxEnglishName.Clear();
            textBoxAddress.Clear();
            textBoxPhone.Clear();
            textBoxFaxNum.Clear();
            textBoxZipcode.Clear();
            con.Close();
        }

        private void insertData()
        {
            try
            {
                //byte[] img = null;
               // if (imagePath != "")
               // {
                   // FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                   // BinaryReader br = new BinaryReader(fs);
                   // img = br.ReadBytes((int)fs.Length);
              //  }

                con.Open();
                cmd.CommandText = "INSERT INTO MaintenanceOfBranches VALUES(@branch_num,@arabic_name,@english_name,@phone," +
                    "@address,@fax_num,@zipcode,@image)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@branch_num", textBoxNumber.Text);
                cmd.Parameters.AddWithValue("@arabic_name", textBoxArabicName.Text);
                cmd.Parameters.AddWithValue("@english_name", textBoxEnglishName.Text);
                cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                cmd.Parameters.AddWithValue("@address", textBoxAddress.Text);
                cmd.Parameters.AddWithValue("@fax_num", textBoxFaxNum.Text);
                cmd.Parameters.AddWithValue("@zipcode", textBoxZipcode.Text);
                cmd.Parameters.AddWithValue("@image", imagePath);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }//end insertData()

        private void buttonImg_MOB_Click(object sender, EventArgs e)
        {////////////////IMAGE_BUTTON////////////////
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
            dlg.Title = "Select Picture";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imagePath = dlg.FileName.ToString();
                pictureBox1.ImageLocation = imagePath;
            }
        }

        private void convertToByte()
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
               // MessageBox.Show(img);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }//end convertTobyte


        private void buttonEdit_MOB_Click(object sender, EventArgs e)
        {////////EDIT////////////
            con.Open();
            SqlCommand cmd = new SqlCommand("Update MaintenanceOfBranches set branch_num=@branch_num, arabic_name=@arabic_name, english_name=@english_name  Where(branch_num=@branch_num)", con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@branch_num", textBoxNumber.Text);
            cmd.Parameters.AddWithValue("@arabic_name", textBoxArabicName.Text);
            cmd.Parameters.AddWithValue("@english_name", textBoxArabicName.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم تعديل البيانات");
           
            loadDataIntoGridView();
            clearTextBoxes();

        }

        

        private void buttonDelete_MOB_Click(object sender, EventArgs e)
        {    ////////DELETE////////////
            deleteMultipleRowsFromGrid();

            try
            {
                con.Open();
                cmd.CommandText = "TRUNCATE TABLE MaintenanceOfBranches";
                cmd.ExecuteNonQuery();
                con.Close();
                insertAfterDeleteIntoDb();
                loadDataIntoGridView();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                con.Close();
            }

        }

        private void insertAfterDeleteIntoDb()
        {
            con.Open();
            cmd.CommandText = "Insert into MaintenanceOfBranches(branch_num,arabic_name,english_name,phone," +
                    "address,fax_num,zipcode,image) values(@branch_num,@arabic_name,@english_name,@phone," +
                    "@address,@fax_num,@zipcode,@image)";
            cmd.Connection = con;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                cmd.Parameters.Clear(); //(y)
                cmd.Parameters.AddWithValue("@branch_num", dataGridView1.Rows[i].Cells[0].Value);
                cmd.Parameters.AddWithValue("@arabic_name", dataGridView1.Rows[i].Cells[1].Value);
                cmd.Parameters.AddWithValue("@english_name", dataGridView1.Rows[i].Cells[2].Value);
                cmd.Parameters.AddWithValue("@phone", dataGridView1.Rows[i].Cells[3].Value);
                cmd.Parameters.AddWithValue("@address", dataGridView1.Rows[i].Cells[4].Value);
                cmd.Parameters.AddWithValue("@fax_num", dataGridView1.Rows[i].Cells[5].Value);
                cmd.Parameters.AddWithValue("@zipcode", dataGridView1.Rows[i].Cells[6].Value);
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

        private void buttonSearch_MOB_Click(object sender, EventArgs e)
        {
            textBoxNumber.TextChanged += textBoxNumber_TextChanged;
        }

        private void buttonCancelSearch_MOB_Click(object sender, EventArgs e)
        {
            textBoxNumber.TextChanged -= textBoxNumber_TextChanged;
        }

        private void buttonRefresh_MOB_Click(object sender, EventArgs e)
        {
            loadDataIntoGridView();
        }

       

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;
            textBoxNumber.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            
           // buttonAdd_MOB.Enabled = false;
            //buttonDelete_MOB.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;
            textBoxNumber.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            

           // buttonAdd_MOB.Enabled = false;
            //buttonDelete_MOB.Enabled = true;
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dataTable);
            DV.RowFilter = string.Format("Convert([branch_num], System.String) LIKE '%{0}%'", textBoxNumber.Text);
            dataGridView1.DataSource = DV;
        }

        private void textBoxArabicName_TextChanged(object sender, EventArgs e)
        {
            /*
            DataView DV = new DataView(dataTable);
            DV.RowFilter = string.Format("arabic_name LIKE '%{0}%'", textBoxArabicName.Text);
            dataGridView1.DataSource = DV;
            */
        }
    }
}