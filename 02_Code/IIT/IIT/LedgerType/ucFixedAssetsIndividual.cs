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
            this.txtOpeningBalance.Spin += base.textedit_Spin;
            this.txtRateOfDepriciation.Spin += base.textedit_Spin;
        }
        private void ucFixedAssetsIndividual_Load(object sender, EventArgs e)
        {
            cmbTDSRates.Properties.DataSource = LookUpUtility.GetTDSRates();
            cmbGSTConsidered.Properties.DataSource = 
                cmbOperatingAsset.Properties.DataSource = cmbTDSApplicable.Properties.DataSource = LookUpUtility.GetBoolType();
            base.AddControls(layoutControl1);
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            txtRateOfDepriciation.EditValue = ledger.FixedAssetsIndividualInfo.RateOfDepreciation;
            cmbGSTConsidered.EditValue = ledger.FixedAssetsIndividualInfo.IsGSTConsidered;
            cmbOperatingAsset.EditValue = ledger.FixedAssetsIndividualInfo.IsOperatingAsset;
            cmbTDSApplicable.EditValue = ledger.FixedAssetsIndividualInfo.IsTDSApplicable;
            cmbTDSRates.EditValue = ledger.FixedAssetsIndividualInfo.TDSRate;
            txtOpeningBalance.EditValue = ledger.FixedAssetsIndividualInfo.OpeningBalance;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.FixedAssetsIndividualInfo.RateOfDepreciation = txtRateOfDepriciation.EditValue;
            ledger.FixedAssetsIndividualInfo.IsGSTConsidered = cmbGSTConsidered.EditValue;
            ledger.FixedAssetsIndividualInfo.IsOperatingAsset = cmbOperatingAsset.EditValue;
            ledger.FixedAssetsIndividualInfo.IsTDSApplicable = cmbTDSApplicable.EditValue;
            ledger.FixedAssetsIndividualInfo.TDSRate = cmbTDSRates.EditValue;
            ledger.FixedAssetsIndividualInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_FixedAsset;
            Save();
        }
        private void cmbTDSApplicable_EditValueChanged(object sender, EventArgs e)
        {
            cmbTDSRates.EditValue = null;
            cmbTDSRates.Enabled = cmbTDSApplicable.Text.Equals("Yes");
        }
    }
}
