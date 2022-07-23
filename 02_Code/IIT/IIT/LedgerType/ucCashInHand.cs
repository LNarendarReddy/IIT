using DevExpress.XtraEditors;
using Entity;
using Repository;
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
            this.txtOpeningBalance.Spin += base.textedit_Spin;
        }
        private void ucCashInHand_Load(object sender, EventArgs e)
        {
            cmbHavingPrettyCashAccount.Properties.DataSource = LookUpUtility.GetBoolType();
            base.AddControls(layoutControl1);
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            cmbHavingPrettyCashAccount.EditValue = ledger.CashinHandInfo.HavingPrettyCashAccount;
            txtDetails.EditValue = ledger.CashinHandInfo.Details;
            txtOpeningBalance.EditValue = ledger.CashinHandInfo.OpeningBalance;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.CashinHandInfo.HavingPrettyCashAccount = cmbHavingPrettyCashAccount.EditValue;
            ledger.CashinHandInfo.Details = txtDetails.EditValue;
            decimal PettyCash = 0;
            decimal OpeningBalance = 0;
            decimal.TryParse(txtDetails.Text, out PettyCash);
            decimal.TryParse(txtOpeningBalance.Text, out OpeningBalance);
            ledger.CashinHandInfo.OpeningBalance = PettyCash + OpeningBalance;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_CashInHand;
            Save();
        }
        private void cmbHavingPrettyCashAccount_EditValueChanged(object sender, EventArgs e)
        {
            txtDetails.EditValue = null;
            txtDetails.Enabled = cmbHavingPrettyCashAccount.Text.Equals("Yes");
        }
    }
}
