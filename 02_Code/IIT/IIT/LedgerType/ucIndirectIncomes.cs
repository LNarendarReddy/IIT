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
    public partial class ucIndirectIncomes : ucLedgerTypeBase
    {
        public ucIndirectIncomes(Ledger _ledger, bool isCallFromAddButton,string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
            this.txtIGST.Spin += base.textedit_Spin;
            this.txtSGST.Spin += base.textedit_Spin;
            this.txtCGST.Spin += base.textedit_Spin;
            this.txtOpeningBalance.Spin += base.textedit_Spin;
        }
        private void ucIndirectIncomes_Load(object sender, EventArgs e)
        {
            cmbTDSRates.Properties.DataSource = LookUpUtility.GetTDSRates();
            cmbUnits.Properties.DataSource = LookUpUtility.GetRMUnits();
            cmbNatureOfIncome.Properties.DataSource = LookUpUtility.GetIncomeType1();
            cmbReverseCharge.Properties.DataSource =
                cmbTDSApplicable.Properties.DataSource =
                cmbGSTApplicable.Properties.DataSource = LookUpUtility.GetBoolType();
            base.AddControls(layoutControl1);
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            cmbNatureOfIncome.EditValue = ledger.IndirectIncomesInfo.NatureofIncome;
            cmbUnits.EditValue = ledger.IndirectIncomesInfo.UnitID;
            txtHSNCode.EditValue = ledger.IndirectIncomesInfo.HSNCode;
            cmbGSTApplicable.EditValue = ledger.IndirectIncomesInfo.IsGSTApplicable;
            txtCGST.EditValue = ledger.IndirectIncomesInfo.CGST;
            txtSGST.EditValue = ledger.IndirectIncomesInfo.SGST;
            txtIGST.EditValue = ledger.IndirectIncomesInfo.IGST;
            cmbReverseCharge.EditValue = ledger.IndirectIncomesInfo.IsReverseChargeApplicable;
            cmbTDSApplicable.EditValue = ledger.IndirectIncomesInfo.IsTDSApplicable;
            cmbTDSRates.EditValue = ledger.IndirectIncomesInfo.TDSRate;
            txtOpeningBalance.EditValue = ledger.IndirectIncomesInfo.OpeningBalance;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.IndirectIncomesInfo.NatureofIncome = cmbNatureOfIncome .EditValue;
            ledger.IndirectIncomesInfo.UnitID = cmbUnits.EditValue;
            ledger.IndirectIncomesInfo.HSNCode = txtHSNCode.EditValue;
            ledger.IndirectIncomesInfo.IsGSTApplicable = cmbGSTApplicable.EditValue;
            ledger.IndirectIncomesInfo.CGST = txtCGST.EditValue;
            ledger.IndirectIncomesInfo.SGST = txtSGST.EditValue;
            ledger.IndirectIncomesInfo.IGST = txtIGST.EditValue;
            ledger.IndirectIncomesInfo.IsReverseChargeApplicable = cmbReverseCharge.EditValue;
            ledger.IndirectIncomesInfo.IsTDSApplicable = cmbTDSApplicable.EditValue;
            ledger.IndirectIncomesInfo.TDSRate = cmbTDSRates.EditValue;
            ledger.IndirectIncomesInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_IndirectIncomes;
            Save();
        }
    }
}
