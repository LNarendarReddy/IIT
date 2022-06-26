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
    public partial class ucDirectIncomes : ucLedgerTypeBase
    {
        public ucDirectIncomes(Ledger _ledger, bool isCallFromAddButton,string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
        }
        private void ucDirectIncomes_Load(object sender, EventArgs e)
        {
            cmbTDSRates.Properties.DataSource = LookUpUtility.GetTDSRates();
            cmbTDSRates.Properties.ValueMember = "ENTITYLOOKUPID";
            cmbTDSRates.Properties.DisplayMember = "LOOKUPVALUE";

            cmbUnits.Properties.DataSource = LookUpUtility.GetRMUnits();
            cmbUnits.Properties.ValueMember = "ENTITYLOOKUPID";
            cmbUnits.Properties.DisplayMember = "LOOKUPVALUE";

            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            rgNatureofIncome.EditValue = ledger.DirectIncomesInfo.NatureofIncome;
            cmbUnits.EditValue = ledger.DirectIncomesInfo.UnitID;
            txtHSNCode.EditValue = ledger.DirectIncomesInfo.HSNCode;
            rgGSTApplicable.EditValue = ledger.DirectIncomesInfo.IsGSTApplicable;
            txtCGST.EditValue = ledger.DirectIncomesInfo.CGST;
            txtSGST.EditValue = ledger.DirectIncomesInfo.SGST;
            txtIGST.EditValue = ledger.DirectIncomesInfo.IGST;
            rgReverseCharge.EditValue = ledger.DirectIncomesInfo.IsReverseChargeApplicable;
            rgTDSApplicable.EditValue = ledger.DirectIncomesInfo.IsTDSApplicable;
            cmbTDSRates.EditValue = ledger.DirectIncomesInfo.TDSRate;
            txtOpeningBalance.EditValue = ledger.DirectIncomesInfo.OpeningBalance;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.DirectIncomesInfo.NatureofIncome = rgNatureofIncome.EditValue;
            ledger.DirectIncomesInfo.UnitID = cmbUnits.EditValue;
            ledger.DirectIncomesInfo.HSNCode = txtHSNCode.EditValue;
            ledger.DirectIncomesInfo.IsGSTApplicable = rgGSTApplicable.EditValue;
            ledger.DirectIncomesInfo.CGST = txtCGST.EditValue;
            ledger.DirectIncomesInfo.SGST = txtSGST.EditValue;
            ledger.DirectIncomesInfo.IGST = txtIGST.EditValue;
            ledger.DirectIncomesInfo.IsReverseChargeApplicable = rgReverseCharge.EditValue;
            ledger.DirectIncomesInfo.IsTDSApplicable = rgTDSApplicable.EditValue;
            ledger.DirectIncomesInfo.TDSRate = cmbTDSRates.EditValue;
            ledger.DirectIncomesInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_DirectIncomes;
            Save();
        }
        private void radioGroup_Enter(object sender, EventArgs e)
        {
            RadioGroup rg = sender as RadioGroup;
            rg.SelectedIndex = rg.EditValue == null ? 0 : rg.SelectedIndex;
        }
        private void textEdit_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }
    }
}
