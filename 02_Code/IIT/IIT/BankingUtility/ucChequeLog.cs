using DevExpress.XtraEditors;
using Repository;
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
    public partial class ucChequeLog : NavigationBase
    {
        BankingRepository bankingRepository = new BankingRepository();
        private AdminSettings CurrentSettings = null;
        private static string caption = "Banking - Cheque Register";
        public ucChequeLog() : base(caption)
        {
            InitializeComponent();
        }

        private void ucChequeLog_Load(object sender, EventArgs e)
        {
            lblHeader.Text = caption;

            CurrentSettings = Utility.GetAdminSettings();
            lblFromDate.Text = CurrentSettings.FromDate.ToShortDateString();
            lblToDate.Text = CurrentSettings.ToDate.ToShortDateString();

            cmbLedger.Properties.DataSource = Utility.GetBankingLedgers();
            cmbLedger.Properties.ValueMember = "LEDGERID";
            cmbLedger.Properties.DisplayMember = "LEDGERNAME";
        }
        private void cmbLedger_Leave(object sender, EventArgs e)
        {
            if (cmbLedger.EditValue == null)
            {
                gcChequeLog.DataSource = null;
                return;
            }
            gcChequeLog.DataSource =
                bankingRepository.GetChequeLog(cmbLedger.EditValue, CurrentSettings.FromDate, CurrentSettings.ToDate);
            gvChequeLog.ExpandAllGroups();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F2)
            {
                if (Utility.ShowDialog(new frmSettings(CurrentSettings, true)) == DialogResult.OK)
                {
                    lblFromDate.Text = CurrentSettings.FromDate.ToShortDateString();
                    lblToDate.Text = CurrentSettings.ToDate.ToShortDateString();
                    cmbLedger_Leave(null, null);
                }

                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
