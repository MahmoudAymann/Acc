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
    public partial class CrysRepRelayedVocherOfExchangeForm : Form
    {
        public CrysRepRelayedVocherOfExchangeForm()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrysRepRelayedVocherOfExchange crystalReport1 = new CrysRepRelayedVocherOfExchange();
            crystalReportViewer1.ReportSource = crystalReport1;
        }
    }
}
