using DevExpress.XtraEditors;
using Entity;
using Repository.Utility;
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
    public partial class ucCashInHand : ucLedgerTypeBase
    {
        public ucCashInHand(Ledger _ledger, bool isCallFromAddButton,string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
        }
        private void ucCashInHand_Load(object sender, EventArgs e)
        {
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            rgHavingPrettyCashAccount.EditValue = ledger.CashinHandInfo.HavingPrettyCashAccount;
            txtDetails.EditValue = ledger.CashinHandInfo.Details;
            txtOpeningBalance.EditValue = ledger.CashinHandInfo.OpeningBalance;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.CashinHandInfo.HavingPrettyCashAccount = rgHavingPrettyCashAccount.EditValue;
            ledger.CashinHandInfo.Details = txtDetails.EditValue;
            decimal PettyCash = 0;
            decimal OpeningBalance = 0;
            decimal.TryParse(txtDetails.Text, out PettyCash);
            decimal.TryParse(txtOpeningBalance.Text, out OpeningBalance);
            ledger.CashinHandInfo.OpeningBalance = PettyCash + OpeningBalance;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_CashInHand;
            Save();
        }
        private void radioGroup_Enter(object sender, EventArgs e)
        {
            RadioGroup rg = sender as RadioGroup;
            rg.SelectedIndex = rg.EditValue == null ? 0 : rg.SelectedIndex;
        }
        private void textEdit_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }
    }
}
