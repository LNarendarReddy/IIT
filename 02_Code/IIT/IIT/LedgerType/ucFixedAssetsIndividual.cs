using DevExpress.XtraEditors;
using Entity;
using IIT;
using Repository;
using Repository.Utility;
using System;

namespace IIT
{
    public partial class ucFixedAssetsIndividual : ucLedgerTypeBase
    {
        private bool _isLandLedger = false;

        public ucFixedAssetsIndividual(Ledger _ledger, bool isCallFromAddButton, bool isLandLedger,string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
            _isLandLedger = isLandLedger;
            lciROD.Visibility = isLandLedger ? DevExpress.XtraLayout.Utils.LayoutVisibility.Never : DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }

        private void ucFixedAssetsIndividual_Load(object sender, EventArgs e)
        {

            cmbTDSRates.Properties.DataSource = LookUpUtility.GetTDSRates();
            cmbTDSRates.Properties.ValueMember = "ENTITYLOOKUPID";
            cmbTDSRates.Properties.DisplayMember = "LOOKUPVALUE";

            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;

            txtLedgerName.EditValue = ledger.Name;
            txtRateOfDepriciation.EditValue = ledger.FixedAssetsIndividualInfo.RateOfDepreciation;
            rgGSTConsidered.EditValue = ledger.FixedAssetsIndividualInfo.IsGSTConsidered;
            rgOperatingAsset.EditValue = ledger.FixedAssetsIndividualInfo.IsOperatingAsset;
            rgTDSApplicable.EditValue = ledger.FixedAssetsIndividualInfo.IsTDSApplicable;
            cmbTDSRates.EditValue = ledger.FixedAssetsIndividualInfo.TDSRate;
            txtOpeningBalance.EditValue = ledger.FixedAssetsIndividualInfo.OpeningBalance;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_isLandLedger)
                dxValidationProvider1.SetValidationRule(txtRateOfDepriciation, null);
            if (!dxValidationProvider1.Validate())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.FixedAssetsIndividualInfo.RateOfDepreciation = txtRateOfDepriciation.EditValue;
            ledger.FixedAssetsIndividualInfo.IsGSTConsidered = rgGSTConsidered.EditValue;
            ledger.FixedAssetsIndividualInfo.IsOperatingAsset = rgOperatingAsset.EditValue;
            ledger.FixedAssetsIndividualInfo.IsTDSApplicable = rgTDSApplicable.EditValue;
            ledger.FixedAssetsIndividualInfo.TDSRate = cmbTDSRates.EditValue;
            ledger.FixedAssetsIndividualInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_FixedAsset;
            Save();
        }

        private void txtRateOfDepriciation_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbGSTConsidered_Enter(object sender, EventArgs e)
        {
            RadioGroup rg = sender as RadioGroup;
            rg.SelectedIndex = rg.EditValue == null ? 0 : rg.SelectedIndex;
        }
    }
}
