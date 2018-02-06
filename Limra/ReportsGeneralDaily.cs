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
            int documentType = comboBoxDocType.SelectedIndex;
            int reportType = comboBoxReportType.SelectedIndex;

            switch (documentType) {
                case 0:                  //dailyRestriction
                    switch (reportType)
                    {
                        case 0:
                            if (Application.OpenForms["CrysRepRelayedDailyRestrictionsForm"] == null)
                            {
                                new RelayedDailyRestrictionsReportForm().Show();
                            }
                            break;
                        case 1:
                            if (Application.OpenForms["CrysRepRelayedDailyRestrictionsForm"] == null)
                            {
                                new RelayedDailyRestrictionsReportForm().Show();
                            }
                            break;
                        case 2:
                            if (Application.OpenForms["CrysRepRelayedDailyRestrictionsForm"] == null)
                            {
                                new RelayedDailyRestrictionsReportForm().Show();
                            }
                            break;
                    }
                    break;
                case 1: // vocher of exchange
                    switch (reportType)
                    {
                        case 0:
                            if (Application.OpenForms["CrysRepRelayedDailyRestrictionsForm"] == null)
                            {
                                new CrysRepRelayedVocherOfExchangeForm().Show();
                            }
                            break;
                        case 1:
                            if (Application.OpenForms["CrysRepRelayedDailyRestrictionsForm"] == null)
                            {
                                new CrysRepRelayedVocherOfExchangeForm().Show();
                            }
                            break;
                        case 2:
                            if (Application.OpenForms["CrysRepRelayedDailyRestrictionsForm"] == null)
                            {
                                new CrysRepRelayedVocherOfExchangeForm().Show();
                            }
                            break;
                    }
                    break;
                case 2: //VocherOfRecievable 
                    switch (reportType)
                    {
                        case 0:
                            if (Application.OpenForms["CrysRepRelayedDailyRestrictionsForm"] == null)
                            {
                                new RelayedDailyRestrictionsReportForm().Show();
                            }
                            break;
                        case 1:
                            if (Application.OpenForms["CrysRepRelayedDailyRestrictionsForm"] == null)
                            {
                                new RelayedDailyRestrictionsReportForm().Show();
                            }
                            break;
                        case 2:
                            if (Application.OpenForms["CrysRepRelayedDailyRestrictionsForm"] == null)
                            {
                                new RelayedDailyRestrictionsReportForm().Show();
                            }
                            break;
                    }
                    break;



                default:
                    MessageBox.Show("choose an operation");
                    break;
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