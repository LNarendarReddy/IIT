using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using Entity;
using IIT;
using System;

namespace IIT
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private static frmMain _instance = null;

        public static frmMain Instance { get { return _instance ?? (_instance = new frmMain()); } }

        private frmMain()
        {
            InitializeComponent();
        }

        private void btnEntity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEntityList obj = new frmEntityList();
            //Utility.ShowDialog(obj);
            if (obj.IsEntitySelected && Utility.CurrentEntity?.ID != null)
            {
                this.Text = Utility.CurrentEntity?.EntityName == null ? "IIT" : Convert.ToString(Utility.CurrentEntity.EntityName);
                rpAccounts.Visible = true;
                rpIIT.Visible = false;
                ribbonControl1.SelectedPage = rpAccounts;
            }
        }

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            lblDateTime.Caption = DateTime.Now.ToString();
            lblVersion.Caption = "1.1.1 (06-04-2022)";
            btnEntity_ItemClick(null, null);
        }

        public void UpdateStatusBar(string message)
        {
            lblStatus.Caption = message;
        }

        private void bbiNOB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utility.ShowDialog(new frmSectorList());
        }

        private void bbiGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utility.ShowDialog(new frmGroupList());
        }

        private void bbiSubGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utility.ShowDialog(new frmSubGroupList());
        }

        private void bbiVoucher_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utility.ShowDialog(new frmVoucherList());
        }

        private void btnAssets_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utility.ShowDialog(new frmLedgerList(Utility.AssetsHeadID) { Text = "Assets Group"});
        }

        private void btnLiabilities_ItemClick(object sender, ItemClickEventArgs e)
        {
            Utility.ShowDialog(new frmLedgerList(Utility.LiabilitiesHeadID) { Text = "Liabilities Group" });
        }

        private void btnIncome_ItemClick(object sender, ItemClickEventArgs e)
        {
            Utility.ShowDialog(new frmLedgerList(Utility.IncomeHeadID) { Text = "Income Group" });
        }

        private void btnExpenses_ItemClick(object sender, ItemClickEventArgs e)
        {
            Utility.ShowDialog(new frmLedgerList(Utility.ExpensesHeadID) { Text = "Expenses Group" });
        }

        private void btnCashPaymentVoucher_ItemClick(object sender, ItemClickEventArgs e)
        {
            Utility.ShowDialog(new frmVoucher(new Voucher() { VoucherTypeID = 55 }));
        }

        private void btnBankPaymentVoucher_ItemClick(object sender, ItemClickEventArgs e)
        {
            Utility.ShowDialog(new frmVoucher(new Voucher() { VoucherTypeID = 56 }));
        }

        private void btnCashRecieptVoucher_ItemClick(object sender, ItemClickEventArgs e)
        {
            Utility.ShowDialog(new frmVoucher(new Voucher() { VoucherTypeID = 57 }));
        }

        private void btnBankRecieptVoucher_ItemClick(object sender, ItemClickEventArgs e)
        {
            Utility.ShowDialog(new frmVoucher(new Voucher() { VoucherTypeID = 58 }));
        }

        private void btnVoucherList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Utility.ShowDialog(new frmVoucherList());
        }

        private void btnExitCompany_ItemClick(object sender, ItemClickEventArgs e)
        {
            rpIIT.Visible = true;
            rpAccounts.Visible = false;
            Utility.CurrentEntity = null;
            this.Text = "IIT";
            btnEntity_ItemClick(null, null);
        }

        private void btnCashPaymentLedger_ItemClick(object sender, ItemClickEventArgs e)
        {
            ViewLedger(55);
        }

        private void btnCashRecieptLedger_ItemClick(object sender, ItemClickEventArgs e)
        {
            ViewLedger(57);
        }

        private void ViewLedger(object VoucherTypeID)
        {
            rptLedgerPrinting rpt = new rptLedgerPrinting();
            rpt.Parameters["EntityID"].Value = Utility.CurrentEntity.ID;
            rpt.Parameters["OrgName"].Value = Utility.CurrentEntity.EntityName;
            rpt.Parameters["VoucherTypeID"].Value = VoucherTypeID;
            rpt.Parameters["FromDate"].Value = DateTime.Now.AddDays(-30);
            rpt.Parameters["ToDate"].Value = DateTime.Now;
            rpt.ShowRibbonPreview();
        }
    }
}
