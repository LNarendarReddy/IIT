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
    public partial class ucCreditors : NavigationBase
    {
        public override string Caption => "Creditors or Raw Materials Suupliers ledgers Creation";
        Ledger ledger = null;
        public ucCreditors(Ledger _ledger)
        {
            InitializeComponent();
            ledger = _ledger;
        }

        private void ucCreditors_Load(object sender, EventArgs e)
        {
            lblHeader.Text = Caption;
            if(ledger.ID != null)
            {
                txtLedgerName.EditValue = ledger.Name;
                cmbRegistrationStatus.EditValue = ledger.CreditorsInfo.GSTRegistrationStatus;
                txtGSTNumber.EditValue = ledger.CreditorsInfo.GSTRegistrationNumber;
                txtPANNumber.EditValue = ledger.CreditorsInfo.PANNumber;
                txtAddressOftheSupplier.EditValue = ledger.CreditorsInfo.SupplierAddress;
                txtBankAccountDetails.EditValue = ledger.CreditorsInfo.BankAccountDetails;
                txtCreditPeriodAllowed.EditValue = ledger.CreditorsInfo.CreditPeriod;
                txtInterest.EditValue = ledger.CreditorsInfo.InterestClause;
                txtOpeningBalance.EditValue = ledger.CreditorsInfo.OpeningBalance;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            ledger.CreditorsInfo.NameOfSundryCreditors = ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.CreditorsInfo.GSTRegistrationStatus = cmbRegistrationStatus.EditValue;
            ledger.CreditorsInfo.GSTRegistrationNumber = txtGSTNumber.EditValue;
            ledger.CreditorsInfo.PANNumber = txtPANNumber.EditValue;
            ledger.CreditorsInfo.SupplierAddress = txtAddressOftheSupplier.EditValue;
            ledger.CreditorsInfo.BankAccountDetails = txtBankAccountDetails.EditValue;
            ledger.CreditorsInfo.CreditPeriod = txtCreditPeriodAllowed.EditValue;
            ledger.CreditorsInfo.InterestClause = txtInterest.EditValue;
            ledger.CreditorsInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_Creditors;
            ledger.UserName = Utility.UserName;
            new LedgerRepository().Save(ledger);
            frmSingularMain.Instance.RollbackControl();
        }
    }
}
