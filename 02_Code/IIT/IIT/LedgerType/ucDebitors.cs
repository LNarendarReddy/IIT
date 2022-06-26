using Entity;
using IIT;
using Repository;
using Repository.Utility;
using System;

namespace IIT
{
    public partial class ucDebitors : ucLedgerTypeBase
    {

        public ucDebitors(Ledger _ledger, bool isCallFromAddButton,string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
        }
        private void ucDebitors_Load(object sender, EventArgs e)
        {
            cmbNatureOfCustomer.Properties.DataSource = LookUpUtility.GetNatureOfCustomer();
            cmbNatureOfCustomer.Properties.ValueMember = "ENTITYLOOKUPID";
            cmbNatureOfCustomer.Properties.DisplayMember = "LOOKUPVALUE";

            cmbNameoftheBank.Properties.DataSource = LookUpUtility.GetBanks();
            cmbNameoftheBank.Properties.ValueMember = "ENTITYLOOKUPID";
            cmbNameoftheBank.Properties.DisplayMember = "LOOKUPVALUE";

            cmbTDSRates.Properties.DataSource = LookUpUtility.GetTDSRates();
            cmbTDSRates.Properties.ValueMember = "ENTITYLOOKUPID";
            cmbTDSRates.Properties.DisplayMember = "LOOKUPVALUE";

            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            cmbNatureOfCustomer.EditValue = ledger.DebitorsInfo.NatureoftheCustomer;
            cmbRegistrationStatus.EditValue = ledger.DebitorsInfo.GSTRegistrationStatus;
            txtGSTNumber.EditValue = ledger.DebitorsInfo.GSTRegistrationNumber;
            txtPANNumber.EditValue = ledger.DebitorsInfo.PANNumber;
            txtCreditPeriod.EditValue = ledger.DebitorsInfo.CreditPeriod;
            txtInterestCluase.EditValue = ledger.DebitorsInfo.InterestClause;
            rgTDSApplicable.EditValue = ledger.DebitorsInfo.IsTDSApplicable;
            cmbTDSRates.EditValue = ledger.DebitorsInfo.TDSRate;
            txtOpeningBalance.EditValue = ledger.DebitorsInfo.OpeningBalance;
            txtDoorNumber.EditValue = ledger.DebitorsInfo.DoorNumber;
            txtArea.EditValue = ledger.DebitorsInfo.Area;
            txtCity.EditValue = ledger.DebitorsInfo.City;
            txtPinCode.EditValue = ledger.DebitorsInfo.PinCode;
            cmbNameoftheBank.EditValue = ledger.DebitorsInfo.BankID;
            txtAccountNumber.EditValue = ledger.DebitorsInfo.AccountNumber;
            txtAccountHolderName.EditValue = ledger.DebitorsInfo.AccountHolderName;
            txtIFSCCode.EditValue = ledger.DebitorsInfo.IFSCCode;
            txtBranch.EditValue = ledger.DebitorsInfo.BranchName;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!cmbRegistrationStatus.EditValue.Equals("Registered"))
                dxValidationProvider1.SetValidationRule(txtGSTNumber, null);
            if (!dxValidationProvider1.Validate())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.DebitorsInfo.NatureoftheCustomer = cmbNatureOfCustomer.EditValue;
            ledger.DebitorsInfo.GSTRegistrationStatus = cmbRegistrationStatus.EditValue;
            ledger.DebitorsInfo.GSTRegistrationNumber = txtGSTNumber.EditValue;
            ledger.DebitorsInfo.PANNumber = txtPANNumber.EditValue;
            ledger.DebitorsInfo.CreditPeriod = txtCreditPeriod.EditValue;
            ledger.DebitorsInfo.InterestClause = txtInterestCluase.EditValue;
            ledger.DebitorsInfo.IsTDSApplicable = rgTDSApplicable.EditValue;
            ledger.DebitorsInfo.TDSRate = cmbTDSRates.EditValue;
            ledger.DebitorsInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.DebitorsInfo.DoorNumber = txtDoorNumber.EditValue;
            ledger.DebitorsInfo.Area = txtArea.EditValue;
            ledger.DebitorsInfo.City = txtCity.EditValue;
            ledger.DebitorsInfo.PinCode = txtPinCode.EditValue;
            ledger.DebitorsInfo.BankID = cmbNameoftheBank.EditValue;
            ledger.DebitorsInfo.AccountNumber = txtAccountNumber.EditValue;
            ledger.DebitorsInfo.AccountHolderName = txtAccountHolderName.EditValue;
            ledger.DebitorsInfo.IFSCCode = txtIFSCCode.EditValue;
            ledger.DebitorsInfo.BranchName = txtBranch.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_Debitors;
            Save();
        }
        private void cmbRegistrationStatus_EditValueChanged(object sender, EventArgs e)
        {
            txtGSTNumber.EditValue = null;
            txtGSTNumber.Enabled = cmbRegistrationStatus.EditValue.Equals("Registered");
        } 
        private void txtGSTNumber_Leave(object sender, EventArgs e)
        {
            if (txtGSTNumber.Text.Length < 12)
                return;
            txtPANNumber.EditValue = txtGSTNumber.Text.Substring(2, 10);
        }
        private void txtInterestCluase_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }
    }
}
