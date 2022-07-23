using DevExpress.XtraEditors;
using Entity;
using IIT;
using Repository;
using Repository.Utility;
using System;

namespace IIT
{
    public partial class ucCreditors : ucLedgerTypeBase
    {
        public ucCreditors(Ledger _ledger, bool isCallFromAddButton,string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
            this.txtOpeningBalance.Spin += base.textedit_Spin;
            this.txtInterest.Spin += base.textedit_Spin;
        }
        private void ucCreditors_Load(object sender, EventArgs e)
        {
            base.AddControls(layoutControl1);
            cmbNatureOfSupplier.Properties.DataSource = LookUpUtility.GetNatureOfSupplier();
            cmbNameoftheBank.Properties.DataSource = LookUpUtility.GetBanks();
            cmbTDSRates.Properties.DataSource = LookUpUtility.GetTDSRates();
            cmbTDSApplicable.Properties.DataSource = LookUpUtility.GetBoolType();
            cmbRegistrationStatus.Properties.DataSource = LookUpUtility.GetRegType();

            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            cmbNatureOfSupplier.EditValue = ledger.CreditorsInfo.NatureOfSupplier;
            cmbRegistrationStatus.EditValue = ledger.CreditorsInfo.GSTRegistrationStatus;
            txtGSTNumber.EditValue = ledger.CreditorsInfo.GSTRegistrationNumber;
            txtPANNumber.EditValue = ledger.CreditorsInfo.PANNumber;
            txtCreditPeriodAllowed.EditValue = ledger.CreditorsInfo.CreditPeriod;
            txtInterest.EditValue = ledger.CreditorsInfo.InterestClause;
            cmbTDSApplicable.EditValue = ledger.CreditorsInfo.IsTDSApplicable;
            cmbTDSRates.EditValue = ledger.CreditorsInfo.TDSRate;
            txtOpeningBalance.EditValue = ledger.CreditorsInfo.OpeningBalance;
            txtDoorNumber.EditValue = ledger.CreditorsInfo.DoorNumber;
            txtArea.EditValue = ledger.CreditorsInfo.Area;
            txtCity.EditValue = ledger.CreditorsInfo.City;
            txtPinCode.EditValue = ledger.CreditorsInfo.PinCode;
            cmbNameoftheBank.EditValue = ledger.CreditorsInfo.BankID;
            txtAccountNumber.EditValue = ledger.CreditorsInfo.AccountNumber;
            txtAccountHolderName.EditValue = ledger.CreditorsInfo.AccountHolderName;
            txtIFSCCode.EditValue = ledger.CreditorsInfo.IFSCCode;
            txtBranch.EditValue = ledger.CreditorsInfo.BranchName;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
                if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.CreditorsInfo.NatureOfSupplier = cmbNatureOfSupplier.EditValue;
            ledger.CreditorsInfo.GSTRegistrationStatus = cmbRegistrationStatus.EditValue;
            ledger.CreditorsInfo.GSTRegistrationNumber = txtGSTNumber.EditValue;
            ledger.CreditorsInfo.PANNumber = txtPANNumber.EditValue;
            ledger.CreditorsInfo.CreditPeriod = txtCreditPeriodAllowed.EditValue;
            ledger.CreditorsInfo.InterestClause = txtInterest.EditValue;
            ledger.CreditorsInfo.IsTDSApplicable = cmbTDSApplicable.EditValue;
            ledger.CreditorsInfo.TDSRate = cmbTDSRates.EditValue;
            ledger.CreditorsInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.CreditorsInfo.DoorNumber = txtDoorNumber.EditValue;
            ledger.CreditorsInfo.Area = txtArea.EditValue;
            ledger.CreditorsInfo.City = txtCity.EditValue;
            ledger.CreditorsInfo.PinCode = txtPinCode.EditValue;
            ledger.CreditorsInfo.BankID = cmbNameoftheBank.EditValue;
            ledger.CreditorsInfo.AccountNumber = txtAccountNumber.EditValue;
            ledger.CreditorsInfo.AccountHolderName = txtAccountHolderName.EditValue;
            ledger.CreditorsInfo.IFSCCode = txtIFSCCode.EditValue;
            ledger.CreditorsInfo.BranchName = txtBranch.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_Creditors;
            Save();
        }
        private void txtGSTNumber_Leave(object sender, EventArgs e)
        {
            if (txtGSTNumber.Text.Length < 12)
                return;
            txtPANNumber.EditValue = txtGSTNumber.Text.Substring(2, 10);
        }
        private void cmbRegistrationStatus_EditValueChanged(object sender, EventArgs e)
        {
            txtGSTNumber.EditValue = null;
            txtGSTNumber.Enabled = cmbRegistrationStatus.Text.Equals("Registered");
        }
        private void cmbTDSApplicable_EditValueChanged(object sender, EventArgs e)
        {
            cmbTDSRates.EditValue = null;
            cmbTDSRates.Enabled = cmbTDSApplicable.Text.Equals("Yes");
        }
    }
}
