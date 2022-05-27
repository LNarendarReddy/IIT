using Entity;
using IIT;
using Repository.Utility;
using System;

namespace IIT
{
    public partial class ucFixedAssetsCompany : ucLedgerTypeBase
    {
        public override string Caption => "Fixed Assets ledgers Creation";
        public ucFixedAssetsCompany(Ledger _ledger) : base(_ledger)
        {
            InitializeComponent();
        }

        private void ucFixedAssetsCompany_Load(object sender, EventArgs e)
        {
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            txtRateOfDerpiciation.EditValue = ledger.FixedAssetsCompanyInfo.RateOfDepreciation;
            cmbGSTConsidered.EditValue = ledger.FixedAssetsCompanyInfo.IsGSTConsidered;
            cmbOperatingAsset.EditValue = ledger.FixedAssetsCompanyInfo.IsOperatingAsset;
            txtOpeningBalanceDR.EditValue = ledger.FixedAssetsCompanyInfo.OpeningBalanceOfDepreciationReserve;
            txtOpeningBalance.EditValue = ledger.FixedAssetsCompanyInfo.OpeningBalance;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            ledger.FixedAssetsCompanyInfo.NameOfAsset = ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.FixedAssetsCompanyInfo.RateOfDepreciation = txtRateOfDerpiciation.EditValue;
            ledger.FixedAssetsCompanyInfo.IsGSTConsidered = cmbGSTConsidered.EditValue;
            ledger.FixedAssetsCompanyInfo.IsOperatingAsset = cmbOperatingAsset.EditValue;
            ledger.FixedAssetsCompanyInfo.OpeningBalanceOfDepreciationReserve = txtOpeningBalanceDR.EditValue;
            ledger.FixedAssetsCompanyInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_FixedAsset;
            Save();
        }

    }
}
