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
    public partial class ucLoans : ucLedgerTypeBase
    {
        public ucLoans(Ledger _ledger, bool isCallFromAddButton, string caption) : base(_ledger, isCallFromAddButton,caption)
        {
            InitializeComponent();
        }

        private void ucLoans_Load(object sender, EventArgs e)
        {
            cmbNameoftheBank.Properties.DataSource = LookUpUtility.GetBanks();
            cmbNameoftheBank.Properties.ValueMember = "ENTITYLOOKUPID";
            cmbNameoftheBank.Properties.DisplayMember = "LOOKUPVALUE";

            cmbTDSRates.Properties.DataSource = LookUpUtility.GetTDSRates();
            cmbTDSRates.Properties.ValueMember = "ENTITYLOOKUPID";
            cmbTDSRates.Properties.DisplayMember = "LOOKUPVALUE";

            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            rgTypeofLoan.EditValue = ledger.LoanInfo.TypeOfLoan;
            dtpLoanSanctionDate.EditValue = ledger.LoanInfo.LoanSanctionDate;
            txtMoratoriumPeriod.EditValue = ledger.LoanInfo.MoratoriumPeriod;
            txtNameOftheBank.EditValue = ledger.LoanInfo.NameOftheBank;
            txtloanAccountNumber.EditValue = ledger.LoanInfo.BankAccOfLoan;
            txtGSTNumber.EditValue = ledger.LoanInfo.FinancerGST;
            txtPANNumber.EditValue = ledger.LoanInfo.PANNo;
            rgTDSApplicable.EditValue = ledger.LoanInfo.IsTDSApplicable;
            cmbTDSRates.EditValue = ledger.LoanInfo.TDSRate;
            txtOpeningBalance.EditValue = ledger.LoanInfo.OpeningBalance;
            dtpEMIStartDate.EditValue = ledger.LoanInfo. EMIStartDate;
            dtpEMIClosingDate.EditValue = ledger.LoanInfo.EMIEndDate;
            txtInterestRate.EditValue = ledger.LoanInfo.InterestRate;
            rgFreaquency.EditValue = ledger.LoanInfo.Frequency;
            dtpEMIDate.EditValue = ledger.LoanInfo.EMIDate;
            txtEMIAmount.EditValue = ledger.LoanInfo.EMIAmount;
            cmbNameoftheBank.EditValue = ledger.LoanInfo.BankID;
            txtAccountNumber.EditValue = ledger.LoanInfo.AccountNumber;
            txtAccountHolderName.EditValue = ledger.LoanInfo.AccountHolderName;
            txtIFSCCode.EditValue = ledger.LoanInfo.IFSCCode;
            txtBranch.EditValue = ledger.LoanInfo.BranchName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.LoanInfo.TypeOfLoan = rgTypeofLoan.EditValue;
            ledger.LoanInfo.LoanSanctionDate = dtpLoanSanctionDate.EditValue;
            ledger.LoanInfo.MoratoriumPeriod = txtMoratoriumPeriod.EditValue;
            ledger.LoanInfo.NameOftheBank = txtNameOftheBank.EditValue;
            ledger.LoanInfo.BankAccOfLoan = txtloanAccountNumber.EditValue;
            ledger.LoanInfo.FinancerGST = txtGSTNumber.EditValue;
             ledger.LoanInfo.PANNo = txtPANNumber.EditValue;
            ledger.LoanInfo.IsTDSApplicable = rgTDSApplicable.EditValue;
            ledger.LoanInfo.TDSRate = cmbTDSRates.EditValue;
            ledger.LoanInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LoanInfo.EMIStartDate = dtpEMIStartDate.EditValue;
            ledger.LoanInfo.EMIEndDate = dtpEMIClosingDate.EditValue;
            ledger.LoanInfo.InterestRate = txtInterestRate.EditValue;
            ledger.LoanInfo.Frequency = rgFreaquency.EditValue;
            ledger.LoanInfo.EMIDate = dtpEMIDate.EditValue;
            ledger.LoanInfo.EMIAmount = txtEMIAmount.EditValue;
            ledger.LoanInfo.BankID = cmbNameoftheBank.EditValue;
            ledger.LoanInfo.AccountNumber = txtAccountNumber.EditValue;
            ledger.LoanInfo.AccountHolderName = txtAccountHolderName.EditValue;
            ledger.LoanInfo.IFSCCode = txtIFSCCode.EditValue;
            ledger.LoanInfo.BranchName = txtBranch.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_Loan;
            Save();
        }

        private void radioGroup_Enter(object sender, EventArgs e)
        {
            RadioGroup rg = sender as RadioGroup;
            rg.SelectedIndex = rg.EditValue == null ? 0 : rg.SelectedIndex;
        }

        private void textedit_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }
        private void txtGSTNumber_Leave(object sender, EventArgs e)
        {
            if (txtGSTNumber.Text.Length < 12)
                return;
            txtPANNumber.EditValue = txtGSTNumber.Text.Substring(2, 10);
        }
    }
}
