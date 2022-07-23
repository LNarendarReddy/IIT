using DevExpress.XtraEditors;
using Entity;
using IIT;
using Repository;
using Repository.Utility;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IIT
{
    public partial class ucBankAccount : ucLedgerTypeBase
    {
        public ucBankAccount()
        { 

        }
        public ucBankAccount(Ledger _ledger, bool isCallFromAddButton,string caption) : 
            base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
            this.txtOpeningBalance.Spin += base.textedit_Spin;
            this.txtInterestRate.Spin += base.textedit_Spin;
        }
        private void ucBankAccount_Load(object sender, EventArgs e)
        {
            cmbNameOftheBank.Properties.DataSource = LookUpUtility.GetBanks();
            cmbNatureoftheBankAccount.Properties.DataSource = LookUpUtility.GetNatureOfBanks();
            base.AddControls(layoutControl1);
            lblHeader.Name = Caption;
            if (ledger?.ID == null) return;
            cmbNameOftheBank.EditValue = ledger.BankAccountInfo.BankID;
            txtBankAccountNumber.EditValue = ledger.BankAccountInfo.AccountNumber;
            txtBranchAddress.EditValue = ledger.BankAccountInfo.BranchAddress;
            txtLocation.EditValue = ledger.BankAccountInfo.Location;
            txtPinCode.EditValue = ledger.BankAccountInfo.PinCode;
            txtContactNo.EditValue = ledger.BankAccountInfo.ContactNumber;
            txtIFSCCode.EditValue = ledger.BankAccountInfo.IFSCCode;
            txtMICRCode.EditValue = ledger.BankAccountInfo.MICRCode;
            cmbNatureoftheBankAccount.EditValue = ledger.BankAccountInfo.NatureOfBankAccountID;
            txtInterestRate.EditValue = ledger.BankAccountInfo.InterestRate;
            txtOpeningBalance.EditValue = ledger.BankAccountInfo.OpeningBalance;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = cmbNameOftheBank.Text + " " + txtBankAccountNumber.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_BankAccount;
            ledger.BankAccountInfo.BankID = cmbNameOftheBank.EditValue;
            ledger.BankAccountInfo.AccountNumber = txtBankAccountNumber.EditValue;
            ledger.BankAccountInfo.BranchAddress = txtBranchAddress.EditValue;
            ledger.BankAccountInfo.Location = txtLocation.EditValue;
            ledger.BankAccountInfo.PinCode = txtPinCode.EditValue;
            ledger.BankAccountInfo.ContactNumber = txtContactNo.EditValue;
            ledger.BankAccountInfo.IFSCCode =  txtIFSCCode.EditValue;
            ledger.BankAccountInfo.MICRCode = txtMICRCode.EditValue;
            ledger.BankAccountInfo.NatureOfBankAccountID = cmbNatureoftheBankAccount.EditValue;
            ledger.BankAccountInfo.InterestRate = txtInterestRate.EditValue;
            ledger.BankAccountInfo.OpeningBalance = txtOpeningBalance.EditValue;
            Save();
        }


    }
}
    