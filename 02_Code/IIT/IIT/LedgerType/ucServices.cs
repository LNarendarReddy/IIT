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
                txtBankAccountNumber.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.BankAccountNumber;
                txtAccountHolderName.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.AccountHolderName;
                txtIFSCCode.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.IFSCCode;
                txtBranch.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.BrancName;
                txtOpeningBalance.EditValue = ledger.ServicesOrDuesToSubContractorsInfo.OpeningBalance;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            ledger.ServicesOrDuesToSubContractorsInfo.Name = ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.GSTRegistrationStatus = cmbRegistrationStatus.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.GSTRegistrationNumber = txtGSTNumber.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.PANNumber = txtPANNumber.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.BankAccountNumber = txtBankAccountNumber.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.AccountHolderName = txtAccountHolderName.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.IFSCCode = txtIFSCCode.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.BrancName = txtBranch.EditValue;
            ledger.ServicesOrDuesToSubContractorsInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_ServiceOrDuesToSubContractors;
            ledger.UserName = Utility.UserName;
            new LedgerRepository().Save(ledger);
            frmSingularMain.Instance.RollbackControl();
        }
    }
}
