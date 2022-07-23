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
            this.txtMoratoriumPeriod.Spin += base.textedit_Spin;
            this.txtEMIAmount.Spin += base.textedit_Spin;
            this.txtOpeningBalance.Spin += base.textedit_Spin;
            this.txtInterestRate.Spin += base.textedit_Spin;
        }
        private void ucLoans_Load(object sender, EventArgs e)
        {
            base.AddControls(layoutControl1);
            cmbNameoftheBank.Properties.DataSource = LookUpUtility.GetBanks();
            cmbTDSRates.Properties.DataSource = LookUpUtility.GetTDSRates();
            cmbTypeofLoan.Properties.DataSource = LookUpUtility.GetLoanType1();
            cmbTDSApplicable.Properties.DataSource = LookUpUtility.GetBoolType();
            cmbFrequency.Properties.DataSource = LookUpUtility.GetLoanRepaymentFrequency();


            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            cmbTypeofLoan.EditValue = ledger.LoanInfo.TypeOfLoan;
            dtpLoanSanctionDate.EditValue = ledger.LoanInfo.LoanSanctionDate;
            txtMoratoriumPeriod.EditValue = ledger.LoanInfo.MoratoriumPeriod;
            txtNameOftheBank.EditValue = ledger.LoanInfo.NameOftheBank;
            txtloanAccountNumber.EditValue = ledger.LoanInfo.BankAccOfLoan;
            txtGSTNumber.EditValue = ledger.LoanInfo.FinancerGST;
            txtPANNumber.EditValue = ledger.LoanInfo.PANNo;
            cmbTDSApplicable.EditValue = ledger.LoanInfo.IsTDSApplicable;
            cmbTDSRates.EditValue = ledger.LoanInfo.TDSRate;
            txtOpeningBalance.EditValue = ledger.LoanInfo.OpeningBalance;
            dtpEMIStartDate.EditValue = ledger.LoanInfo. EMIStartDate;
            dtpEMIClosingDate.EditValue = ledger.LoanInfo.EMIEndDate;
            txtInterestRate.EditValue = ledger.LoanInfo.InterestRate;
            cmbFrequency.EditValue = ledger.LoanInfo.Frequency;
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
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.LoanInfo.TypeOfLoan = cmbTypeofLoan.EditValue;
            ledger.LoanInfo.LoanSanctionDate = dtpLoanSanctionDate.EditValue;
            ledger.LoanInfo.MoratoriumPeriod = txtMoratoriumPeriod.EditValue;
            ledger.LoanInfo.NameOftheBank = txtNameOftheBank.EditValue;
            ledger.LoanInfo.BankAccOfLoan = txtloanAccountNumber.EditValue;
            ledger.LoanInfo.FinancerGST = txtGSTNumber.EditValue;
             ledger.LoanInfo.PANNo = txtPANNumber.EditValue;
            ledger.LoanInfo.IsTDSApplicable = cmbTDSApplicable.EditValue;
            ledger.LoanInfo.TDSRate = cmbTDSRates.EditValue;
            ledger.LoanInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LoanInfo.EMIStartDate = dtpEMIStartDate.EditValue;
            ledger.LoanInfo.EMIEndDate = dtpEMIClosingDate.EditValue;
            ledger.LoanInfo.InterestRate = txtInterestRate.EditValue;
            ledger.LoanInfo.Frequency = cmbFrequency.EditValue;
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
        private void txtGSTNumber_Leave(object sender, EventArgs e)
        {
            if (txtGSTNumber.Text.Length < 12)
                return;
            txtPANNumber.EditValue = txtGSTNumber.Text.Substring(2, 10);
        }
    }
}
