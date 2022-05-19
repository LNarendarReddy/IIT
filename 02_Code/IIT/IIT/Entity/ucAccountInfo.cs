using System;
using System.Collections.Generic;

namespace IIT
{
    public partial class ucAccountInfo : NavigationBase
    {
        //private List<string> helpText = new List<string>() { "(Alt + C) ==> Ledger Creation ", "(Alt + V) ==> Voucher Entry",
        //"(Alt + I) ==> Inventory Entry","(Alt + M) ==> MIS Forms" , "(Alt + D) ==> Day Book ","(Alt + P) ==> Ledger Printing "};
        //public override List<string> HelpText => helpText;

        public override string Caption => "Accounts";

        public ucAccountInfo()
        {
            InitializeComponent();
        }

        private void btnVoucherEntry_Click(object sender, EventArgs e)
        {

        }

        private void btnInventoryEntry_Click(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnLeadgerCreation_Click(object sender, EventArgs e)
        {
            Utility.ShowDialog(new ucLedgerInfo());
        }

        private void btnDayBook_Click(object sender, EventArgs e)
        {
            Utility.ShowDialog(new frmVoucherList());
        }

        private void btnLedgerPrinting_Click(object sender, EventArgs e)
        {
            Utility.ShowDialog(new ucLedgerList());
        }

        private void btnvoucherEntry_Click_1(object sender, EventArgs e)
        {
            Utility.ShowDialog(new ucVoucherType());
        }
    }
}
