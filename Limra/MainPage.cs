using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limra
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ribbonButton7_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["DailyRestrictions"] == null)
            {
                new CancelRelayDailyRestrictions().Show();
            }
        }

        private void ribbonButton6_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CashBonds"] == null)
            {
                new CancelRelayCashBonds().Show();
            }
        }

        private void ribbonButton5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["BankBonds"] == null)
            {
                new CancelRelayBankBonds().Show();
            }
        }

        private void ribbonButton4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SupplyOrders"] == null)
            {
                new CancleRelaySupplyOrders().Show();
            }
        }

        private void ribbonButton3_Click(object sender, EventArgs e)
        {
                if (Application.OpenForms["ExchangeOrders"] == null)
            {
                new CancelRelayExchangeOrders().Show();
            }
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesBills"] == null) {

                new RelaySalesBills().Show();
            }
        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesReturns"] == null)
            {
                new SalesReturns().Show();
            }
        }

        private void ribbonButton11_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["OpenNewYear"] == null)
            {
                new OpenNewYear().Show();
            }
        }

        private void ribbonButton10_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["TransferOfStoreHouses"] == null)
            {
                new TransferOfStoresBalances().Show();
            }
        }

        private void ribbonButton9_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ClosingProfitAndLoss"] == null)
            {
                new ClosingProfitAndLoss().Show();
            }
        }

        private void ribbonButton8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("شوف البرنامج");
        }

        private void ribbonButton13_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["MaintenanceOfBranches"] == null)
            {
                new MaintenanceOfBranches().Show();
            }
        }

        private void ribbonButton12_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["UsersPermisions"] == null)
            {
                new UsersPermisions().Show();
            }
        }

        private void ribbonButton17_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CurrencyInfo"] == null)
            {
                new CurrencyInfo().Show();
            }
        }
        
        private void ribbonButton21_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["PricingCurrency"] == null)
            {
                new PricingCurrency().Show();
            }
        }

       
        private void ribbonButton19_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Boxes"] == null)
            {
                new Boxes().Show();
            }
        }

        private void ribbonButton18_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Banks"] == null)
            {
                new Banks().Show();
            }
        }

        private void ribbonButton24_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SystemStartDate"] == null)
            {
                new SystemStartDate().Show();
            }
        }

        private void ribbonButton29_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CalculationsGuide"] == null)
            {
                new CalculationsGuide().Show();
            }
            else
            {
                MessageBox.Show("مفتوحة مسبقاً");
            }
        }

        private void ribbonButton27_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Receipt"] == null)
            {
                new VocherOfRecievable().Show();
            }
        }

        private void ribbonButton26_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["BillsOfExchange"] == null)
            {
                new VoucherOfExchange().Show();
            }
        }

        private void ribbonButton47_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RelayDailyRestrictions"] == null)
            {
                new RelayDailyRestrictions().Show();
            }
        }

        private void ribbonButton46_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RelayCashBonds"] == null)
            {
                new RelayCashVochers().Show();
            }
        }

        private void ribbonButton45_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RelayBankBonds"] == null)
            {
                new RelayBankVochers().Show();
            }
        }

        private void ribbonButton44_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RelaySupplyOrders"] == null)
            {
                new RelaySupplyOrders().Show();
            }
        }

        private void ribbonButton43_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RelayExchangeOrders"] == null)
            {
                new RelayExchangeOrders().Show();
            }
        }

        private void ribbonButton42_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CancleRelaySalesBills"] == null)
            {
                new CancleRelaySalesBills().Show();
            }
        }

        private void ribbonButton41_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RelaySalesReturn"] == null)
            {
                new RelaySalesReturn().Show();
            }
        }

        private void ribbonButton28_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["DailyRestrictions"] == null)
            {
                new DailyRestrictions().Show();
            }
        }

        private void ribbonButton35_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["StoreInfo"] == null)
            {
                new StoreInfo().Show();
            }
        }

        private void ribbonButton34_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["DataGroup"] == null)
            {
                new StoringGroup().Show();
            }
        }

        private void ribbonButton38_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ItemData"] == null)
            {
                new ItemData().Show();
            }
        }

        private void ribbonButton37_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["StoringItems"] == null)
            {
                new StoringItems().Show();
            }
        }

        private void ribbonButton32_Click(object sender, EventArgs e)
        {
            
        }

        private void ribbonButton31_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["StoreOrders"] == null)
            {
                new StoreSupplyOrders().Show();
            }
        }

        private void ribbonButton30_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ExchangeOrders"] == null)
            {
                new StoreExchangeOrders().Show();
            }
        }

        private void ribbonButton40_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AgentsData"] == null)
            {
                new AgentsData().Show();
            }
        }

        private void ribbonButton39_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesBills"] == null)
            {
                new SalesBills().Show();
            }
        }

        private void ribbonButton25_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["BillsOfSalesReturns"] == null)
            {
                new SalesReturnsBills().Show();
            }
        }

        private void ribbonButton51_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Inventories"] == null)
            {
                new Inventories().Show();
            }
        }

        private void ribbonButton50_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["InventoryInput"] == null)
            {
                new  InventoryInput().Show();
            }
        }

        private void ribbonButton49_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["InventoryReportPlus"] == null)
            {
                new InventoryReportPlus().Show();
            }
        }

        private void ribbonButton48_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["InventoryReportMinus"] == null)
            {
                new InventoryReportMinus().Show();
            }
        }

        private void ribbonButton56_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["PrintCalculationsGuide"] == null)
            {
                new PrintCalculationsGuide().Show();
            }
        }

        private void ribbonButton88_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["LeftMonetaryBonds"] == null)
            {
                new LeftMonetaryBondsReports().Show();
            }
        }

        private void ribbonButton87_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["LeftDailyRestrictionsReports"] == null)
            {
                new LeftDailyRestrictionsReports().Show();
            }
        }

        private void ribbonButton86_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["LeftBankyBondsReports"] == null)
            {
                new LeftBankyBondsReports().Show();
            }
        }

        private void ribbonButton85_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["LeftSupplyOrdersReports"] == null)
            {
                new LeftSupplyOrdersReports().Show();
            }
        }

        private void ribbonButton84_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["LeftExchangeOrdersReport"] == null)
            {
                new LeftExchangeOrdersReport().Show();
            }
        }

        private void ribbonButton83_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["LeftSalesBillReport"] == null)
            {
                new LeftSalesBillReport().Show();
            }
        }

        private void ribbonButton82_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["LeftSalesReturnReport"] == null)
            {
                new LeftSalesReturnReport().Show();
            }
        }

        private void ribbonButton55_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ReportsGeneralDaily"] == null)
            {
                new ReportsGeneralDaily().Show();
            }
        }

        private void ribbonButton54_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["TrilaBalanceReport"] == null)
            {
                new TrilaBalanceReport().Show();
            }
        }

        private void ribbonButton53_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ProfitAndLossReport"] == null)
            {
                new ProfitAndLossReport().Show();
            }
        }

        private void ribbonButton52_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["BalanceSheetReport"] == null)
            {
                new BalanceSheetReport().Show();
            }
        }

        private void ribbonButton64_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AgentsDataReports"] == null)
            {
                new AgentsDataReports().Show();
            }
        }

        private void ribbonButton63_Click(object sender, EventArgs e)
        {
                if (Application.OpenForms["ProfitMarginReports"] == null)
            {
                new ProfitMarginReports().Show();
            }
        }

        private void ribbonButton62_Click(object sender, EventArgs e)
        {
                if (Application.OpenForms["SubAccountReport"] == null)
            {
                new SubAccountReport().Show();
            }
        }

        private void ribbonButton61_Click(object sender, EventArgs e)
        {
            
             if (Application.OpenForms["AnalyticalMajorAccountReport"] == null)
            {
                new AnalyticalMajorAccountReport().Show();
            }
        }

        private void ribbonButton60_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["DetailedSubAccountReport"] == null)
            {
                new DetailedSubAccountReport().Show();
            }
        }

        private void ribbonButton59_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["TotalMajorAccountReport"] == null)
            {
                new TotalMajorAccountReport().Show();
            }
        }

        private void ribbonButton58_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["MonthlyMovementBalancesReport"] == null)
            {
                new MonthlyMovementBalancesReport().Show();
            }
        }

        private void ribbonButton57_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CurrentBalancesReport"] == null)
            {
                new CurrentBalancesReport().Show();
            }
        }

        private void ribbonButton73_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesReportsBillsForASpecificDuration"] == null)
            {
                new SalesReportsBillsForASpecificDuration().Show();
            } 
        }

        private void ribbonButton72_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesReportsInvoiceByCustomer"] == null)
            {
                new SalesReportsInvoiceByCustomer().Show();
            }
        }

        private void ribbonButton71_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesReportsInvoiceByItems"] == null)
            {
                new SalesReportsInvoiceByItems().Show();
            }
        }

        private void ribbonButton70_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesReportsInvoiceByMajorGroups"] == null)
            {
                new SalesReportsInvoiceByMajorGroups().Show();
            }
        }

        private void ribbonButton69_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesReportsInvoiceByMonetary"] == null)
            {
                new SalesReportsInvoiceByMonetary().Show();
            }
        }

        private void ribbonButton68_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesReportsInvoiceByChecks"] == null)
            {
                new SalesReportsInvoiceByChecks().Show();
            }
        }

        private void ribbonButton67_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesReportsInvoiceByChecksAndMonetary"] == null)
            {
                new SalesReportsInvoiceByChecksAndMonetary().Show();
            }
        }

        private void ribbonButton66_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesReportsInvoiceByFuture"] == null)
            {
                new SalesReportsInvoiceByFuture().Show();
            }
        }

        private void ribbonButton81_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesReturnBillsForASpecificDuration"] == null)
            {
                new SalesReturnBillsForASpecificDuration().Show();
            }
        }

        private void ribbonButton80_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesReturnReportsInvoiceByCustomer"] == null)
            {
                new SalesReturnReportsInvoiceByCustomer().Show();
            }
        }

        private void ribbonButton79_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesReturnReportsInvoiceByItems"] == null)
            {
                new SalesReturnReportsInvoiceByItems().Show();
            }
        }

        private void ribbonButton78_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesReturnReportsInvoiceByMajorGroups"] == null)
            {
                new SalesReturnReportsInvoiceByMajorGroups().Show();
            }
        }

        private void ribbonButton77_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesReturnReportsInvoiceByMonetary"] == null)
            {
                new SalesReturnReportsInvoiceByMonetary().Show();
            }
        }

        private void ribbonButton76_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesReturnReportsInvoiceByChecks"] == null)
            {
                new SalesReturnReportsInvoiceByChecks().Show();
            }
        }

        private void ribbonButton75_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesReturnReportsInvoiceByChecksAndMonetary"] == null)
            {
                new SalesReturnReportsInvoiceByChecksAndMonetary().Show();
            }
        }

        private void ribbonButton74_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesReturnReportsInvoiceByFuture"] == null)
            {
                new SalesReturnReportsInvoiceByFuture().Show();
            }
        }

        private void ribbonButton103_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ItemsInfoReport"] == null)
            {
                new ItemsDataReport().Show();
            }
        }

        private void ribbonButton101_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["PricingItemsReport"] == null)
            {
                new PricingItemsReport().Show();
            }
        }

        private void ribbonButton102_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["StoringItemsReport"] == null)
            {
                new StoringItemsReport().Show();
            }
        }

        private void ribbonButton96_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["StoreMovementReport"] == null)
            {
                new StoreMovementReport().Show();
            }
        }

        private void ribbonButton97_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ExchangeOrdersReport"] == null)
            {
                new ExchangeOrdersReport().Show();
            }
        }

        private void ribbonButton98_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["StoreOrdersReport"] == null)
            {
                new StoreOrdersReport().Show();
            }
        }

        private void ribbonButton104_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ShowPriceOfProduct"] == null)
            {
                new ShowPriceOfProduct().Show();
            }
        }
        

        private void ribbonButton95_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NonLeftMonetaryBondsReports"] == null)
            {
                new NonLeftMonetaryBondsReports().Show();
            }
        }

        private void ribbonButton94_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NonLeftDailyRestrictionsReports"] == null)
            {
                new NonLeftDailyRestrictionsReports().Show();
            }
        }

        private void ribbonButton93_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NonLeftBankyBondsReports"] == null)
            {
                new NonLeftBankyBondsReports().Show();
            }
        }

        private void ribbonButton92_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NonLeftSupplyOrdersReports"] == null)
            {
                new NonLeftSupplyOrdersReports().Show();
            }
        }

        private void ribbonButton91_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NonLeftExchangeOrdersReport"] == null)
            {
                new NonLeftExchangeOrdersReport().Show();
            }
        }

        private void ribbonButton90_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NonLeftSalesBillReport"] == null)
            {
                new NonLeftSalesBillReport().Show();
            }
        }

        private void ribbonButton89_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NonLeftSalesReturnReport"] == null)
            {
                new NonLeftSalesReturnReport().Show();
            }
        }

        private void ribbonButton105_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Cashier"] == null)
            {
                new Cashier().Show();
            }
        }

        #region Form Field extra
        int _charIndex = 0;
        string _text = "اهلا بكم فى البرنامج المحاسبى ليمرا ";
        private void TypewriteText()
        {
            while (_charIndex < _text.Length)
            {
                Thread.Sleep(10);
                label1.Invoke(new Action(() =>
                {
                    label1.Text += _text[_charIndex];
                }));
                _charIndex++;
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            _charIndex = 0;
            label1.Text = string.Empty;
            Thread t = new Thread(new ThreadStart(TypewriteText));
            t.Start();

            base.OnHandleCreated(e);
            Bounds = Screen.PrimaryScreen.WorkingArea;

            playSimpleSound();
        }

        private void playSimpleSound()
        {
            SoundPlayer audio = new SoundPlayer(Properties.Resources.audio); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }

        private void MainPage_MinimumSizeChanged(object sender, EventArgs e)
        {
            base.OnHandleCreated(e);
            Bounds = Screen.PrimaryScreen.WorkingArea;
        }
        #endregion

        private void ribbonButtonPurchaseBills_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["PurchaseBills"] == null)
            {
                new PurchaseBills().Show();
            }
        }

        private void ribbonButtonPurchaseReturnBills_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["PurchaseReturnBills"] == null)
            {
                new PurchaseReturnBills().Show();
            }
        }

        private void ribbonButton115_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["MiddleAccount"] == null)
            {
                new MiddleAccount().Show();
            }
        }

        private void button_CalculationGuide_menu_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CalculationsGuide"] == null)
            {
                new CalculationsGuide().Show();
            }
            else
            {
                MessageBox.Show("مفتوحة مسبقاً");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AnalyticalSubaccountReport"] == null)
            {
                new SubAccountReport().Show();
            }
        }

        private void ribbonButton120_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CancelRelayDailyRestrictions"] == null)
            {
                new CancelRelayDailyRestrictions().Show();
            }
        }

        private void ribbonButton119_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CancelRelayCashBonds"] == null)
            {
                new CancelRelayCashBonds().Show();
            }
        }

        private void ribbonButton118_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CancelRelayBankBonds"] == null)
            {
                new CancelRelayBankBonds().Show();
            }
        }

        private void ribbonButton4_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["StoreInfo"] == null)
            {
                new StoreInfo().Show();
            }
        }

        private void ribbonButton3_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["StoringGroup"] == null)
            {
                new StoringGroup().Show();
            }
        }

        private void ribbonButton2_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["StoreSupplyOrders"] == null)
            {
                new StoreSupplyOrders().Show();
            }
        }

        private void ribbonButton1_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["StoreExchangeOrders"] == null)
            {
                new StoreExchangeOrders().Show();
            }
        }

        private void ribbonButton7_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["ItemData"] == null)
            {
                new ItemData().Show();
            }
        }

        private void ribbonButton6_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["StoringItems"] == null)
            {
                new StoringItems().Show();
            }
        }

        private void ribbonButton5_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["ItemsPricing"] == null)
            {
                new ItemsPricing().Show();
            }
        }

        private void ribbonButton20_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AgentsData"] == null)
            {
                new AgentsData().Show();
            }
        }

        private void ribbonButton16_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SuppliersInfo"] == null)
            {
                new SuppliersInfo().Show();
            }
        }
    }//end class
}//end namespace