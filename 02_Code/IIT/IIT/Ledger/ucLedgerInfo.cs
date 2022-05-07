using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IIT
{
    public partial class ucLedgerInfo : NavigationBase
    {
        private List<string> helpText = new List<string>() { "(Alt + L) ==> Liabilities", "(Alt + A) ==> Assets",
        "(Alt + I) ==> Income","(Alt + E) ==> Expenses"};
        public override List<string> HelpText => helpText;
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
