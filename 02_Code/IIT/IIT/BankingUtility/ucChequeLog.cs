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
        private string caption;
        public override string Caption => caption;
        public ucChequeLog()
        {
            InitializeComponent();
        }

        private void ucChequeLog_Load(object sender, EventArgs e)
        {
            
            lblHeader.Text = caption = "Banking - Cheque Register";

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
                bankingRepository.GetChequeLog(cmbLedger.EditValue);
            gvChequeLog.ExpandAllGroups();
        }
    }
}
