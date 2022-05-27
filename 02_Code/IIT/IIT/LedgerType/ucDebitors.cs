using Entity;
using IIT.LedgerType;
using Repository.Utility;
using System;

namespace IIT
{
    public partial class ucDebitors : ucLedgerTypeBase
    {
        public override string Caption => "Debtors ledgers Creation";
        
        public ucDebitors(Ledger _ledger) : base(_ledger)
        {
            InitializeComponent();
        }

        private void ucDebitors_Load(object sender, EventArgs e)
        {
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            cmbRegistrationStatus.EditValue = ledger.DebitorsInfo.GSTRegistrationStatus;
            txtGSTNumber.EditValue = ledger.DebitorsInfo.GSTRegistrationNumber;
            txtPANNumber.EditValue = ledger.DebitorsInfo.PANNumber;
            txtAddress.EditValue = ledger.DebitorsInfo.DebitorAddress;
            txtCreditPeriod.EditValue = ledger.DebitorsInfo.CreditPeriod;
            txtInterestCluase.EditValue = ledger.DebitorsInfo.InterestClause;
            txtOpeningBalance.EditValue = ledger.DebitorsInfo.OpeningBalance;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            ledger.DebitorsInfo.NameOfSundryDebitors = ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.DebitorsInfo.GSTRegistrationStatus = cmbRegistrationStatus.EditValue;
            ledger.DebitorsInfo.GSTRegistrationNumber = txtGSTNumber.EditValue;
            ledger.DebitorsInfo.PANNumber = txtPANNumber.EditValue;
            ledger.DebitorsInfo.DebitorAddress = txtAddress.EditValue;
            ledger.DebitorsInfo.CreditPeriod = txtCreditPeriod.EditValue;
            ledger.DebitorsInfo.InterestClause = txtInterestCluase.EditValue;
            ledger.DebitorsInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_Debitors;
            Save();
        }
    }
}
