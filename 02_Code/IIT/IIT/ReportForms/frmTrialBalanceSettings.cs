using DevExpress.XtraEditors;

namespace IIT.ReportForms
{
    public partial class frmTrialBalanceSettings : XtraForm
    {
        public CheckEdit chkShowTransactions;
        public CheckEdit chkShowClosingBalances;
        public CheckEdit chkShowPercentages;
        public CheckEdit chkExpand;
        public CheckEdit chkShowOpeningBalance;

        public frmTrialBalanceSettings()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, System.EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
    }
}