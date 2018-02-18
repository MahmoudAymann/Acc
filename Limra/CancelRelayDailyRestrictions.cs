using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limra
{
    public partial class CancelRelayDailyRestrictions : Form
    {
        static string strConneciton = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con = new SqlConnection(strConneciton);
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable1, dataTable2;

        BindingSource bSource1 = new BindingSource();

        public DataTable tblTo { get; set; }

        public CancelRelayDailyRestrictions()
        {
            InitializeComponent();
            textBoxCurrentDate.Text = DateTime.Now.ToString("dd / MM / yyyy");
            loadDataIntoGridView1();
            resizeGridView1();
            resizeGridView2();
        }
        private void loadDataIntoGridView1()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT DISTINCT docId, enterDate FROM RelayDailyRestrictions";
                cmd.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                dataTable1 = new DataTable();
                adapter.Fill(dataTable1);

                bSource1.DataSource = dataTable1;

                dataGridView1.DataSource = bSource1;

                tblTo = dataTable1.Clone();

                adapter.Update(dataTable1);

                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.DataSource = dataTable1;
                dataGridView2.DataSource = tblTo;

                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message);
            }

        }//end loadDataIntoGridView1()
        private void loadDataIntoGridView2()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT DISTINCT docId, enterDate FROM RelayDailyRestrictions";
                cmd.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                dataTable2 = new DataTable();
                adapter.Fill(dataTable2);

                bSource1.DataSource = dataTable2;
                dataGridView2.DataSource = bSource1;

                tblTo = dataTable2.Clone();

                adapter.Update(dataTable2);

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

        private void resizeGridView1()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns[0].HeaderText = "رقم القيد";
            dataGridView1.Columns[1].HeaderText = "التاريخ";
        }//end resizeGridView1
        private void resizeGridView2()
        {
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView2.Columns[0].HeaderText = "رقم القيد";
            dataGridView2.Columns[1].HeaderText = "التاريخ";
        }//end resizeGridView2

        //Boxes GridView


        #region radioButtons select Event
        private void radioButtonDay_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDay.Checked)
            {
                labelDate.Visible = true;
                textBoxEnterDate.Visible = true;

                labelDocNum.Visible = false;
                textBoxDocNum.Visible = false;

            }

            else if (radioButtonDocument.Checked)
            {
                labelDate.Visible = false;
                textBoxEnterDate.Visible = false;

                labelDocNum.Visible = true;
                textBoxDocNum.Visible = true;
            }
        }
        private void radioButtonDuration_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            if (radioButtonDay.Checked)
            {
                labelDate.Visible = true;
                textBoxEnterDate.Visible = true;

                labelDocNum.Visible = false;
                textBoxDocNum.Visible = false;

            }

            else if (radioButtonDocument.Checked)
            {
                labelDate.Visible = false;
                textBoxEnterDate.Visible = false;

                labelDocNum.Visible = true;
                textBoxDocNum.Visible = true;
            }
        }
        private void radioButtonDocument_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            if (radioButtonDay.Checked)
            {
                labelDate.Visible = true;
                textBoxEnterDate.Visible = true;

                labelDocNum.Visible = false;
                textBoxDocNum.Visible = false;
            }

            else if (radioButtonDocument.Checked)
            {
                labelDate.Visible = false;
                textBoxEnterDate.Visible = false;

                labelDocNum.Visible = true;
                textBoxDocNum.Visible = true;
            }
        }
        #endregion

        #region TextBoxes Events
        private void textBoxDocNum_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonDocument.Checked)
            {
                if (dataGridView1.DataSource == null)
                {
                    loadDataIntoGridView1();
                    resizeGridView1();
                    resizeGridView2();
                }


                DataView DV = new DataView(dataTable1);
                DV.RowFilter = string.Format("Convert([docId], System.String) LIKE '%{0}%' ", textBoxDocNum.Text);
                dataGridView1.DataSource = DV;

            }
        }//end textBoxDocNum_TextChanged

        #endregion

        private void showDataIntoGridView1()
        {
            loadDataIntoGridView1();
            resizeGridView1();
            resizeGridView2();
        }

        #region Send-Back One-All Buttons
        private void buttonSendOne_Click(object sender, EventArgs e)
        {
            // if no ROWS selected.
            if (dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("select a row plz");

            foreach (DataGridViewRow vr in dataGridView1.SelectedRows)
            {
                var currentRow = ((DataRowView)vr.DataBoundItem).Row;
                ((DataTable)dataGridView2.DataSource).ImportRow(currentRow);

                //this will remove the rows you have selected from dataGridView1
                dataGridView1.Rows.RemoveAt(vr.Index);
            }
        }//end buttonSendOne
        private void buttonBackOne_Click(object sender, EventArgs e)
        {
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
        }//end buttonBackOne

        private void buttonSendAll_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            loadDataIntoGridView2();
            resizeGridView2();
        }
        private void buttonBackAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            loadDataIntoGridView1();
            resizeGridView1();
        }

        #endregion

        private void buttonSave_Click(object sender, EventArgs e)
        {  //////////////SAVE//////////////////////////
            if (dataGridView2.Rows.Count > 1 || dataGridView2.Rows.Count != 0)
            {
                insertIntoRelayDatabase();
                deleteFromNonRelayDataBase();
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            groupBox7.Visible = true;
        }

        private void deleteFromNonRelayDataBase()
        {
            con.Open();
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM RelayDailyRestrictions WHERE docId=@docId ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@docId", dataGridView2.Rows[i].Cells[0].Value);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        private void insertIntoRelayDatabase()
        {
            try
            {
                con.Open();
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO DailyRestrictions" +
                    " SELECT * FROM RelayDailyRestrictions where docId=@docId");
                    cmd.Connection = con;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@docId", dataGridView2.Rows[i].Cells[0].Value);
                    cmd.ExecuteNonQuery();
                }//end for

                con.Close();
                MessageBox.Show("done");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }//end insertAfterDeleteIntoDb
    }
}