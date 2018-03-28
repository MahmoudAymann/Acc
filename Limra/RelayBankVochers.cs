using System;

using System.Data;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Limra
{
    public partial class RelayBankVochers : Form
    {
        static string strConneciton = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con = new SqlConnection(strConneciton);
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable1, dataTable2, dataTableBoxes;

        BindingSource bSource1 = new BindingSource();

        public DataTable tblTo { get; set; }

        public RelayBankVochers()
        {
            InitializeComponent();
            textBoxCurrentDate.Text = DateTime.Now.ToString("dd / MM / yyyy");
        }

        private void loadDataIntoGridView1()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT DISTINCT docID, enterDate FROM VoucherOfExchange WHERE boxNum=@boxNum AND docKind=@docKind";
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@boxNum", textBoxBoxNumber.Text);
                cmd.Parameters.AddWithValue("@docKind", "شيك");

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
            if (textBoxBoxNumber.Text != "")
            {
                try
                {
                    con.Open();
                    cmd.CommandText = "SELECT DISTINCT docID, enterDate FROM VoucherOfExchange WHERE " +
                        "boxNum=@boxNum AND docKind=@docKind";
                    cmd.Connection = con;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@boxNum", textBoxBoxNumber.Text);
                    cmd.Parameters.AddWithValue("@docKind", "شيك");
                                                         
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
            }
            else
                MessageBox.Show("enter box number");
        }//end loadDataIntoGridView2

        private void resizeGridView1()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns[0].HeaderText = "رقم المستند";
            dataGridView1.Columns[1].HeaderText = "التاريخ";
        }//end resizeGridView1
        private void resizeGridView2()
        {
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView2.Columns[0].HeaderText = "رقم المستند";
            dataGridView2.Columns[1].HeaderText = "التاريخ";
        }//end resizeGridView2

        //Boxes GridView
        private void loadDataIntoGridViewBoxes()
        {
            if (textBoxBoxNumber.Text != "")
            {
                try
                {
                    con.Open();
                    cmd.CommandText = "SELECT DISTINCT boxNum, boxName FROM VoucherOfExchange WHERE docKind=@docKind";
                    cmd.Connection = con;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@docKind","شيك");

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;

                    dataTableBoxes = new DataTable();
                    adapter.Fill(dataTableBoxes);

                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dataTableBoxes;

                    dataGridViewBoxes.DataSource = bSource;

                    adapter.Update(dataTableBoxes);
                    con.Close();
                }
                catch (Exception e)
                {
                    con.Close();
                    MessageBox.Show("تاكد من ادخال رقم الحساب صحيحاً");
                    MessageBox.Show(e.Message);
                }
            }//end if

        }//end loadDataIntoGridViewBoxes()
        private void resizeGridViewBoxes()
        {
            dataGridViewBoxes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewBoxes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridViewBoxes.Columns[0].HeaderText = "رقم الصندوق";
            dataGridViewBoxes.Columns[1].HeaderText = "اسم الصندوق";

        }//end resizeGridViewBoxes()

        #region radioButtons select Event
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
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

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
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

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
        #endregion

        #region TextBoxes Events
        private void textBoxBoxNumber_Enter(object sender, EventArgs e)
        {
            if (radioButtonExchange.Checked != true && radioButtonReciept.Checked != true)
            {
                MessageBox.Show("تاكد من اختيار العملية");
            }
        }

        private void textBoxDocNum_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            if (radioButtonDocument.Checked)
            {
                if (dataGridView1.DataSource == null)
                {
                    loadDataIntoGridView1();
                    resizeGridView1();
                }

                dataGridView1.Visible = true;

                DataView DV = new DataView(dataTable1);
                DV.RowFilter = string.Format(" Convert([docID], System.String) LIKE '%{0}%' ", textBoxDocNum.Text);
                dataGridView1.DataSource = DV;

            }


        }//end textBoxDocNum_TextChanged

        private void textBoxBoxNumber_TextChanged(object sender, EventArgs e)
        {
            dataGridViewBoxes.Visible = true;

            if (radioButtonExchange.Checked) //sarf
            {
                if (dataGridViewBoxes.DataSource == null)
                {
                    loadDataIntoGridViewBoxes();
                    resizeGridViewBoxes();
                }

                dataGridViewBoxes.Visible = true;

                DataView DV = new DataView(dataTableBoxes);
                DV.RowFilter = string.Format(" Convert([boxNum], System.String) LIKE '%{0}%' ", textBoxBoxNumber.Text);
                dataGridViewBoxes.DataSource = DV;
            }

        }//end textBoxBoxNumber_TextChanged
        #endregion

        private void showDataIntoGridView1()
        {
            loadDataIntoGridView1();
            resizeGridView1();
            resizeGridView2();
        }

        private void dataGridViewBoxes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewBoxes.Rows[e.RowIndex];
                textBoxBoxNumber.Text = row.Cells[0].Value.ToString();
                textBoxBoxName.Text = row.Cells[1].Value.ToString();
            }
            dataGridViewBoxes.Visible = false;
            showDataIntoGridView1();
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

        private void deleteFromNonRelayDataBase()
        {
            con.Open();
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM VoucherOfExchange WHERE docID=@docID ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@docID", dataGridView2.Rows[i].Cells[0].Value);
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
                    SqlCommand cmd = new SqlCommand("INSERT INTO RelayVoucherOfExchange" +
                    "(docId, docKind, boxNum, boxAccNum, boxName, boxDescription, boxCost," +
                    "accNum,accName,notes,cost,enterDate,refrencer)" +
                    " SELECT docID, docKind, boxNum, boxAccNum,boxName, boxDescription, boxCost," +
                    "accNum,accName,notes,cost,enterDate,refrencer FROM VoucherOfExchange where docID=@docID");
                    cmd.Connection = con;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@docID", dataGridView2.Rows[i].Cells[0].Value);
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