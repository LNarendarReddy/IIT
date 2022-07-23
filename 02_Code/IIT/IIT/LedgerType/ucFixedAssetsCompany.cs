using DevExpress.XtraEditors;
using Entity;
using IIT;
using Repository;
using Repository.Utility;
using System;

namespace IIT
{
    public partial class ucFixedAssetsCompany : ucLedgerTypeBase
    {
        private bool _isLandLedger;
        public ucFixedAssetsCompany(Ledger _ledger, bool isCallFromAddButton,bool isLandLedger,string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
            _isLandLedger = isLandLedger;
            lciROD.Visibility = isLandLedger ? DevExpress.XtraLayout.Utils.LayoutVisibility.Never : DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            lciDR.Visibility = isLandLedger ? DevExpress.XtraLayout.Utils.LayoutVisibility.Never : DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            this.txtOpeningBalanceDR.Spin += base.textedit_Spin;
            this.txtOpeningBalance.Spin += base.textedit_Spin;
            this.txtRateOfDerpiciation.Spin += base.textedit_Spin;
        }
        private void ucFixedAssetsCompany_Load(object sender, EventArgs e)
        {
            cmbGSTConsidered.Properties.DataSource =
                cmbOperatingAsset.Properties.DataSource =
                cmbTDSApplicable.Properties.DataSource = LookUpUtility.GetBoolType();
            cmbTDSRates.Properties.DataSource = LookUpUtility.GetTDSRates();
            base.AddControls(layoutControl1);
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            txtRateOfDerpiciation.EditValue = ledger.FixedAssetsCompanyInfo.RateOfDepreciation;
            cmbGSTConsidered.EditValue = ledger.FixedAssetsCompanyInfo.IsGSTConsidered;
            cmbOperatingAsset.EditValue = ledger.FixedAssetsCompanyInfo.IsOperatingAsset;
            txtOpeningBalanceDR.EditValue = ledger.FixedAssetsCompanyInfo.OpeningBalanceOfDepreciationReserve;
            cmbTDSApplicable.EditValue = ledger.FixedAssetsCompanyInfo.IsTDSApplicable;
            cmbTDSRates.EditValue = ledger.FixedAssetsCompanyInfo.TDSRate;
            txtOpeningBalance.EditValue = ledger.FixedAssetsCompanyInfo.OpeningBalance;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.FixedAssetsCompanyInfo.RateOfDepreciation = txtRateOfDerpiciation.EditValue;
            ledger.FixedAssetsCompanyInfo.IsGSTConsidered = cmbGSTConsidered.EditValue;
            ledger.FixedAssetsCompanyInfo.IsOperatingAsset = cmbOperatingAsset.EditValue;
            ledger.FixedAssetsCompanyInfo.OpeningBalanceOfDepreciationReserve = txtOpeningBalanceDR.EditValue;
            ledger.FixedAssetsCompanyInfo.IsTDSApplicable = cmbTDSApplicable.EditValue;
            ledger.FixedAssetsCompanyInfo.TDSRate = cmbTDSRates.EditValue;
            ledger.FixedAssetsCompanyInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_FixedAsset;
            Save();
        }
    }
}
