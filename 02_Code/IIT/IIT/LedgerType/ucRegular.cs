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
    public partial class ucRegular : ucLedgerTypeBase
    {
        public ucRegular(Ledger _ledger, bool isCallFromAddButton, string caption) : base(_ledger, isCallFromAddButton,caption)
        {
            InitializeComponent();
        }
        private void ucRegular_Load(object sender, EventArgs e)
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
            rgRegistrationStatus.EditValue = ledger.RegularInfo.GSTRegistrationStatus;
            txtGSTNumber.EditValue = ledger.RegularInfo.GSTNumber;
            txtPANNumber.EditValue = ledger.RegularInfo.PANNumber;
            rgTDSApplicable.EditValue = ledger.RegularInfo.IsTDSApplicable;
            cmbTDSRates.EditValue = ledger.RegularInfo.TDSRate;
            rgProvisionEntryRequired.EditValue = ledger.RegularInfo.ProvisionalEntryRequired;
            txtOpeningBalance.EditValue = ledger.RegularInfo.OpeningBalance;
            cmbNameoftheBank.EditValue = ledger.RegularInfo.BankID;
            txtAccountNumber.EditValue = ledger.RegularInfo.AccountNumber;
            txtAccountHolderName.EditValue = ledger.RegularInfo.AccountHolderName;
            txtIFSCCode.EditValue = ledger.RegularInfo.IFSCCode;
            txtBranch.EditValue = ledger.RegularInfo.BranchName;
            txtDoorNumber.EditValue = ledger.RegularInfo.DoorNumber;
            txtArea.EditValue = ledger.RegularInfo.Area;
            txtCity.EditValue = ledger.RegularInfo.City;
            txtPinCode.EditValue = ledger.RegularInfo.PinCode;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.RegularInfo.GSTRegistrationStatus = rgRegistrationStatus.EditValue;
            ledger.RegularInfo.GSTNumber = txtGSTNumber.EditValue;
            ledger.RegularInfo.PANNumber = txtPANNumber.EditValue;
            ledger.RegularInfo.IsTDSApplicable = rgTDSApplicable.EditValue;
            ledger.RegularInfo.TDSRate = cmbTDSRates.EditValue;
            ledger.RegularInfo.ProvisionalEntryRequired = rgProvisionEntryRequired.EditValue;
            ledger.RegularInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.RegularInfo.BankID = cmbNameoftheBank.EditValue;
            ledger.RegularInfo.AccountNumber = txtAccountNumber.EditValue;
            ledger.RegularInfo.AccountHolderName = txtAccountHolderName.EditValue;
            ledger.RegularInfo.IFSCCode = txtIFSCCode.EditValue;
            ledger.RegularInfo.BranchName = txtBranch.EditValue;
            ledger.RegularInfo.DoorNumber = txtDoorNumber.EditValue;
            ledger.RegularInfo.Area = txtArea.EditValue;
            ledger.RegularInfo.City = txtCity.EditValue;
            ledger.RegularInfo.PinCode = txtPinCode.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_Regular;
            Save();
        }
        private void textedit_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }
        private void radioGroup_Enter(object sender, EventArgs e)
        {
            RadioGroup rg = sender as RadioGroup;
            rg.SelectedIndex = rg.EditValue == null ? 0 : rg.SelectedIndex;
        }
        private void rgRegistrationStatus_EditValueChanged(object sender, EventArgs e)
        {
            txtGSTNumber.EditValue = null;
            txtGSTNumber.Enabled = rgRegistrationStatus.EditValue.Equals("Registered");
        }
        private void txtGSTNumber_Leave(object sender, EventArgs e)
        {
            if (txtGSTNumber.Text.Length < 12)
                return;
            txtPANNumber.EditValue = txtGSTNumber.Text.Substring(2, 10);
        }
    }
}
