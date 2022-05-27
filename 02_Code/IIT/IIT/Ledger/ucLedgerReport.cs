
using Repository;
using System;
using System.Collections.Generic;
using System.Data;

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
            lblClosingBalance.Text = gvVouchers.RowCount == 0 ? lblOpeningBalance.Text : gvVouchers.GetRowCellValue(gvVouchers.RowCount - 1, "RUNNINGBAL").ToString();
        }

        public ucLedgerReport(object _ledgerID, object _ledgerName)
        {
            InitializeComponent();
            ledgerID = _ledgerID;
            ledgerName = _ledgerName;
        }


    }
}
