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
    public partial class ucInvestment : ucLedgerTypeBase
    {
        public ucInvestment(Ledger ledger,bool callfromEvent,string caption):base(ledger, callfromEvent, caption)
        {
            InitializeComponent();
        }
        private void ucInvestment_Load(object sender, EventArgs e)
        {
            cmbTypeOfInvestment.Properties.DataSource = LookUpUtility.GetInvestmentType();
            cmbTypeOfInvestment.Properties.ValueMember = "ENTITYLOOKUPID";
            cmbTypeOfInvestment.Properties.DisplayMember = "LOOKUPVALUE";

            cmbTCSRate.Properties.DataSource = LookUpUtility.GetTDSRates();
            cmbTCSRate.Properties.ValueMember = "ENTITYLOOKUPID";
            cmbTCSRate.Properties.DisplayMember = "LOOKUPVALUE";

            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            cmbTypeOfInvestment.EditValue = ledger.InvestmentInfo.TypeOfInvestment;
            txtTenure.EditValue = ledger.InvestmentInfo.Tenure;
            rgTCSApplicable.EditValue = ledger.InvestmentInfo.IsTCSApplicable;
            cmbTCSRate.EditValue = ledger.InvestmentInfo.TCSRate;
            txtOpeningBalance.EditValue = ledger.InvestmentInfo.OpeningBalance;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.InvestmentInfo.TypeOfInvestment = cmbTypeOfInvestment.EditValue;
            ledger.InvestmentInfo.Tenure = txtTenure.EditValue;
            ledger.InvestmentInfo.IsTCSApplicable = rgTCSApplicable.EditValue;
            ledger.InvestmentInfo.TCSRate = cmbTCSRate.EditValue;
            ledger.InvestmentInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_Investment;
            Save();
        }
        private void txtInterest_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }
        private void rgTypeofLoan_Enter(object sender, EventArgs e)
        {
            RadioGroup rg = sender as RadioGroup;
            rg.SelectedIndex = rg.EditValue == null ? 0 : rg.SelectedIndex;
        }
    }
}
