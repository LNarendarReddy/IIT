using Entity;
using IIT;
using Repository;
using Repository.Utility;
using System;

namespace IIT
{
    public partial class ucBankAccount : ucLedgerTypeBase
    {
        public override string Caption => "Bank Account ledgers Creation";

        public ucBankAccount(Ledger _ledger, bool isCallFromAddButton) : base(_ledger, isCallFromAddButton)
        {
            InitializeComponent();
        }

        private void ucBankAccount_Load(object sender, EventArgs e)
        {
            lblHeader.Name = Caption;
            cmbNameOftheBank.Properties.DataSource = LookUpUtility.GetBanks();
            cmbNameOftheBank.Properties.ValueMember = "ENTITYLOOKUPID";
            cmbNameOftheBank.Properties.DisplayMember = "LOOKUPVALUE";

            cmbNatureoftheBankAccount.Properties.DataSource = LookUpUtility.GetNatureOfBanks();
            cmbNatureoftheBankAccount.Properties.ValueMember = "ENTITYLOOKUPID";
            cmbNatureoftheBankAccount.Properties.DisplayMember = "LOOKUPVALUE";

            if (ledger?.ID == null) return;

            cmbNameOftheBank.EditValue = ledger.BankAccountInfo.BankID;
            txtBankAccountNumber.EditValue = ledger.BankAccountInfo.AccountNumber;
            txtBranchAddress.EditValue = ledger.BankAccountInfo.BranchAddress;
            txtIFSCCode.EditValue = ledger.BankAccountInfo.IFSCCode;
            txtMICRCode.EditValue = ledger.BankAccountInfo.MICRCode;
            cmbNatureoftheBankAccount.EditValue = ledger.BankAccountInfo.NatureOfBankAccountID;
            txtInterestRate.EditValue = ledger.BankAccountInfo.InterestRate;
            txtOpeningBalance.EditValue = ledger.BankAccountInfo.OpeningBalance;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!dxValidationProvider1.Validate())
                return;
            ledger.Name = ledger.Description = cmbNameOftheBank.Text + " " + txtBankAccountNumber.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_BankAccount;
            ledger.BankAccountInfo.BankID = cmbNameOftheBank.EditValue;
            ledger.BankAccountInfo.AccountNumber = txtBankAccountNumber.EditValue;
            ledger.BankAccountInfo.BranchAddress = txtBranchAddress.EditValue;
            ledger.BankAccountInfo.IFSCCode =  txtIFSCCode.EditValue;
            ledger.BankAccountInfo.MICRCode = txtMICRCode.EditValue;
            ledger.BankAccountInfo.NatureOfBankAccountID = cmbNatureoftheBankAccount.EditValue;
            ledger.BankAccountInfo.InterestRate = txtInterestRate.EditValue;
            ledger.BankAccountInfo.OpeningBalance = txtOpeningBalance.EditValue;
            Save();
        }

        private void txtInterestRate_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }
    }
}
    