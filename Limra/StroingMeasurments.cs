using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;

namespace Limra
{
    public partial class StroingMeasurments : Form
    {
        private const string strconneciton = @"Data Source=SPECTRA5;Initial Catalog=Limra;Integrated Security=True;TrustServerCertificate=False";
        SqlConnection con = new SqlConnection(strconneciton);
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable;

        public StroingMeasurments()
        {
            InitializeComponent();
            loadDataIntoGridView();
            resizeGridView();
            dataGridView1.CellClick -= dataGridView1_CellClick;
        }

        private void resizeGridView()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns[0].HeaderText = "م";
            dataGridView1.Columns[1].HeaderText = "القياس";
            dataGridView1.Columns[2].HeaderText = "الرمز";

        }

        private void loadDataIntoGridView()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM StoringMeasurments";
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
        }

        private void buttonAdd_SM_Click(object sender, EventArgs e)
        {///////////// ADD //////////
            insertData();
            loadDataIntoGridView();
            resizeGridView();
            
        }

        private void insertData()
        {
            try{
               
                con.Open();
                cmd.CommandText = "INSERT INTO StoringMeasurments VALUES(@name, @nickname)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@name", textBoxMeasurements_SM.Text);
                cmd.Parameters.AddWithValue("@nickname", textBoxNickName_SM.Text);
               
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex){
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }//end insertData()

        private void buttonDelete_SM_Click(object sender, EventArgs e)
        {/////////DELETE////////////
            deleteCompanyInfoItems();
            loadDataIntoGridView();
        }//end button delete


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
                cmd.CommandText = "TRUNCATE TABLE StoringMeasurments";
                cmd.ExecuteNonQuery();

                insertAfterDeleteIntoDb();
                con.Close();
                MessageBox.Show("done");
            }
            catch (Exception er)
            {
                con.Close();
                MessageBox.Show(er.Message);
            }
        }//end deleteCompnayInfoItems

        private void insertAfterDeleteIntoDb()
        {
            SqlCommand cmd2 = new SqlCommand("Insert into StoringMeasurments(name,nickname) values(@name,@nickname)", con);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                cmd2.Parameters.Clear();
                cmd2.Parameters.AddWithValue("name", dataGridView1.Rows[i].Cells[1].Value);
                cmd2.Parameters.AddWithValue("@nickname", dataGridView1.Rows[i].Cells[2].Value);
                cmd2.ExecuteNonQuery();

            }//end for
        }//end insertAfterDeleteIntoDb

        private void buttonEdit_SM_Click(object sender, EventArgs e)
        {
            if (buttonEdit_SM.Text == "تعديل")
            {
                buttonEdit_SM.Text = "الغاء التعديل";
                labelLight2.BackColor = Color.Green;
                buttonEditApproval_CI.Enabled = true;
                dataGridView1.CellClick += dataGridView1_CellClick;


                

            }
            else if (buttonEdit_SM.Text == "الغاء التعديل")
            {
                labelLight2.BackColor = Color.Red;
                buttonEdit_SM.Text = "تعديل";
                buttonEditApproval_CI.Enabled = false;
                groupBox3.Text = null;
                dataGridView1.CellClick -= dataGridView1_CellClick;

                
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e){
            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;
            groupBox2.Text = "ستقوم بتعديل بيانات المسلسل:  " + dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBoxMeasurements_SM.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBoxNickName_SM.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            ///////////////////////
            
            buttonEdit_SM.Enabled = true;
        }

        private void buttonEditApproval_CI_Click(object sender, EventArgs e)
        {
            int id = 0;
            Regex re = new Regex(@"\d+");
            Match m = re.Match(groupBox2.Text);

            if (m.Success)
            {
                id = int.Parse(m.Value);
            }
            else
            {
                MessageBox.Show("You didn't enter a string containing a number!");
            }
            ////////////////////////////////////////

            con.Open();
            SqlCommand cmd = new SqlCommand("Update StoringMeasurments set name=@name, nickname=@nickname Where(id=@id)", con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", textBoxMeasurements_SM.Text);
            cmd.Parameters.AddWithValue("@nickname", textBoxNickName_SM.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            loadDataIntoGridView();

        }

        private void buttonLoad_SM_Click(object sender, EventArgs e)
        {
            loadDataIntoGridView();
        }
    }//end class
}//end namespace
