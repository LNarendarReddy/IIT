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
            this.txtIGST.Spin += base.textedit_Spin;
            this.txtSGST.Spin += base.textedit_Spin;
            this.txtCGST.Spin += base.textedit_Spin;
            this.txtOpeningBalance.Spin += base.textedit_Spin;
        }
        private void ucDirectIncomes_Load(object sender, EventArgs e)
        {
            base.AddControls(layoutControl1);
            cmbTDSRates.Properties.DataSource = LookUpUtility.GetTDSRates();
            cmbUnits.Properties.DataSource = LookUpUtility.GetRMUnits();
            cmbNatureOfIncome.Properties.DataSource = LookUpUtility.GetIncomeType1();
            cmbReverseCharge.Properties.DataSource =
                cmbTDSApplicable.Properties.DataSource =
                cmbGSTApplicable.Properties.DataSource = LookUpUtility.GetBoolType();
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            cmbNatureOfIncome.EditValue = ledger.DirectIncomesInfo.NatureofIncome;
            cmbUnits.EditValue = ledger.DirectIncomesInfo.UnitID;
            txtHSNCode.EditValue = ledger.DirectIncomesInfo.HSNCode;
            cmbGSTApplicable.EditValue = ledger.DirectIncomesInfo.IsGSTApplicable;
            txtCGST.EditValue = ledger.DirectIncomesInfo.CGST;
            txtSGST.EditValue = ledger.DirectIncomesInfo.SGST;
            txtIGST.EditValue = ledger.DirectIncomesInfo.IGST;
            cmbReverseCharge.EditValue = ledger.DirectIncomesInfo.IsReverseChargeApplicable;
            cmbTDSApplicable.EditValue = ledger.DirectIncomesInfo.IsTDSApplicable;
            cmbTDSRates.EditValue = ledger.DirectIncomesInfo.TDSRate;
            txtOpeningBalance.EditValue = ledger.DirectIncomesInfo.OpeningBalance;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.DirectIncomesInfo.NatureofIncome = cmbNatureOfIncome.EditValue;
            ledger.DirectIncomesInfo.UnitID = cmbUnits.EditValue;
            ledger.DirectIncomesInfo.HSNCode = txtHSNCode.EditValue;
            ledger.DirectIncomesInfo.IsGSTApplicable = cmbGSTApplicable.EditValue;
            ledger.DirectIncomesInfo.CGST = txtCGST.EditValue;
            ledger.DirectIncomesInfo.SGST = txtSGST.EditValue;
            ledger.DirectIncomesInfo.IGST = txtIGST.EditValue;
            ledger.DirectIncomesInfo.IsReverseChargeApplicable = cmbReverseCharge.EditValue;
            ledger.DirectIncomesInfo.IsTDSApplicable = cmbTDSApplicable.EditValue;
            ledger.DirectIncomesInfo.TDSRate = cmbTDSRates.EditValue;
            ledger.DirectIncomesInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_DirectIncomes;
            Save();
        }
        private void cmbGSTApplicable_EditValueChanged(object sender, EventArgs e)
        {
            txtCGST.EditValue = txtSGST.EditValue = txtIGST.EditValue = null;
            txtCGST.Enabled = txtSGST.Enabled = txtIGST.Enabled =
                cmbGSTApplicable.Text.Equals("Yes");
        }
        private void cmbTDSApplicable_EditValueChanged(object sender, EventArgs e)
        {
            cmbTDSRates.EditValue = null;
            cmbTDSRates.Enabled = cmbTDSApplicable.Text.Equals("Yes");
        }
        private void cmbNatureOfIncome_EditValueChanged(object sender, EventArgs e)
        {
            cmbReverseCharge.EditValue = null;
            cmbReverseCharge.Enabled = cmbNatureOfIncome.Text.Equals("Services");
        }
    }
}
