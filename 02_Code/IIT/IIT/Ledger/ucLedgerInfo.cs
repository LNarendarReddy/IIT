using System;
using System.Collections.Generic;

namespace IIT
{
    public partial class ucLedgerInfo : NavigationBase
    {
        private List<string> helpText = new List<string>() { "(Alt + L) ==> Liabilities", "(Alt + A) ==> Assets",
        "(Alt + I) ==> Income","(Alt + E) ==> Expenses"};
        public override List<string> HelpText => helpText;

        public override string Caption => "Ledger Selection";

        public ucLedgerInfo()
        {
            InitializeComponent();
        }

        private void btnLiabilities_Click(object sender, EventArgs e)
        {
            Utility.ShowDialog(new frmLedgerCreation(Utility.LiabilitiesHeadID, "Liabilities"));
        }

        private void btnAssets_Click(object sender, EventArgs e)
        {
            Utility.ShowDialog(new frmLedgerCreation(Utility.AssetsHeadID, "Assets"));
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            Utility.ShowDialog(new frmLedgerCreation(Utility.IncomeHeadID, "Income"));
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            Utility.ShowDialog(new frmLedgerCreation(Utility.ExpensesHeadID, "Expenses"));
        }
    }
}
