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
    public partial class ucIndirectIncomes : ucLedgerTypeBase
    {
        public ucIndirectIncomes(Ledger _ledger, bool isCallFromAddButton,string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
        }
        private void ucIndirectIncomes_Load(object sender, EventArgs e)
        {
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            rgNatureofIncome.EditValue = ledger.IndirectIncomesInfo.NatureofIncome;
            cmbUnits.EditValue = ledger.IndirectIncomesInfo.UnitID;
            txtHSNCode.EditValue = ledger.IndirectIncomesInfo.HSNCode;
            rgGSTApplicable.EditValue = ledger.IndirectIncomesInfo.IsGSTApplicable;
            txtCGST.EditValue = ledger.IndirectIncomesInfo.CGST;
            txtSGST.EditValue = ledger.IndirectIncomesInfo.SGST;
            txtIGST.EditValue = ledger.IndirectIncomesInfo.IGST;
            rgReverseCharge.EditValue = ledger.IndirectIncomesInfo.IsReverseChargeApplicable;
            rgTDSApplicable.EditValue = ledger.IndirectIncomesInfo.IsTDSApplicable;
            cmbTDSRates.EditValue = ledger.IndirectIncomesInfo.TDSRate;
            txtOpeningBalance.EditValue = ledger.IndirectIncomesInfo.OpeningBalance;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.IndirectIncomesInfo.NatureofIncome = rgNatureofIncome.EditValue;
            ledger.IndirectIncomesInfo.UnitID = cmbUnits.EditValue;
            ledger.IndirectIncomesInfo.HSNCode = txtHSNCode.EditValue;
            ledger.IndirectIncomesInfo.IsGSTApplicable = rgGSTApplicable.EditValue;
            ledger.IndirectIncomesInfo.CGST = txtCGST.EditValue;
            ledger.IndirectIncomesInfo.SGST = txtSGST.EditValue;
            ledger.IndirectIncomesInfo.IGST = txtIGST.EditValue;
            ledger.IndirectIncomesInfo.IsReverseChargeApplicable = rgReverseCharge.EditValue;
            ledger.IndirectIncomesInfo.IsTDSApplicable = rgTDSApplicable.EditValue;
            ledger.IndirectIncomesInfo.TDSRate = cmbTDSRates.EditValue;
            ledger.IndirectIncomesInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_IndirectIncomes;
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
