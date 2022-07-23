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
    public partial class ucCommission : ucLedgerTypeBase
    {
        public ucCommission(Ledger _ledger, bool isCallFromAddButton, string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
            this.txtOpeningBalance.Spin += base.textedit_Spin;
        }

        private void ucCommission_Load(object sender, EventArgs e)
        {
            cmbTDSApplicable.Properties.DataSource = LookUpUtility.GetBoolType();
            cmbTDSRates.Properties.DataSource = LookUpUtility.GetTDSRates();

            base.AddControls(layoutControl1);
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;

            txtLedgerName.EditValue = ledger.Name;
            txtGSTNumber.EditValue = ledger.CommissionInfo.GSTNumber;
            txtPANNumber.EditValue = ledger.CommissionInfo.PanNumber;
            cmbTDSApplicable.EditValue = ledger.CommissionInfo.IsTDSApplicable;
            cmbTDSRates.EditValue = ledger.CommissionInfo.TDSRate;
            txtNameOfConsideration.EditValue = ledger.CommissionInfo.NatureOfConsideration;
            txtOpeningBalance.EditValue = ledger.ReservesAndSurplusInfo.OpeningBalance;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.CommissionInfo.GSTNumber = txtGSTNumber.EditValue;
            ledger.CommissionInfo.PanNumber = txtPANNumber.EditValue;
            ledger.CommissionInfo.IsTDSApplicable = cmbTDSApplicable.EditValue;
            ledger.CommissionInfo.TDSRate = cmbTDSRates.EditValue;
            ledger.CommissionInfo.NatureOfConsideration = txtNameOfConsideration.EditValue;
            ledger.ReservesAndSurplusInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_Commission;
            Save();
        }
        private void cmbTDSApplicable_EditValueChanged(object sender, EventArgs e)
        {
            cmbTDSRates.EditValue = null;
            cmbTDSRates.Enabled = cmbTDSApplicable.Text.Equals("Yes");
        }
    }
}
