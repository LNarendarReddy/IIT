using Entity;
using IIT;
using Repository.Utility;
using System;

namespace IIT
{
    public partial class ucCreditors : ucLedgerTypeBase
    {
        public override string Caption => "Creditors or Raw Materials Suupliers ledgers Creation";
        public ucCreditors(Ledger _ledger, bool isCallFromAddButton) : base(_ledger, isCallFromAddButton)
        {
            InitializeComponent();
        }
        private void ucCreditors_Load(object sender, EventArgs e)
        {
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            cmbRegistrationStatus.EditValue = ledger.CreditorsInfo.GSTRegistrationStatus;
            txtGSTNumber.EditValue = ledger.CreditorsInfo.GSTRegistrationNumber;
            txtPANNumber.EditValue = ledger.CreditorsInfo.PANNumber;
            txtAddressOftheSupplier.EditValue = ledger.CreditorsInfo.SupplierAddress;
            txtBankAccountDetails.EditValue = ledger.CreditorsInfo.BankAccountDetails;
            txtCreditPeriodAllowed.EditValue = ledger.CreditorsInfo.CreditPeriod;
            txtInterest.EditValue = ledger.CreditorsInfo.InterestClause;
            txtOpeningBalance.EditValue = ledger.CreditorsInfo.OpeningBalance;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!cmbRegistrationStatus.EditValue.Equals("Registered"))
                dxValidationProvider1.SetValidationRule(txtGSTNumber,null);
                if (!dxValidationProvider1.Validate())
                return;
            ledger.CreditorsInfo.NameOfSundryCreditors = ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.CreditorsInfo.GSTRegistrationStatus = cmbRegistrationStatus.EditValue;
            ledger.CreditorsInfo.GSTRegistrationNumber = txtGSTNumber.EditValue;
            ledger.CreditorsInfo.PANNumber = txtPANNumber.EditValue;
            ledger.CreditorsInfo.SupplierAddress = txtAddressOftheSupplier.EditValue;
            ledger.CreditorsInfo.BankAccountDetails = txtBankAccountDetails.EditValue;
            ledger.CreditorsInfo.CreditPeriod = txtCreditPeriodAllowed.EditValue;
            ledger.CreditorsInfo.InterestClause = txtInterest.EditValue;
            ledger.CreditorsInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_Creditors;
            Save();
        }
        private void cmbRegistrationStatus_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbRegistrationStatus.EditValue.Equals("Registered"))
            { 
                txtGSTNumber.Enabled = true;
            }
            else
            {
                txtGSTNumber.EditValue = null;
                txtGSTNumber.Enabled = false;
            }
        }
        private void txtGSTNumber_Leave(object sender, EventArgs e)
        {
            if (txtGSTNumber.Text.Length < 12)
                return;
            txtPANNumber.EditValue = txtGSTNumber.Text.Substring(2, 10);
        }

        private void txtInterest_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }
    }
}
