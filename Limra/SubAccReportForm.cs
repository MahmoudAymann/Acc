using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limra
{
    public partial class SubAccReportForm : Form
    {
        SubAccountReport analyticalSubaccountReport = new SubAccountReport();
            
        string value;
        public SubAccReportForm(string value)
        {
            InitializeComponent();
            this.value = value;
            value = analyticalSubaccountReport.textBox_AccNumber_AnalyticalSubaccountReport.Text;
        }

        private const string strconneciton = @"Data Source=SPECTRA5;Initial Catalog=Limra;Integrated Security=True;TrustServerCertificate=False";
        SqlConnection con = new SqlConnection(strconneciton);
        SqlCommand cmd = new SqlCommand();
        
        private void ReportAnaliticSubAccForm_Load(object sender, EventArgs e)
        {
            con.Open();
            string sqlq = "SELECT accoNum, accoNameArabic, Debitor, Creditor FROM CalculationGuide WHERE accoNum= '" + value + "';";
            SqlDataAdapter  sqlDataAdapter = new SqlDataAdapter(sqlq, con);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            con.Close();

            SubAccountCrysRep objRpt = new SubAccountCrysRep();
            objRpt.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
        }
    }
}