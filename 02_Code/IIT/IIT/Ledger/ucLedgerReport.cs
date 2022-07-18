using Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace IIT
{
    public partial class ucLedgerReport : NavigationBase
    {
        public override string Caption => "Ledger Report";

        private readonly object ledgerID;
        private readonly object ledgerName;

        private AdminSettings CurrentSettings = null;

        private List<ActionText> helpText = new List<ActionText>()
            {
                new ActionText("Print", buildShort: false, shortCut: "Ctrl + P"),
                new ActionText("Change Search Date", buildShort: false, shortCut: "F2")
            };

        public override IEnumerable<ActionText> HelpText => helpText;

        public ucLedgerReport(object _ledgerID, object _ledgerName)
        {
            InitializeComponent();
            ledgerID = _ledgerID;
            ledgerName = _ledgerName;
        }

        private void ucLedgerReport_Load(object sender, EventArgs e)
        {
            CurrentSettings = Utility.GetAdminSettings();

            Utility.SetGridFormatting(gvVouchers);
            lblLedgerName.Text = ledgerName?.ToString();
            FetchAndBindDataSource();
        }

        protected override bool ProcessCmdKey(ref Message msg ,Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.P))
            {
                rptLedgerPrinting rpt = new rptLedgerPrinting();
                rpt.Parameters["EntityID"].Value = Utility.CurrentEntity.ID;
                rpt.Parameters["OrgName"].Value = Utility.CurrentEntity.EntityName;
                rpt.Parameters["FromDate"].Value = CurrentSettings.FromDate;
                rpt.Parameters["ToDate"].Value = CurrentSettings.ToDate;
                rpt.Parameters["IsPurposeVisible"].Value = CurrentSettings.ShowPurpose;
                rpt.Parameters["LedgerName"].Value = ledgerName;
                rpt.Parameters["OpeningBalance"].Value = lblOpeningBalance.Text;
                rpt.Parameters["ClosingBalance"].Value = lblClosingBalance.Text;
                rpt.DataSource = gcVouchers.DataSource;
                rpt.CreateDocument();
                string filePath = Path.Combine(Utility.ReportsPath,
                    $"{Utility.CurrentEntity.EntityName}_{ledgerName}_{DateTime.Now:ddMMyyyyHHmmss}.pdf");
                rpt.ExportToPdf(filePath);
                ProcessStartInfo startInfo = new ProcessStartInfo(filePath);
                Process.Start(startInfo);

                return true;
            }
            else if(keyData == Keys.F2)
            {
                if (Utility.ShowDialog(new frmSettings(CurrentSettings, true)) == DialogResult.OK)
                {
                    FetchAndBindDataSource();
                }

                return true;
            }


            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FetchAndBindDataSource()
        {
            lblFromDate.Text = CurrentSettings.FromDate.ToShortDateString();
            lblToDate.Text = CurrentSettings.ToDate.ToShortDateString();

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "ENTITYID", Utility.CurrentEntity.ID },
                { "FROMDATE", CurrentSettings.FromDate },
                { "TODATE", CurrentSettings.ToDate },
                { "LEDGERID", ledgerID },
            };
            DataSet dsVoucherData = new ReportRepository().GetReportDataset("USP_RPT_LEDGER", parameters);

            lblOpeningBalance.Text = dsVoucherData.Tables[0].Rows[0][0]?.ToString();
            gcVouchers.DataSource = dsVoucherData.Tables[1];
            lblClosingBalance.Text = gvVouchers.RowCount == 0
                ? lblOpeningBalance.Text
                : gvVouchers.GetRowCellValue(gvVouchers.RowCount - 1, "RUNNINGBAL").ToString();

            gcolPurpose.Visible = CurrentSettings.ShowPurpose == "Yes";
        }
    }
}
