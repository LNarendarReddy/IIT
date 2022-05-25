using DevExpress.XtraEditors;
using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IIT.LedgerType
{
    public partial class ucBankAccount : NavigationBase
    {
        public override string Caption => "Bank Account ledgers Creation";
        Ledger  ledger = null;  
        public ucBankAccount(Ledger _ledger)
        {
            InitializeComponent();
            ledger = _ledger;
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

            if(ledger.ID != null)
            {
                cmbNameOftheBank.EditValue = ledger.BankAccountInfo.BankID;
                txtBankAccountNumber.EditValue = ledger.BankAccountInfo.AccountNumber;
                txtBranchAddress.EditValue = ledger.BankAccountInfo.BranchAddress;
                txtIFSCCode.EditValue = ledger.BankAccountInfo.IFSCCode;
                txtMICRCode.EditValue = ledger.BankAccountInfo.MICRCode;
                cmbNatureoftheBankAccount.EditValue = ledger.BankAccountInfo.NatureOfBankAccountID;
                txtInterestRate.EditValue = ledger.BankAccountInfo.InterestRate;
                txtOpeningBalance.EditValue = ledger.BankAccountInfo.OpeningBalance;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!dxValidationProvider1.Validate())
                return;

            ledger.Name = cmbNameOftheBank.Text + " " + txtBankAccountNumber.EditValue;
            ledger.BankAccountInfo.BankID = cmbNameOftheBank.EditValue;
            ledger.BankAccountInfo.AccountNumber = txtBankAccountNumber.EditValue;
            ledger.BankAccountInfo.BranchAddress = txtBranchAddress.EditValue;
            ledger.BankAccountInfo.IFSCCode =  txtIFSCCode.EditValue;
            ledger.BankAccountInfo.MICRCode = txtMICRCode.EditValue;
            ledger.BankAccountInfo.NatureOfBankAccountID = cmbNatureoftheBankAccount.EditValue;
            ledger.BankAccountInfo.InterestRate = txtInterestRate.EditValue;
            ledger.BankAccountInfo.OpeningBalance = txtOpeningBalance.EditValue;
            new LedgerRepository().Save(ledger);
        }
    }
}
    