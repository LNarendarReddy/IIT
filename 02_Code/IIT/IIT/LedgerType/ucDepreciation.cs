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
    public partial class ucDepreciation : ucLedgerTypeBase
    {
        public ucDepreciation(Ledger _ledger, bool isCallFromAddButton, string caption)
        {
            InitializeComponent();
            this.txtOpeningBalance.Spin += base.textedit_Spin;
        }
        private void ucDepreciation_Load(object sender, EventArgs e)
        {
            base.AddControls(layoutControl1);
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;

            txtLedgerName.EditValue = ledger.Name;
            txtOpeningBalance.EditValue = ledger.DepreciationInfo.OpeningBalance;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.DepreciationInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_Depreciation;
            Save();
        }
    }
}
