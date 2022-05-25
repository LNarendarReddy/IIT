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
    public partial class ucFixedAssetsIndividual : NavigationBase
    {
        public override string Caption => "Fixed Assets ledgers Creation";
        Ledger ledger = null;

        public ucFixedAssetsIndividual(Ledger _ledger)
        {
            InitializeComponent();
            ledger = _ledger;
        }

        private void ucFixedAssetsIndividual_Load(object sender, EventArgs e)
        {
            lblHeader.Text = Caption;
            if (ledger.ID != null)
            {
                txtLedgerName.EditValue = ledger.Name;
                txtRateOfDepriciation.EditValue = ledger.FixedAssetsIndividualInfo.RateOfDepreciation;
                cmbGSTConsidered.EditValue = ledger.FixedAssetsIndividualInfo.IsGSTConsidered;
                cmbOperatingAsset.EditValue = ledger.FixedAssetsIndividualInfo.IsOperatingAsset;
                txtOpeningBalance.EditValue = ledger.FixedAssetsIndividualInfo.OpeningBalance;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            ledger.FixedAssetsIndividualInfo.NameOfAsset = ledger.Name = txtLedgerName.EditValue;
            ledger.FixedAssetsIndividualInfo.RateOfDepreciation = txtRateOfDepriciation.EditValue;
            ledger.FixedAssetsIndividualInfo.IsGSTConsidered = cmbGSTConsidered.EditValue;
            ledger.FixedAssetsIndividualInfo.IsOperatingAsset = cmbOperatingAsset.EditValue;
            ledger.FixedAssetsIndividualInfo.OpeningBalance = txtOpeningBalance.EditValue;
            new LedgerRepository().Save(ledger);
        }
    }
}
