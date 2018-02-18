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
    public partial class BalanceSheetReport : Form
    {
       public static int radiobutton;
       public static string month="";
       public static string level="";

        public BalanceSheetReport()
        {
            InitializeComponent();
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            if (radioButtonMain.Checked)
            {
                radiobutton = 1;
                if (textBoxMonth.Text !="")
                    month = textBoxMonth.Text;

                if (textBoxLevel.Text != "")
                    level = textBoxLevel.Text;

                new BalanceSheetReportForm(radiobutton, month, level).Show();
            }
            else if (radioButtonMain.Checked)
            {
                radiobutton = 2;
                if (textBoxMonth.Text != "")
                    month = textBoxMonth.Text;

                if (textBoxLevel.Text != "")
                    level = textBoxLevel.Text;

                new BalanceSheetReportForm(radiobutton, month, level).Show();
            }
            else if (radioButtonMain.Checked)
            {
                radiobutton = 3;
                if (textBoxMonth.Text != "")
                    month = textBoxMonth.Text;

                if (textBoxLevel.Text != "")
                    level = textBoxLevel.Text;

                new BalanceSheetReportForm(radiobutton, month, level).Show();
            }
            
        }//end print_click
        
    }//end BalanceSheetReport
}//end namespace