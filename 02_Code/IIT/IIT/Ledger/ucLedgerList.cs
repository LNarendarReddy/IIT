using Repository;
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
            Utility.SetGridFormatting(gvLedgerList);
            gcLedgerList.DataSource = new LedgerRepository().GetLedgerList(Utility.CurrentEntity.ID);
        }

        private void gvLedgerList_DoubleClick(object sender, EventArgs e)
        {
            if (gvLedgerList.FocusedRowHandle < 0)
                return;
            Utility.ShowDialog(new ucLedgerReport(gvLedgerList.GetFocusedRowCellValue("LEDGERID"), gvLedgerList.GetFocusedRowCellValue("LEDGERNAME")));           
        }

        private void gvLedgerList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;
            gvLedgerList_DoubleClick(null, null);
        }
    }
}
