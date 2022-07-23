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
    public partial class ucCCorODC : ucLedgerTypeBase
    {
        public ucCCorODC(Ledger _ledger, bool isCallFromAddButton,string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
            this.txtOpeningBalance.Spin += base.textedit_Spin;
            this.txtInterestRate.Spin += base.textedit_Spin;
        }
        private void ucCCorODC_Load(object sender, EventArgs e)
        {
            cmbNameoftheBank.Properties.DataSource = LookUpUtility.GetBanks();
            cmbTDSRates.Properties.DataSource = LookUpUtility.GetTDSRates();
            cmbTypeofLoan.Properties.DataSource = LookUpUtility.GetLoanType();
            cmbTDSApplicable.Properties.DataSource = LookUpUtility.GetBoolType();
            base.AddControls(layoutControl1);

            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            cmbTypeofLoan.EditValue = ledger.CCorODCInfo.TypeOfLoan;
            dtpLoanSanctionDate.EditValue = ledger.CCorODCInfo.LoanSanctionDate;
            txtInterestRate.EditValue = ledger.CCorODCInfo.InterestRate;
            txtEMIAmount.EditValue = ledger.CCorODCInfo.RegularEMIAmount;
            txtGSTNumber.EditValue = ledger.CCorODCInfo.FinancerGSTNo;
            txtPANNumber.EditValue = ledger.CCorODCInfo.PANNo;
            cmbTDSApplicable.EditValue = ledger.CCorODCInfo.IsTDSApplicable;
            cmbTDSRates.EditValue = ledger.CCorODCInfo.TDSRate;
            txtOpeningBalance.EditValue = ledger.CCorODCInfo.OpeningBalance;
            cmbNameoftheBank.EditValue = ledger.CCorODCInfo.BankID;
            txtAccountHolderName.EditValue = ledger.CCorODCInfo.AccountNumber;
            txtAccountHolderName.EditValue = ledger.CCorODCInfo.AccountHolderName;
            txtIFSCCode.EditValue = ledger.CCorODCInfo.IFSCCode;
            txtBranch.EditValue = ledger.CCorODCInfo.BranchName;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.CCorODCInfo.TypeOfLoan = cmbTypeofLoan.EditValue;
            ledger.CCorODCInfo.LoanSanctionDate = dtpLoanSanctionDate.EditValue;
            ledger.CCorODCInfo.InterestRate = txtInterestRate.EditValue;
            ledger.CCorODCInfo.RegularEMIAmount = txtEMIAmount.EditValue;
            ledger.CCorODCInfo.FinancerGSTNo = txtGSTNumber.EditValue;
            ledger.CCorODCInfo.PANNo = txtPANNumber.EditValue;
            ledger.CCorODCInfo.IsTDSApplicable = cmbTDSApplicable.EditValue;
            ledger.CCorODCInfo.TDSRate = cmbTDSRates.EditValue;
            ledger.CCorODCInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.CCorODCInfo.BankID = cmbNameoftheBank.EditValue;
            ledger.CCorODCInfo.AccountNumber = txtAccountHolderName.EditValue;
            ledger.CCorODCInfo.AccountHolderName = txtAccountHolderName.EditValue;
            ledger.CCorODCInfo.IFSCCode = txtIFSCCode.EditValue;
            ledger.CCorODCInfo.BranchName = txtBranch.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_CCOrODC;
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
