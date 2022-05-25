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
    public partial class ucDebitors : NavigationBase
    {
        public override string Caption => "Debtors ledgers Creation";
        Ledger ledger = null;
        public ucDebitors(Ledger _ledger)
        {
            InitializeComponent();
            ledger = _ledger;   
        }

        private void ucDebitors_Load(object sender, EventArgs e)
        {
            lblHeader.Text = Caption;
            if (ledger.ID != null)
            {
                txtLedgerName.EditValue = ledger.Name;
                cmbRegistrationStatus.EditValue = ledger.DebitorsInfo.GSTRegistrationStatus;
                txtGSTNumber.EditValue = ledger.DebitorsInfo.GSTRegistrationNumber;
                txtPANNumber.EditValue = ledger.DebitorsInfo.PANNumber;
                txtAddress.EditValue = ledger.DebitorsInfo.DebitorAddress;
                txtCreditPeriod.EditValue = ledger.DebitorsInfo.CreditPeriod;
                txtInterestCluase.EditValue = ledger.DebitorsInfo.InterestClause;
                txtOpeningBalance.EditValue = ledger.DebitorsInfo.OpeningBalance;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            ledger.Name = txtLedgerName.EditValue;
            ledger.DebitorsInfo.NameOfSundryDebitors = txtLedgerName.EditValue;
            ledger.DebitorsInfo.GSTRegistrationStatus = cmbRegistrationStatus.EditValue;
            ledger.DebitorsInfo.GSTRegistrationNumber = txtGSTNumber.EditValue;
            ledger.DebitorsInfo.PANNumber = txtPANNumber.EditValue;
            ledger.DebitorsInfo.DebitorAddress = txtAddress.EditValue;
            ledger.DebitorsInfo.CreditPeriod = txtCreditPeriod.EditValue;
            ledger.DebitorsInfo.InterestClause = txtInterestCluase.EditValue;
            ledger.DebitorsInfo.OpeningBalance = txtOpeningBalance.EditValue;
            new LedgerRepository().Save(ledger);
        }
    }
}
