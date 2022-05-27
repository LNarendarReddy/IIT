using Entity;
using IIT.LedgerType;
using Repository.Utility;
using System;

namespace IIT
{
    public partial class ucFixedAssetsIndividual : ucLedgerTypeBase
    {
        public override string Caption => "Fixed Assets ledgers Creation";

        public ucFixedAssetsIndividual(Ledger _ledger) : base(_ledger)
        {
            InitializeComponent();
        }

        private void ucFixedAssetsIndividual_Load(object sender, EventArgs e)
        {
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;

            txtLedgerName.EditValue = ledger.Name;
            txtRateOfDepriciation.EditValue = ledger.FixedAssetsIndividualInfo.RateOfDepreciation;
            cmbGSTConsidered.EditValue = ledger.FixedAssetsIndividualInfo.IsGSTConsidered;
            cmbOperatingAsset.EditValue = ledger.FixedAssetsIndividualInfo.IsOperatingAsset;
            txtOpeningBalance.EditValue = ledger.FixedAssetsIndividualInfo.OpeningBalance;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            ledger.FixedAssetsIndividualInfo.NameOfAsset = ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.FixedAssetsIndividualInfo.RateOfDepreciation = txtRateOfDepriciation.EditValue;
            ledger.FixedAssetsIndividualInfo.IsGSTConsidered = cmbGSTConsidered.EditValue;
            ledger.FixedAssetsIndividualInfo.IsOperatingAsset = cmbOperatingAsset.EditValue;
            ledger.FixedAssetsIndividualInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_FixedAsset;
            Save();
        }
    }
}
