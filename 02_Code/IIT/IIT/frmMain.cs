﻿using DevExpress.XtraBars;
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
            Utility.ShowDialog(obj);
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
    }
}
