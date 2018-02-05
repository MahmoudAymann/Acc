using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Limra
{
    public partial class SalesBills : Form
    {
        //DataGridView2 for Accounts
        //DataGridView3 for Agents
        //DataGridView4 for Items

        private const string strconneciton = @"Data Source=SPECTRA5;Initial Catalog=Limra;Integrated Security=True;TrustServerCertificate=False";
        SqlConnection con = new SqlConnection(strconneciton);
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable;

        public SalesBills()
        {
            InitializeComponent();
            
        }

        #region load and resize gridViews
        private void resizeGridView2()
        {
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView2.Columns[0].HeaderText = "رقم الحساب";
            dataGridView2.Columns[1].HeaderText = "اسم الحساب";


        }//end resizeGridView2

        private void loadDataIntoGridView2()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT accNum, accName FROM Boxes";
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

        private void resizeGridView1Cash()
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

            dataGridView1.Columns[0].HeaderText = "رقم الفاتورة";
            dataGridView1.Columns[1].HeaderText = "التاريخ";
            dataGridView1.Columns[2].HeaderText = "نوع الفاتورة";
            dataGridView1.Columns[3].HeaderText = "رقم الحساب";
            dataGridView1.Columns[4].HeaderText = "اسم الحساب";
            dataGridView1.Columns[5].HeaderText = "العملة";
            dataGridView1.Columns[6].HeaderText = "اسم العميل";
            dataGridView1.Columns[7].HeaderText = "البيان";
            dataGridView1.Columns[8].HeaderText = "رقم الصنف";
            dataGridView1.Columns[9].HeaderText = "اسم الصنف";
            dataGridView1.Columns[10].HeaderText = "وحدة القياس";
            dataGridView1.Columns[11].HeaderText = "الكمية";
            dataGridView1.Columns[12].HeaderText = "سعر الواحدة";
            dataGridView1.Columns[13].HeaderText = "اجمالى";
            dataGridView1.Columns[14].HeaderText = "تليفون";
            dataGridView1.Columns[15].HeaderText = "حد الدين";

        }//end resizeGridView1Chique

        private void resizeGridView1Postponement()
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
            
            dataGridView1.Columns[0].HeaderText = "رقم الفاتورة";
            dataGridView1.Columns[1].HeaderText = "التاريخ";
            dataGridView1.Columns[2].HeaderText = "نوع الفاتورة";
            dataGridView1.Columns[3].HeaderText = "تاريخ الدفع";
            dataGridView1.Columns[4].HeaderText = "العملة";
            dataGridView1.Columns[5].HeaderText = "اسم العميل";
            dataGridView1.Columns[6].HeaderText = "البيان";
            dataGridView1.Columns[7].HeaderText = "رقم الصنف";
            dataGridView1.Columns[8].HeaderText = "اسم الصنف";
            dataGridView1.Columns[9].HeaderText = "وحدة القياس";
           dataGridView1.Columns[10].HeaderText = "الكمية";
           dataGridView1.Columns[11].HeaderText = "سعر الواحدة";
           dataGridView1.Columns[12].HeaderText = "اجمالى";
           dataGridView1.Columns[13].HeaderText = "تليفون";
           dataGridView1.Columns[14].HeaderText = "حد الدين";
            
        }//end resizeGridView1Postponement

        private void resizeGridView1Chique()
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


            dataGridView1.Columns[0].HeaderText = "رقم الفاتورة";
            dataGridView1.Columns[1].HeaderText = "التاريخ";
            dataGridView1.Columns[2].HeaderText = "نوع الفاتورة";
            dataGridView1.Columns[3].HeaderText = "رقم الشيك";
            dataGridView1.Columns[4].HeaderText = "مبلغ الشيك";
            dataGridView1.Columns[5].HeaderText = "العملة";
            dataGridView1.Columns[6].HeaderText = "اسم العميل";
            dataGridView1.Columns[7].HeaderText = "البيان";
            dataGridView1.Columns[8].HeaderText = "رقم الصنف";
            dataGridView1.Columns[9].HeaderText = "اسم الصنف";
            dataGridView1.Columns[10].HeaderText = "وحدة القياس";
            dataGridView1.Columns[11].HeaderText = "الكمية";
            dataGridView1.Columns[12].HeaderText = "سعر الواحدة";
            dataGridView1.Columns[13].HeaderText = "اجمالى";
            dataGridView1.Columns[14].HeaderText = "تليفون";
            dataGridView1.Columns[15].HeaderText = "حد الدين";

        }//end resizeGridView1Chique

        private void loadDataIntoGridView1Cash()
        {
            try{
                con.Open();
                //cmd.CommandText = "SELECT * FROM SalesBills";
                cmd.CommandText = "SELECT id,currentDate,kind,accountNum,accountName,currency," +
                    "agentName,description,itemNum,itemName,measruingUnit,quantity,singleCost,singleTotalCost," +
                    "agentPhone,debitLimit FROM SalesBills WHERE kind = @kind ";
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@kind", radioButtonCash.Text);

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
            catch (Exception ed){
                con.Close();
                MessageBox.Show(ed.Message);
            }
        }//end loadDataIntoGridView1Cash

        private void loadDataIntoGridView1Chique()
        {
            try
            {
                con.Open();
                //cmd.CommandText = "SELECT * FROM SalesBills";
                cmd.CommandText = "SELECT id, currentDate, kind, chequeNum, chequeAmount, currency," +
                    "agentName, description, itemNum, itemName, measruingUnit, quantity, singleCost, singleTotalCost," +
                    "agentPhone, debitLimit FROM SalesBills WHERE kind = @kind";
                cmd.Connection = con;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@kind", radioButtonChique.Text);
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
        }//end loadDataIntoGridView1Chique

        private void loadDataIntoGridView1Postponed()
        {
            try
            {
                con.Open();
                //cmd.CommandText = "SELECT * FROM SalesBills";
                cmd.CommandText = "SELECT id,currentDate, kind, payDate, currency," +
                    "agentName, description, itemNum, itemName, measruingUnit, quantity, singleCost, singleTotalCost," +
                    "agentPhone, debitLimit FROM SalesBills WHERE kind = @kind";
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@kind",radioButtonPostponed.Text);

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
        }//end loadDataIntoGridView1Postponed
        
        private void resizeGridView4()
        {
            dataGridView4.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView4.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView4.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


            dataGridView4.Columns[0].HeaderText = "رقم الصنف";
            dataGridView4.Columns[1].HeaderText = "اسم الصنف";
            dataGridView4.Columns[2].HeaderText = "الوحدة";


        }//end resizeGridView4

        private void loadDataIntoGridView4()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT num, nameArabic, measurmentUnit FROM ItemData";
                cmd.Connection = con;

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
        }//end loadDataIntoGridView4

        private void resizeGridView3(){
            dataGridView3.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView3.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView3.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView3.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView3.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView3.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView3.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView3.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
           dataGridView3.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
           dataGridView3.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView3.Columns[0].HeaderText = "رقم العميل";
            dataGridView3.Columns[1].HeaderText = "رقم حساب العميل";
            dataGridView3.Columns[2].HeaderText = "اسم العميل";
            dataGridView3.Columns[3].HeaderText = "العنوان";
            dataGridView3.Columns[4].HeaderText = "التليفون";
            dataGridView3.Columns[5].HeaderText = "الاسم الاجنبى";
            dataGridView3.Columns[6].HeaderText = "رقم الفاكس";
            dataGridView3.Columns[7].HeaderText = "الرمز البريدى";
            dataGridView3.Columns[8].HeaderText = "المدينة";
            dataGridView3.Columns[9].HeaderText = "الدولة";
           dataGridView3.Columns[10].HeaderText = "حد الديوان";
           dataGridView3.Columns[11].HeaderText = "عن طريق";

        }//end resizeGridView3

        private void loadDataIntoGridView3()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM AgentsData";
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
        #endregion

        private void fillAccoCost(string asd)
        {
            con.Open();
            string sqlquery = "SELECT cuurency FROM CalculationGuide WHERE accoNum=@accoNum";
            SqlCommand command = new SqlCommand(sqlquery, con);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@accoNum", asd);
            textBoxCurrency.Text = command.ExecuteScalar().ToString();
            con.Close();
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dataGridView2.SelectedCells[0].RowIndex;
            textBoxAccouNum.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            textBoxAccoName.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();

            fillAccoCost(dataGridView2.Rows[i].Cells[0].Value.ToString());
        }

        private void SalesBills_Load(object sender, EventArgs e)
        {
            textBoxCurrentDate.Text = DateTime.Now.ToString("dd / MM / yyyy");
        }

        #region check Boxes

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                loadDataIntoGridView3();
                resizeGridView3();
            }
            else if (checkBox1.Checked == false)
            {
                dataGridView3.DataSource = null;
                dataGridView3.Rows.Clear();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && radioButtonCash.Checked)
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                loadDataIntoGridView4();
                resizeGridView4();
            }
            else if (checkBox3.Checked == false)
            {
                dataGridView4.DataSource = null;
                dataGridView4.Rows.Clear();
            }
        }
        #endregion

        #region radioButtons
        private void radioButtonPostponed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPostponed.Checked)
            {
                labelAccountNum.Text = "وقت الدفع";
                groupBox3.Text = "دفع فى فترة محددة";
                labelAccountName.Visible = false;
                textBoxAccoName.Visible = false;
                checkBox1.Enabled = false;
                checkBox1.Checked = false;

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                loadDataIntoGridView1Postponed();
                resizeGridView1Postponement();
                
                dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();
            }

        }

        private void radioButtonChique_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonChique.Checked == true)
            {
                labelAccountNum.Text = "رقم الشيك:";
                labelAccountName.Text = "مبلغ الشيك:";
                textBoxAccoName.Visible = true;
                labelAccountNum.Visible = true;
                labelAccountName.Visible = true;
                labelCurrency.Visible = true;

                textBoxCurrency.Visible = true;
                textBoxAccoName.Enabled = true;

                textBoxAccouNum.Enabled = true;
                textBoxAccouNum.Visible = true;
                

                groupBox3.Text = "بيانات الشيك";
                labelCurrency.Visible = true;
                textBoxCurrency.Visible = true;
                textBoxCurrency.Enabled = true;

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                loadDataIntoGridView1Chique();
                resizeGridView1Chique();
                
                checkBox1.Enabled = false;
                checkBox1.Checked = false;

                dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();
            }
        }

        private void radioButtonCash_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCash.Checked)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                textBoxAccoName.Enabled = false;
                labelCurrency.Visible = true;
                textBoxCurrency.Visible = true;
                textBoxCurrency.Enabled = false;


                loadDataIntoGridView1Cash();
                resizeGridView1Cash();

                labelAccountNum.Text = "رقم الحساب:";
                labelAccountName.Text = "اسم الحساب:";
                textBoxAccouNum.Visible = true;
                textBoxAccoName.Visible = true;
                checkBox1.Enabled = true;
                groupBox3.Text = "بيانات الحساب";

                if (checkBox1.Checked){
                    loadDataIntoGridView2();
                    resizeGridView2();
                }
            } 
        }
        #endregion

        private void dataGridView3_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView3.Rows[e.RowIndex];
                textBoxAgentName.Text = row.Cells[2].Value.ToString();

                getAgentInfo(row.Cells[0].Value.ToString());
            }
        }

        private void getAgentInfo(string key)
        {
            con.Open();
            string sqlquery = "SELECT * FROM AgentsData WHERE id = @id";
            SqlCommand command = new SqlCommand(sqlquery, con);
            SqlDataReader oReader;
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", key);
            oReader = command.ExecuteReader();
            while (oReader.Read())
            {
                textBoxAgentPhone.Text = oReader["phone"].ToString();
                textBoxLimit.Text = oReader["deptLimit"].ToString();
            }
            con.Close();
        }

        private void dataGridView4_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView4.Rows[e.RowIndex];

                textBoxItemNum.Text = row.Cells[0].Value.ToString();
                textBoxItemName.Text = row.Cells[1].Value.ToString();
                textBoxUnitMeasurements.Text = row.Cells[2].Value.ToString();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (radioButtonCash.Checked == true)
            {
                insertDataCash();
                loadDataIntoGridView1Cash();
                resizeGridView1Cash();
            }
            else if (radioButtonChique.Checked == true)
            {
                insertDataChique();
                loadDataIntoGridView1Chique();
                resizeGridView1Chique();
            }
            else if (radioButtonPostponed.Checked == true)
            {
                insertDataPostponment();
                loadDataIntoGridView1Postponed();
                resizeGridView1Postponement();
            }
        }//end Add

        private void insertDataPostponment()
        {
            try
            {
                con.Open();
                cmd.CommandText =
                "INSERT INTO SalesBills (id,currentDate,kind,payDate,currency," +
                " agentName,description,itemNum,itemName,measruingUnit,quantity," +
                "singleCost,singleTotalCost,agentPhone,debitLimit)" +
                " VALUES (@id, @currentDate, @kind, @payDate, @currency," +
                    " @agentName, @description, @itemNum, @itemName," +
                    " @measruingUnit, @quantity, @singleCost,@singleTotalCost," +
                    "@agentPhone,@debitLimit)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@id", textBoxBillNum.Text);
                cmd.Parameters.AddWithValue("@currentDate", textBoxCurrentDate.Text);
                cmd.Parameters.AddWithValue("@kind",radioButtonPostponed.Text);
                cmd.Parameters.AddWithValue("@payDate", textBoxAccouNum.Text);
                cmd.Parameters.AddWithValue("@currency", textBoxCurrency.Text);
                cmd.Parameters.AddWithValue("@agentName", textBoxAgentName.Text);
                cmd.Parameters.AddWithValue("@description", textBoxDescription.Text);
                cmd.Parameters.AddWithValue("@itemNum", textBoxItemNum.Text);
                cmd.Parameters.AddWithValue("@itemName", textBoxItemName.Text);
                cmd.Parameters.AddWithValue("@measruingUnit", textBoxUnitMeasurements.Text);
                cmd.Parameters.AddWithValue("@quantity", textBoxQuantity.Text);
                cmd.Parameters.AddWithValue("@singleCost", textBoxCost.Text);
                cmd.Parameters.AddWithValue("@singleTotalCost", "00");
                cmd.Parameters.AddWithValue("@agentPhone", textBoxAgentPhone.Text);
                cmd.Parameters.AddWithValue("@debitLimit", textBoxLimit.Text);
                
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
               con.Close();
                MessageBox.Show(ex.Message);
            }
        }//end insertData()

        private void insertDataCash()
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO SalesBills (id, currentDate, kind, accountNum, accountName, currency," +
                " agentName, description, itemNum, itemName, measruingUnit, quantity," +
                "singleCost,singleTotalCost,agentPhone,debitLimit)" +
                " VALUES(@id, @currentDate, @kind, @accountNum, @accountName, @currency," +
                    " @agentName, @description, @itemNum, @itemName," +
                    " @measruingUnit, @quantity, @singleCost,@singleTotalCost," +
                    "@agentPhone,@debitLimit)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@id", textBoxBillNum.Text);
                cmd.Parameters.AddWithValue("@currentDate", textBoxCurrentDate.Text);
                cmd.Parameters.AddWithValue("@kind", radioButtonCash.Text);
                cmd.Parameters.AddWithValue("@accountNum", textBoxAccouNum.Text);
                cmd.Parameters.AddWithValue("@accountName", textBoxAccoName.Text);
                cmd.Parameters.AddWithValue("@currency", textBoxCurrency.Text);
                cmd.Parameters.AddWithValue("@agentName", textBoxAgentName.Text);
                cmd.Parameters.AddWithValue("@description", textBoxDescription.Text);
                cmd.Parameters.AddWithValue("@itemNum", textBoxItemNum.Text);
                cmd.Parameters.AddWithValue("@itemName", textBoxItemName.Text);
                cmd.Parameters.AddWithValue("@measruingUnit", textBoxUnitMeasurements.Text);
                cmd.Parameters.AddWithValue("@quantity", textBoxQuantity.Text);
                cmd.Parameters.AddWithValue("@singleCost", textBoxCost.Text);
                cmd.Parameters.AddWithValue("@singleTotalCost", "00");
                cmd.Parameters.AddWithValue("@agentPhone", textBoxAgentPhone.Text);
                cmd.Parameters.AddWithValue("@debitLimit", textBoxLimit.Text);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }//end insertDataCash()

        private void insertDataChique()
        {
            try
            {
                con.Open();
             cmd.CommandText = "INSERT INTO SalesBills (id, currentDate, kind,chequeNum ,chequeAmount,currency," +
                " agentName, description, itemNum, itemName, measruingUnit, quantity," +
                "singleCost, singleTotalCost, agentPhone, debitLimit)" +
             " VALUES(@id, @currentDate, @kind, @chequeNum, @chequeAmount, @currency," +
                    " @agentName, @description, @itemNum, @itemName," +
                    " @measruingUnit, @quantity, @singleCost,@singleTotalCost," +
                    "@agentPhone, @debitLimit)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@id", textBoxBillNum.Text);
                cmd.Parameters.AddWithValue("@currentDate", textBoxCurrentDate.Text);
                cmd.Parameters.AddWithValue("@kind", radioButtonChique.Text);
                cmd.Parameters.AddWithValue("@chequeNum", textBoxAccouNum.Text);
                cmd.Parameters.AddWithValue("@chequeAmount", textBoxAccoName.Text);
                cmd.Parameters.AddWithValue("@currency", textBoxCurrency.Text);
                cmd.Parameters.AddWithValue("@agentName", textBoxAgentName.Text);
                cmd.Parameters.AddWithValue("@description", textBoxDescription.Text);
                cmd.Parameters.AddWithValue("@itemNum", textBoxItemNum.Text);
                cmd.Parameters.AddWithValue("@itemName", textBoxItemName.Text);
                cmd.Parameters.AddWithValue("@measruingUnit", textBoxUnitMeasurements.Text);
                cmd.Parameters.AddWithValue("@quantity", textBoxQuantity.Text);
                cmd.Parameters.AddWithValue("@singleCost", textBoxCost.Text);
                cmd.Parameters.AddWithValue("@singleTotalCost", "00");  
                cmd.Parameters.AddWithValue("@agentPhone", textBoxAgentPhone.Text);
                cmd.Parameters.AddWithValue("@debitLimit", textBoxLimit.Text);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }//end insertDataChique()
    }
}
