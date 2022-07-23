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
        public ucServices(Ledger _ledger, bool isCallFromAddButton,string caption) 
            : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
            this.txtInterestClause.Spin += base.textedit_Spin;
            this.txtOpeningBalance.Spin += base.textedit_Spin;
        }
        private void ucServices_Load(object sender, EventArgs e)
        {
            base.AddControls(layoutControl1);

            cmbNameoftheBank.Properties.DataSource = LookUpUtility.GetBanks();
            cmbNatureofServices.Properties.DataSource = LookUpUtility.GetTDSRates();
            cmbTDSRates.Properties.DataSource = LookUpUtility.GetTDSRates();
            cmbRegistrationStatus.Properties.DataSource = LookUpUtility.GetRegType();
            cmbReverseCharge.Properties.DataSource = cmbTDSApplicable .Properties.DataSource = LookUpUtility.GetBoolType();

            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;

            txtLedgerName.EditValue = ledger.Name;
            cmbNatureofServices.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.NatureOftheServices;
            cmbRegistrationStatus.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.GSTRegistrationStatus;
            txtGSTNumber.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.GSTRegistrationNumber;
            txtPANNumber.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.PANNumber;
            cmbReverseCharge.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.IsReverseChargeApplicable;
            cmbTDSApplicable.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.IsTDSApplicable;
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
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.NatureOftheServices = cmbNatureofServices.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.GSTRegistrationStatus = cmbRegistrationStatus.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.GSTRegistrationNumber = txtGSTNumber.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.PANNumber = txtPANNumber.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.IsReverseChargeApplicable = cmbReverseCharge .EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.IsTDSApplicable = cmbTDSApplicable.EditValue;
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
            txtGSTNumber.Enabled = cmbRegistrationStatus.Text.Equals("Registered");
        }
        private void txtGSTNumber_Leave(object sender, EventArgs e)
        {
            if (txtGSTNumber.Text.Length < 12)
                return;
            txtPANNumber.EditValue = txtGSTNumber.Text.Substring(2, 10);
        }
    }
}
