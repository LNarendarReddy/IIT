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
    public partial class ucServices : NavigationBase
    {
        public override string Caption => "Service Providers/ Sub Contractors Creation";
        Ledger ledger = null;
        public ucServices(Ledger _ledger)
        {
            InitializeComponent();
            ledger = _ledger;
        }

        private void ucServices_Load(object sender, EventArgs e)
        {
            lblHeader.Text = Caption;
            if (ledger.ID != null)
            {
                txtLedgerName.EditValue = ledger.Name;
                cmbRegistrationStatus.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.GSTRegistrationStatus;
                txtGSTNumber.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.GSTRegistrationNumber;
                txtPANNumber.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.PANNumber;
                txtBankAccountNumber.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.BankAccountDetails;
                txtOpeningBalance.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.OpeningBalance;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            ledger.ServicesOrDuesToSubContractorsInfo.Name = ledger.Name = txtLedgerName.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.GSTRegistrationStatus = cmbRegistrationStatus.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.GSTRegistrationNumber = txtGSTNumber.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.PANNumber = txtPANNumber.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.BankAccountDetails = txtBankAccountNumber.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.OpeningBalance = txtOpeningBalance.EditValue;
            new LedgerRepository().Save(ledger);
        }
    }
}
