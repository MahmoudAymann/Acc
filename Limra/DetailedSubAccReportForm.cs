using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limra
{
    public partial class DetailedSubAccReportForm : Form
    {
        DetailedSubAccountReport analyticalSubaccountReport = new DetailedSubAccountReport();

        string value;
        private const string strconneciton = @"Data Source=SPECTRA5;Initial Catalog=Limra;Integrated Security=True;TrustServerCertificate=False";
        SqlConnection con = new SqlConnection(strconneciton);
        SqlCommand cmd = new SqlCommand();

        public DetailedSubAccReportForm(string value)
        {
            InitializeComponent();
            this.value = value;
            value = analyticalSubaccountReport.textBox_AccNumber_DetailedSubAccReport.Text;
        }

        private void DetailedSubAccReportForm_Load(object sender, EventArgs e)
        {
            con.Open();
            string sqlq = "SELECT accoNum, accoNameArabic, cuurency, Debitor, Creditor FROM CalculationGuide WHERE accoNum= '" + value + "';";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlq, con);
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
