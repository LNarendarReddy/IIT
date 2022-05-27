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
        object ledgerID, ledgerName;

        private void ucLedgerReport_Load(object sender, EventArgs e)
        {
            Utility.SetGridFormatting(gvVouchers);
            lblLedgerName.Text = ledgerName?.ToString();
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "ENTITYID", Utility.CurrentEntity.ID },
                { "FROMDATE", Utility.GetConfigValue<DateTime>("FROMDATE") },
                { "TODATE", Utility.GetConfigValue<DateTime>("TODATE") },
                { "LEDGERID", ledgerID },
            };
            DataSet dsVoucherData = new ReportRepository().GetReportDataset("USP_RPT_LEDGER", parameters);

            lblOpeningBalance.Text = dsVoucherData.Tables[0].Rows[0][0]?.ToString();
            gcVouchers.DataSource = dsVoucherData.Tables[1];
            lblClosingBalance.Text = gvVouchers.RowCount == 0 
                ? lblOpeningBalance.Text 
                : gvVouchers.GetRowCellValue(gvVouchers.RowCount - 1, "RUNNINGBAL").ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            rptLedgerPrinting rpt = new rptLedgerPrinting();
            rpt.Parameters["EntityID"].Value = Utility.CurrentEntity.ID;
            rpt.Parameters["OrgName"].Value = Utility.CurrentEntity.EntityName;
            rpt.Parameters["FromDate"].Value = Utility.GetConfigValue<DateTime>("FROMDATE");
            rpt.Parameters["ToDate"].Value = Utility.GetConfigValue<DateTime>("TODATE");
            rpt.Parameters["IsPurposeVisible"].Value = Utility.GetConfigValue<string>("NARRATIONVISIBLE");
            rpt.Parameters["LedgerID"].Value = ledgerID;
            rpt.Parameters["LedgerName"].Value = ledgerName;
            rpt.CreateDocument();
            string filePath = Path.Combine(Utility.ReportsPath,
                $"{Utility.CurrentEntity.EntityName}_{ledgerName}_{DateTime.Now:ddMMyyyyHHmmss}.pdf");
            rpt.ExportToPdf(filePath);
            ProcessStartInfo startInfo = new ProcessStartInfo(filePath);
            Process.Start(startInfo);
        }

        public ucLedgerReport(object _ledgerID, object _ledgerName)
        {
            InitializeComponent();
            ledgerID = _ledgerID;
            ledgerName = _ledgerName;
        }

    }
}
