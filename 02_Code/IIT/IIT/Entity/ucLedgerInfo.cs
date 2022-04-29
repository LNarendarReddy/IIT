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
        public ucLedgerInfo()
        {
            InitializeComponent();
        }

        private void btnLiabilities_Click(object sender, EventArgs e)
        {
            Utility.ShowDialog(new frmLedgerList(Utility.LiabilitiesHeadID, "Liabilities"));
        }

        private void btnAssets_Click(object sender, EventArgs e)
        {
            Utility.ShowDialog(new frmLedgerList(Utility.AssetsHeadID, "Assets"));
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            Utility.ShowDialog(new frmLedgerList(Utility.IncomeHeadID, "Income"));
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            Utility.ShowDialog(new frmLedgerList(Utility.ExpensesHeadID, "Expenses"));
        }
    }
}
