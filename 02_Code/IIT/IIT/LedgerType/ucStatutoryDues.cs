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
    public partial class ucStatutoryDues : ucLedgerTypeBase
    {
        public ucStatutoryDues(Ledger _ledger, bool isCallFromAddButton, string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
        }

        private void ucStatutoryDues_Load(object sender, EventArgs e)
        {
            cmbTypeofDue.Properties.DataSource = LookUpUtility.GetDueType();
            cmbTypeofDue.Properties.ValueMember = "ENTITYLOOKUPID";
            cmbTypeofDue.Properties.DisplayMember = "LOOKUPVALUE";

            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;

            txtLedgerName.EditValue = ledger.Name;
            cmbTypeofDue.EditValue = ledger.StatutoryDuesInfo.TypeofDue;
            txtOpeningBalance.EditValue = ledger.StatutoryDuesInfo.OpeningBalance;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.StatutoryDuesInfo.TypeofDue = cmbTypeofDue.EditValue;
            ledger.StatutoryDuesInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_StatutoryDues;
            Save();
        }
        private void textExit_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }
    }
}
