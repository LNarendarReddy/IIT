using DevExpress.XtraEditors;
using Entity;
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
    public partial class ucCapitalAccount : ucLedgerTypeBase
    {
        public ucCapitalAccount(Ledger _ledger, bool isCallFromAddButton,string caption) :base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
        }

        private void ucCapitalAccount_Load(object sender, EventArgs e)
        {
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            rgNatgureOfCapital.EditValue = ledger.CapitalAccountInfo.NatureoftheCapital;
            txtAuthorizedCapitalAmount.EditValue = ledger.CapitalAccountInfo.AuthorizedCapitalAmount;
            txtNoOfShares.EditValue = ledger.CapitalAccountInfo.NoOfShares;
            txtFaceValueOfShare.EditValue = ledger.CapitalAccountInfo.FaceValue;
            txtPremiumValueofShare.EditValue = ledger.CapitalAccountInfo.PremiumValue;
            txtPercentageOfPrefarence.EditValue = ledger.CapitalAccountInfo.PercentageOfPreference;
            txtOpeningBalance.EditValue = ledger.CapitalAccountInfo.OpeningBalance;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.CapitalAccountInfo.NatureoftheCapital = rgNatgureOfCapital.EditValue;
            ledger.CapitalAccountInfo.AuthorizedCapitalAmount = txtAuthorizedCapitalAmount.EditValue;
            ledger.CapitalAccountInfo.NoOfShares = txtNoOfShares.EditValue;
            ledger.CapitalAccountInfo.FaceValue = txtFaceValueOfShare.EditValue;
            ledger.CapitalAccountInfo.PremiumValue = txtPremiumValueofShare.EditValue;
            ledger.CapitalAccountInfo.PercentageOfPreference = txtPercentageOfPrefarence.EditValue;
            ledger.CapitalAccountInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_CapitalAccount;
            Save();
        }

        private void rgNatgureOfCapital_Enter(object sender, EventArgs e)
        {
            RadioGroup rg = sender as RadioGroup;
            rg.SelectedIndex = rg.EditValue == null ? 0 : rg.SelectedIndex;
        }

        private void textedit_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

        private void rgNatgureOfCapital_EditValueChanged(object sender, EventArgs e)
        {

        }   
    }
}
