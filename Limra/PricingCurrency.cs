using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Limra
{
    public partial class PricingCurrency : Form
    {
        static string strConneciton = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        SqlConnection con = new SqlConnection(strConneciton);
        SqlCommand cmd = new SqlCommand();

        public PricingCurrency()
        {
            InitializeComponent();
            fillComboBoxCurrency();
        }
        
            void fillComboBoxCurrency()
            {
                string query = "select * from CurrencyInfo;";
                cmd.CommandText = query;
                cmd.Connection = con;
                SqlDataReader sqlReader;
                try
                {
                    con.Open();
                    sqlReader = cmd.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        string col = sqlReader["name"].ToString();
                        comboBox1.Items.Add(col);
                    }

                    con.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }//end fillComboBoxCompanyInfo
        

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            comboBox1.Text = "";
        }
    }
}
