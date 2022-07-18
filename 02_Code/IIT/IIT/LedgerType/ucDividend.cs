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
    public partial class ucDividend : ucLedgerTypeBase
    {
        public ucDividend(Ledger _ledger, bool isCallFromAddButton, string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
        }

        private void ucDividend_Load(object sender, EventArgs e)
        {
            cmbTDSRates.Properties.DataSource = LookUpUtility.GetTDSRates();
            cmbTDSRates.Properties.ValueMember = "ENTITYLOOKUPID";
            cmbTDSRates.Properties.DisplayMember = "LOOKUPVALUE";

            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;

            txtLedgerName.EditValue = ledger.Name;
            rgTDSApplicable.EditValue = ledger.DividendInfo.IsTDSApplicable;
            cmbTDSRates.EditValue = ledger.DividendInfo.TDSRate;
            txtNameOfTheCompany.EditValue = ledger.DividendInfo.NameofCompany;
            cmbIsFromIndia.EditValue = ledger.DividendInfo.isDividendRecievedFromIndia;
            txtOpeningBalance.EditValue = ledger.DividendInfo.OpeningBalance;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.DividendInfo.IsTDSApplicable = rgTDSApplicable.EditValue;
            ledger.DividendInfo.TDSRate = cmbTDSRates.EditValue;
            ledger.DividendInfo.NameofCompany = txtNameOfTheCompany.EditValue;
            ledger.DividendInfo.isDividendRecievedFromIndia = cmbIsFromIndia.EditValue;
            ledger.DividendInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_Dividend;
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
