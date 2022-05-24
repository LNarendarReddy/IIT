﻿using Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace IIT
{
    public partial class ucLedgerList : NavigationBase
    {
        private List<ActionText> helpText = new List<ActionText>() { new ActionText("Navigate", buildShort: false, shortCut: "Up/Down") };
        public override IEnumerable<ActionText> HelpText => helpText;

        public override string Caption => "Ledger List";

        public ucLedgerList()
        {
            InitializeComponent();
        }

        private void ucLedgerList_Load(object sender, EventArgs e)
        {
            gcLedgerList.DataSource = new LedgerRepository().GetLedgerList(Utility.CurrentEntity.ID);
        }

        private void gvLedgerList_DoubleClick(object sender, EventArgs e)
        {
            if (gvLedgerList.FocusedRowHandle < 0)
                return;
            rptLedgerPrinting rpt = new rptLedgerPrinting();
            rpt.Parameters["EntityID"].Value = Utility.CurrentEntity.ID;
            rpt.Parameters["OrgName"].Value = Utility.CurrentEntity.EntityName;
            rpt.Parameters["FromDate"].Value = Utility.GetConfigValue<DateTime>("FROMDATE");
            rpt.Parameters["ToDate"].Value = Utility.GetConfigValue<DateTime>("TODATE");
            rpt.Parameters["IsPurposeVisible"].Value = Utility.GetConfigValue<string>("NARRATIONVISIBLE");
            rpt.Parameters["LedgerID"].Value = gvLedgerList.GetFocusedRowCellValue("LEDGERID");
            rpt.Parameters["LedgerName"].Value = gvLedgerList.GetFocusedRowCellValue("LEDGERNAME");
            rpt.CreateDocument();
            string filePath = Path.Combine(Utility.ReportsPath,
                $"{Utility.CurrentEntity.EntityName}_{gvLedgerList.GetFocusedRowCellValue("LEDGERNAME")}_{DateTime.Now.ToString("ddMMyyyyHHmmss")}.pdf");
            rpt.ExportToPdf(filePath);
            ProcessStartInfo startInfo = new ProcessStartInfo(filePath);
            Process.Start(startInfo);
        }

        private void gvLedgerList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;
            gvLedgerList_DoubleClick(null, null);
        }
    }
}
