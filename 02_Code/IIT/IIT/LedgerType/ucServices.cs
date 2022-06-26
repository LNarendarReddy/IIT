using DevExpress.XtraEditors;
using Entity;
using IIT;
using Repository;
using Repository.Utility;
using System;

namespace IIT
{
    public partial class ucServices : ucLedgerTypeBase
    {
        public ucServices() 
        {
            InitializeComponent();
        }
        public ucServices(Ledger _ledger, bool isCallFromAddButton,string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
        }
        private void ucServices_Load(object sender, EventArgs e)
        {


            cmbNameoftheBank.Properties.DataSource = LookUpUtility.GetBanks();
            cmbNameoftheBank.Properties.ValueMember = "ENTITYLOOKUPID";
            cmbNameoftheBank.Properties.DisplayMember = "LOOKUPVALUE";

            cmbNatureofServices.Properties.DataSource = LookUpUtility.GetTDSRates();
            cmbNatureofServices.Properties.ValueMember = "ENTITYLOOKUPID";
            cmbNatureofServices.Properties.DisplayMember = "LOOKUPVALUE";

            cmbTDSRates.Properties.DataSource = LookUpUtility.GetTDSRates();
            cmbTDSRates.Properties.ValueMember = "ENTITYLOOKUPID";
            cmbTDSRates.Properties.DisplayMember = "LOOKUPVALUE";

            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;

            txtLedgerName.EditValue = ledger.Name;
            cmbNatureofServices.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.NatureOftheServices;
            rgRegistrationStatus.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.GSTRegistrationStatus;
            txtGSTNumber.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.GSTRegistrationNumber;
            txtPANNumber.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.PANNumber;
            rgReverseCharge.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.IsReverseChargeApplicable;
            rgTDSApplicable.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.IsTDSApplicable;
            cmbTDSRates.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.TDSRate;
            txtCreditPeriod.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.CreditPeriod;
            txtInterestClause.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.InterestClause;
            txtOpeningBalance.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.OpeningBalance;
            txtDoorNumber.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.DoorNumber;
            txtArea.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.Area;
            txtCity.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.City;
            txtPinCode.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.PinCode;
            cmbNameoftheBank.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.BankID;
            txtAccountNumber.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.AccountNumber;
            txtAccountHolderName.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.AccountHolderName;
            txtIFSCCode.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.IFSCCode;
            txtBranch.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.BranchName;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!rgRegistrationStatus.EditValue.Equals("Registered"))
                dxValidationProvider1.SetValidationRule(txtGSTNumber, null);
            if (!dxValidationProvider1.Validate())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.NatureOftheServices = cmbNatureofServices.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.GSTRegistrationStatus = rgRegistrationStatus.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.GSTRegistrationNumber = txtGSTNumber.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.PANNumber = txtPANNumber.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.IsReverseChargeApplicable = rgReverseCharge.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.IsTDSApplicable = rgTDSApplicable.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.TDSRate = cmbTDSRates.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.CreditPeriod = txtCreditPeriod.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.InterestClause = txtInterestClause.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.DoorNumber =  txtDoorNumber.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.Area = txtArea.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.City = txtCity.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.PinCode = txtPinCode.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.BankID = cmbNameoftheBank.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.AccountNumber = txtAccountNumber.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.AccountHolderName = txtAccountHolderName.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.IFSCCode = txtIFSCCode.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.BranchName = txtBranch.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_ServiceOrDuesToSubContractors;
            Save();
        }
        private void rgRegistrationStatus_EditValueChanged(object sender, EventArgs e)
        {
            txtGSTNumber.EditValue = null;
            txtGSTNumber.Enabled = rgRegistrationStatus.EditValue.Equals("Registered");
        }
        private void txtGSTNumber_Leave(object sender, EventArgs e)
        {
            if (txtGSTNumber.Text.Length < 12)
                return;
            txtPANNumber.EditValue = txtGSTNumber.Text.Substring(2, 10);
        }
        private void txtOpeningBalance_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }
        private void rgTypeofLoan_Enter(object sender, EventArgs e)
        {
            RadioGroup rg = sender as RadioGroup;
            rg.SelectedIndex = rg.EditValue == null ? 0 : rg.SelectedIndex;
        }
    }
}
