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
    public partial class ucDebitors : NavigationBase
    {
        public override string Caption => "Debtors ledgers Creation";
        Ledger ledger = null;
        public ucDebitors(Ledger _ledger)
        {
            InitializeComponent();
            ledger = _ledger;   
        }
        private void ucDebitors_Load(object sender, EventArgs e)
        {
            lblHeader.Text = Caption;
            if (ledger.ID != null)
            {
                txtLedgerName.EditValue = ledger.Name;
                cmbRegistrationStatus.EditValue = ledger.DebitorsInfo.GSTRegistrationStatus;
                txtGSTNumber.EditValue = ledger.DebitorsInfo.GSTRegistrationNumber;
                txtPANNumber.EditValue = ledger.DebitorsInfo.PANNumber;
                txtAddress.EditValue = ledger.DebitorsInfo.DebitorAddress;
                txtCreditPeriod.EditValue = ledger.DebitorsInfo.CreditPeriod;
                txtInterestCluase.EditValue = ledger.DebitorsInfo.InterestClause;
                txtOpeningBalance.EditValue = ledger.DebitorsInfo.OpeningBalance;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!cmbRegistrationStatus.EditValue.Equals("Registered"))
                dxValidationProvider1.SetValidationRule(txtGSTNumber, null);
            if (!dxValidationProvider1.Validate())
                return;
            ledger.DebitorsInfo.NameOfSundryDebitors = ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.DebitorsInfo.GSTRegistrationStatus = cmbRegistrationStatus.EditValue;
            ledger.DebitorsInfo.GSTRegistrationNumber = txtGSTNumber.EditValue;
            ledger.DebitorsInfo.PANNumber = txtPANNumber.EditValue;
            ledger.DebitorsInfo.DebitorAddress = txtAddress.EditValue;
            ledger.DebitorsInfo.CreditPeriod = txtCreditPeriod.EditValue;
            ledger.DebitorsInfo.InterestClause = txtInterestCluase.EditValue;
            ledger.DebitorsInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_Debitors;
            ledger.UserName = Utility.UserName;
            new LedgerRepository().Save(ledger);
            frmSingularMain.Instance.RollbackControl();
        }
        private void cmbRegistrationStatus_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbRegistrationStatus.EditValue.Equals("Registered"))
            {
                txtGSTNumber.EditValue = null;
                txtGSTNumber.Enabled = true;
            }
            else
                txtGSTNumber.Enabled = false;
        }
        private void txtGSTNumber_Leave(object sender, EventArgs e)
        {
            if (txtGSTNumber.Text.Length < 12)
                return;
            txtPANNumber.EditValue = txtGSTNumber.Text.Substring(2, 10);
        }
    }
}
