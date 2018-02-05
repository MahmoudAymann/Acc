using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Limra
{
    public partial class RelayDailyRestrictions : Form
    {
        private const string strconneciton = @"Data Source=SPECTRA5;Initial Catalog=Limra;Integrated Security=True;TrustServerCertificate=False";
        SqlConnection con = new SqlConnection(strconneciton);
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable, dataTable2;

        BindingSource bSource1 = new BindingSource();

        public DataTable tblTo { get; set; }

        public RelayDailyRestrictions()
        {
            InitializeComponent();
            loadDataIntoGridView1();
            resizeGridView1();
            resizeGridView2();

            textBoxCurrentDate.Text = DateTime.Now.ToString("dd / MM / yyyy");
        }

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
            
            
            dataGridView1.Columns[0].HeaderText = "م";
            dataGridView1.Columns[1].HeaderText = "رقم المستند";
            dataGridView1.Columns[2].HeaderText = "رقم الحساب";
            dataGridView1.Columns[3].HeaderText = "اسم الحساب";
            dataGridView1.Columns[4].HeaderText = "بيان";
            dataGridView1.Columns[5].HeaderText = "دائن";
            dataGridView1.Columns[6].HeaderText = "مدين";
            dataGridView1.Columns[7].HeaderText = "التاريخ";
            dataGridView1.Columns[8].HeaderText = "رقم المرجع ";
            dataGridView1.Columns[9].HeaderText = "المبلغ";
            
        }//end resizeGridView1
        private void resizeGridView2()
        {
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            
            dataGridView2.Columns[0].HeaderText = "م";
            dataGridView2.Columns[1].HeaderText = "رقم المستند";
            dataGridView2.Columns[2].HeaderText = "رقم الحساب";
            dataGridView2.Columns[3].HeaderText = "اسم الحساب";
            dataGridView2.Columns[4].HeaderText = "بيان";
            dataGridView2.Columns[5].HeaderText = "دائن";
            dataGridView2.Columns[6].HeaderText = "مدين";
            dataGridView2.Columns[7].HeaderText = "التاريخ";
            dataGridView2.Columns[8].HeaderText = "رقم المرجع ";
            dataGridView2.Columns[9].HeaderText = "المبلغ";
            

        }//end resizeGridView1
        
        private void loadDataIntoGridView1()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM RelayDailyRestrictions";
                cmd.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                dataTable = new DataTable();
                adapter.Fill(dataTable);
                
                bSource1.DataSource = dataTable;
                dataGridView1.DataSource = bSource1;

                tblTo = dataTable.Clone();
                
                adapter.Update(dataTable);
                
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.DataSource = dataTable;
                dataGridView2.DataSource = tblTo;
                
                con.Close();          
            }
            catch (Exception ed){

                con.Close();
                MessageBox.Show(ed.Message);
            }
        }//end loadDataIntoGridView1

        private void loadDataIntoGridView2()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM RelayDailyRestrictions";
                cmd.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                dataTable2 = new DataTable();
                adapter.Fill(dataTable2);

                bSource1.DataSource = dataTable2;
                dataGridView2.DataSource = bSource1;

                tblTo = dataTable2.Clone();

                adapter.Update(dataTable2);

                DataRow tmp;
                tmp = dataTable2.NewRow();
                dataTable2.Rows.Add(tmp);

                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView2.DataSource = dataTable2;
                dataGridView1.DataSource = tblTo;

                con.Close();
            }
            catch (Exception ed)
            {
                con.Close();
                MessageBox.Show(ed.Message);
            }
        }//end loadDataIntoGridView2

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            loadDataIntoGridView1();
            resizeGridView1();
        }

        private void buttonSendAll_Click(object sender, EventArgs e)
        { 
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            loadDataIntoGridView2();
            resizeGridView2();
        }
        
        private void buttonSendOne_Click(object sender, EventArgs e)
        {
            // if no ROWS selected.
            if (dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("select a row plz");

            foreach (DataGridViewRow vr in dataGridView1.SelectedRows){

                var currentRow = ((DataRowView)vr.DataBoundItem).Row;
                ((DataTable)dataGridView2.DataSource).ImportRow(currentRow);

                //this will remove the rows you have selected from dataGridView1
                dataGridView1.Rows.RemoveAt(vr.Index);
            }

        }//end button click
        
        private void radioButtonDay_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDay.Checked)
            {
                labelDate.Visible = true;
                textBoxEnterDate.Visible = true;

                labelFrom.Visible = false;
                textBoxFrom.Visible = false;
                labelTo.Visible = false;
                textBoxTo.Visible = false;

                labelDocNum.Visible = false;
                textBoxDocNum.Visible = false;

            }
            else if (radioButtonDuration.Checked)
            {
                labelDate.Visible = false;
                textBoxEnterDate.Visible = false;

                labelFrom.Visible = true;
                textBoxFrom.Visible = true;
                labelTo.Visible = true;
                textBoxTo.Visible = true;

                labelDocNum.Visible = false;
                textBoxDocNum.Visible = false;
            }
            else if (radioButtonDocument.Checked)
            {
                labelDate.Visible = false;
                textBoxEnterDate.Visible = false;

                labelFrom.Visible = false;
                textBoxFrom.Visible = false;
                labelTo.Visible = false;
                textBoxTo.Visible = false;

                labelDocNum.Visible = true;
                textBoxDocNum.Visible = true;
            }
        }

        private void radioButtonDuration_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDay.Checked)
            {
                labelDate.Visible = true;
                textBoxEnterDate.Visible = true;

                labelFrom.Visible = false;
                textBoxFrom.Visible = false;
                labelTo.Visible = false;
                textBoxTo.Visible = false;

                labelDocNum.Visible = false;
                textBoxDocNum.Visible = false;

            }
            else if (radioButtonDuration.Checked)
            {
                labelDate.Visible = false;
                textBoxEnterDate.Visible = false;

                labelFrom.Visible = true;
                textBoxFrom.Visible = true;
                labelTo.Visible = true;
                textBoxTo.Visible = true;

                labelDocNum.Visible = false;
                textBoxDocNum.Visible = false;
            }
            else if (radioButtonDocument.Checked)
            {
                labelDate.Visible = false;
                textBoxEnterDate.Visible = false;

                labelFrom.Visible = false;
                textBoxFrom.Visible = false;
                labelTo.Visible = false;
                textBoxTo.Visible = false;

                labelDocNum.Visible = true;
                textBoxDocNum.Visible = true;
            }
        }

        private void radioButtonDocument_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDay.Checked)
            {
                labelDate.Visible = true;
                textBoxEnterDate.Visible = true;

                labelFrom.Visible = false;
                textBoxFrom.Visible = false;
                labelTo.Visible = false;
                textBoxTo.Visible = false;

                labelDocNum.Visible = false;
                textBoxDocNum.Visible = false;

            }
            else if (radioButtonDuration.Checked)
            {
                labelDate.Visible = false;
                textBoxEnterDate.Visible = false;

                labelFrom.Visible = true;
                textBoxFrom.Visible = true;
                labelTo.Visible = true;
                textBoxTo.Visible = true;

                labelDocNum.Visible = false;
                textBoxDocNum.Visible = false;
            }
            else if (radioButtonDocument.Checked)
            {
                labelDate.Visible = false;
                textBoxEnterDate.Visible = false;

                labelFrom.Visible = false;
                textBoxFrom.Visible = false;
                labelTo.Visible = false;
                textBoxTo.Visible = false;

                labelDocNum.Visible = true;
                textBoxDocNum.Visible = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            insertFromDGV1ToDatabase();

            insertFromDGV2ToDatabae();
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();

        }

        private void insertFromDGV2ToDatabae(){
            con.Open();

            cmd.CommandText = "TRUNCATE TABLE RelayDailyRestrictions";
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand(
                "INSERT INTO RelayDailyRestrictions (docId,accNum, accName, description," +
                " credit, debit, enterDate, refNum, cost)" +
                " VALUES (@docId,@accNum,@accName, @description," +
                " @credit, @debit, @enterDate, @refNum, @cost)", con);
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                cmd2.Parameters.Clear();
                cmd2.Parameters.AddWithValue("@docId", dataGridView2.Rows[i].Cells[1].Value);
                cmd2.Parameters.AddWithValue("@enterDate", dataGridView2.Rows[i].Cells[2].Value);
                cmd2.Parameters.AddWithValue("@refNum", dataGridView2.Rows[i].Cells[3].Value);
                cmd2.Parameters.AddWithValue("@cost", dataGridView2.Rows[i].Cells[4].Value);
                cmd2.Parameters.AddWithValue("@accNum", dataGridView2.Rows[i].Cells[5].Value);
                cmd2.Parameters.AddWithValue("@accName", dataGridView2.Rows[i].Cells[6].Value);
                cmd2.Parameters.AddWithValue("@description", dataGridView2.Rows[i].Cells[7].Value);
                cmd2.Parameters.AddWithValue("@credit", dataGridView2.Rows[i].Cells[8].Value);
                cmd2.Parameters.AddWithValue("@debit", dataGridView2.Rows[i].Cells[9].Value);

                cmd2.ExecuteNonQuery();
            }//end for
            con.Close();
        }

        private void insertFromDGV1ToDatabase(){
            con.Open();

            cmd.CommandText = "TRUNCATE TABLE DailyRestrictions";
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand(
                "INSERT INTO DailyRestrictions (docId,accNum, accName, description," +
                " credit, debit, enterDate, refNum, cost)" +
                " VALUES (@docId,@accNum,@accName, @description," +
                " @credit, @debit, @enterDate, @refNum, @cost)", con);
            for (int i = 0; i < dataGridView1.Rows.Count ; i++)
            {
                cmd2.Parameters.Clear();
                cmd2.Parameters.AddWithValue("@docId", dataGridView1.Rows[i].Cells[1].Value);
                cmd2.Parameters.AddWithValue("@enterDate", dataGridView1.Rows[i].Cells[2].Value);
                cmd2.Parameters.AddWithValue("@refNum", dataGridView1.Rows[i].Cells[3].Value);
                cmd2.Parameters.AddWithValue("@cost", dataGridView1.Rows[i].Cells[4].Value);
                cmd2.Parameters.AddWithValue("@accNum", dataGridView1.Rows[i].Cells[5].Value);
                cmd2.Parameters.AddWithValue("@accName", dataGridView1.Rows[i].Cells[6].Value);
                cmd2.Parameters.AddWithValue("@description", dataGridView1.Rows[i].Cells[7].Value);
                cmd2.Parameters.AddWithValue("@credit", dataGridView1.Rows[i].Cells[8].Value);
                cmd2.Parameters.AddWithValue("@debit", dataGridView1.Rows[i].Cells[9].Value);

                cmd2.ExecuteNonQuery();
            }//end for
            con.Close();
        }

        private void buttonBackOne_Click(object sender, EventArgs e){
            // if no ROWS selected.
            if (dataGridView2.SelectedRows.Count == 0)
                MessageBox.Show("select a row plz");

            foreach (DataGridViewRow vr in dataGridView2.SelectedRows)
            {
                var currentRow = ((DataRowView)vr.DataBoundItem).Row;
                ((DataTable)dataGridView1.DataSource).ImportRow(currentRow);

                //this will remove the rows you have selected from dataGridView1
                dataGridView2.Rows.RemoveAt(vr.Index);
            }
        }//end buttonBack

        private void buttonBackAll_Click(object sender, EventArgs e){
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            loadDataIntoGridView1();
            resizeGridView1();
        }

        private void buttonSearch_Click(object sender, EventArgs e){
            radioButtonDay.Enabled = true;
            radioButtonDocument.Enabled = true;
            radioButtonDuration.Enabled = true;
        }

        private void textBoxEnterDate_TextChanged(object sender, EventArgs e){
            DataView DV = new DataView(dataTable);
            DV.RowFilter = string.Format("enterDate LIKE '%{0}%'", textBoxEnterDate.Text);
            dataGridView1.DataSource = DV;
        }

        private void textBoxDocNum_TextChanged(object sender, EventArgs e){
            DataView DV = new DataView(dataTable);
            DV.RowFilter = string.Format("docId LIKE '%{0}%'", textBoxDocNum.Text);
            dataGridView1.DataSource = DV;
        }

        private void buttonCancelSearch_Click(object sender, EventArgs e)
        {

        }
    }
}