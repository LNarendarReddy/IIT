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

namespace IIT.LedgerType
{
    public partial class ucDepreciation : ucLedgerTypeBase
    {
        public ucDepreciation(Ledger _ledger, bool isCallFromAddButton, string caption)
        {
            InitializeComponent();
        }

        private void ucDepreciation_Load(object sender, EventArgs e)
        {

            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;

            txtLedgerName.EditValue = ledger.Name;
            txtOpeningBalance.EditValue = ledger.DepreciationInfo.OpeningBalance;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.DepreciationInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_Depreciation;
            Save();
        }
        private void textExit_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }
    }
}
