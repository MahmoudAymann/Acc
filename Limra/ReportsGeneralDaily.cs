using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limra
{
    public partial class ReportsGeneralDaily : Form
    {
        public ReportsGeneralDaily()
        {
            InitializeComponent();
        }

        
        private void ReportsGeneralDaily_Load(object sender, EventArgs e)
        {

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (comboBoxDocType.SelectedIndex == 2) //سندات صرف
            {
                if (comboBoxReportType.SelectedIndex == 0)//حسب ارقام الوثائق
                {
                    if (Application.OpenForms["CrysRepRelayedVocherOfExchangeForm"] == null)
                    {
                        new CrysRepRelayedVocherOfExchangeForm().Show();
                    }
                }
            }
        }

        private void comboBoxReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxReportType.SelectedIndex == 1 || comboBoxReportType.SelectedIndex == 2)
            {
                labelFromAcc.Visible = true;
                textBoxFromAcc.Visible = true;
                labelToAcc.Visible = true;
                textBoxToAcc.Visible = true;
            }
        }
    }
}
