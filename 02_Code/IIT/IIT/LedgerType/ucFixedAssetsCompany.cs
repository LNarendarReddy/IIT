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
    public partial class ucFixedAssetsCompany : NavigationBase
    {
        public override string Caption => "Debtors ledgers Creation";
        Ledger ledger = null;
        public ucFixedAssetsCompany(Ledger _ledger)
        {
            InitializeComponent();
            ledger = _ledger;
        }

        private void ucFixedAssetsCompany_Load(object sender, EventArgs e)
        {
            lblHeader.Text = Caption;
            if (ledger.ID != null)
            {
                txtLedgerName.EditValue = ledger.Name;
                txtRateOfDerpiciation.EditValue = ledger.FixedAssetsCompanyInfo.RateOfDepreciation;
                cmbGSTConsidered.EditValue = ledger.FixedAssetsCompanyInfo.IsGSTConsidered;
                cmbOperatingAsset .EditValue = ledger.FixedAssetsCompanyInfo.IsOperatingAsset;
                txtOpeningBalanceDR.EditValue = ledger.FixedAssetsCompanyInfo.OpeningBalanceOfDepreciationReserve;
                txtOpeningBalance.EditValue = ledger.FixedAssetsCompanyInfo.OpeningBalance;
            }
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
            ledger.UserName = Utility.UserName;
            new LedgerRepository().Save(ledger);
            frmSingularMain.Instance.RollbackControl();
        }
    }
}
