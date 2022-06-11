using DevExpress.XtraEditors;
using Entity;
using IIT;
using Repository.Utility;
using System;

namespace IIT
{
    public partial class ucFixedAssetsCompany : ucLedgerTypeBase
    {
        private bool _isLandLedger;
        public override string Caption => "Fixed Assets ledgers Creation";
        public ucFixedAssetsCompany(Ledger _ledger, bool isCallFromAddButton,bool isLandLedger) : base(_ledger, isCallFromAddButton)
        {
            InitializeComponent();
            _isLandLedger = isLandLedger;
            lciROD.Visibility = isLandLedger ? DevExpress.XtraLayout.Utils.LayoutVisibility.Never : DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            lciDR.Visibility = isLandLedger ? DevExpress.XtraLayout.Utils.LayoutVisibility.Never : DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }

        private void ucFixedAssetsCompany_Load(object sender, EventArgs e)
        {
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            txtRateOfDerpiciation.EditValue = ledger.FixedAssetsCompanyInfo.RateOfDepreciation;
            rgGSTConsidered.EditValue = ledger.FixedAssetsCompanyInfo.IsGSTConsidered;
            rgOperatingAsset.EditValue = ledger.FixedAssetsCompanyInfo.IsOperatingAsset;
            txtOpeningBalanceDR.EditValue = ledger.FixedAssetsCompanyInfo.OpeningBalanceOfDepreciationReserve;
            txtOpeningBalance.EditValue = ledger.FixedAssetsCompanyInfo.OpeningBalance;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_isLandLedger)
            {
                dxValidationProvider1.SetValidationRule(txtRateOfDerpiciation, null);
                dxValidationProvider1.SetValidationRule(txtOpeningBalanceDR, null);
            }
            if (!dxValidationProvider1.Validate())
                return;
            ledger.FixedAssetsCompanyInfo.NameOfAsset = ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.FixedAssetsCompanyInfo.RateOfDepreciation = txtRateOfDerpiciation.EditValue;
            ledger.FixedAssetsCompanyInfo.IsGSTConsidered = rgGSTConsidered.EditValue;
            ledger.FixedAssetsCompanyInfo.IsOperatingAsset = rgOperatingAsset.EditValue;
            ledger.FixedAssetsCompanyInfo.OpeningBalanceOfDepreciationReserve = txtOpeningBalanceDR.EditValue;
            ledger.FixedAssetsCompanyInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_FixedAsset;
            Save();
        }

        private void txtRateOfDerpiciation_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

        private void rgGSTConsidered_Enter(object sender, EventArgs e)
        {
            RadioGroup rg = sender as RadioGroup;
            rg.SelectedIndex = rg.EditValue == null ? 0 : rg.SelectedIndex;
        }
    }
}
