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

namespace IIT.LedgerType
{
    public partial class ucCommission : ucLedgerTypeBase
    {
        public ucCommission(Ledger _ledger, bool isCallFromAddButton, string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
        }

        private void ucCommission_Load(object sender, EventArgs e)
        {
            cmbTDSRates.Properties.DataSource = LookUpUtility.GetTDSRates();
            cmbTDSRates.Properties.ValueMember = "ENTITYLOOKUPID";
            cmbTDSRates.Properties.DisplayMember = "LOOKUPVALUE";

            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;

            txtLedgerName.EditValue = ledger.Name;
            txtGSTNumber.EditValue = ledger.CommissionInfo.GSTNumber;
            txtPANNumber.EditValue = ledger.CommissionInfo.PanNumber;
            rgTDSApplicable.EditValue = ledger.CommissionInfo.IsTDSApplicable;
            cmbTDSRates.EditValue = ledger.CommissionInfo.TDSRate;
            txtNameOfConsideration.EditValue = ledger.CommissionInfo.NatureOfConsideration;
            txtOpeningBalance.EditValue = ledger.ReservesAndSurplusInfo.OpeningBalance;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.CommissionInfo.GSTNumber = txtGSTNumber.EditValue;
            ledger.CommissionInfo.PanNumber = txtPANNumber.EditValue;
            ledger.CommissionInfo.IsTDSApplicable = rgTDSApplicable.EditValue;
            ledger.CommissionInfo.TDSRate = cmbTDSRates.EditValue;
            ledger.CommissionInfo.NatureOfConsideration = txtNameOfConsideration.EditValue;
            ledger.ReservesAndSurplusInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_Commission;
            Save();
        }
        private void textExit_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }
        private void radioGroup_Enter(object sender, EventArgs e)
        {
            RadioGroup rg = sender as RadioGroup;
            rg.SelectedIndex = rg.EditValue == null ? 0 : rg.SelectedIndex;
        }
    }
}
