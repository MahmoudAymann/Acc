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
    public partial class CrysRepVocherOfExchangeFrom : Form
    {
        public CrysRepVocherOfExchangeFrom()
        {
            InitializeComponent();
        }

        private void CrystalReportForm_Load(object sender, EventArgs e)
        {
            CrysRepVocherOfExchange crystalReport1 = new CrysRepVocherOfExchange();
            crystalReportViewer1.ReportSource = crystalReport1;


        }
    }
}