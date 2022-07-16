using Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IIT.ReportForms
{
    public partial class ucTrailBalance : NavigationBase
    {
        public ucTrailBalance() : base("Trail Balance")
        {
            InitializeComponent();
        }

        private List<ActionText> helpText = new List<ActionText>() {
            new ActionText("Navigate", buildShort: false, shortCut: "Up/Down"),
            new ActionText("Expand", buildShort: false, shortCut: "Enter"),
            new ActionText("Collapse", buildShort: false, shortCut: "Esc")
        };

        public override IEnumerable<ActionText> HelpText => helpText;

        public override bool HandlesESC => true;

        private void ucTrailBalance_Load(object sender, EventArgs e)
        {
            Utility.SetTreeListFormatting(tlTrailBalance, tlcTrialBalanceLevel);
            tlTrailBalance.DataSource = new ReportRepository().GetReportData("USP_RPT_TRAILBALANCE", new Dictionary<string, object>());
            tlTrailBalance.KeyFieldName = "TBID";
            tlTrailBalance.ParentFieldName = "PARENTID";
            tlTrailBalance.ExpandToLevel(0);
        }

        private void tlTrailBalance_KeyDown(object sender, KeyEventArgs e)
        {
            if (tlTrailBalance.FocusedNode == null) return;
            int ledgerlevel = Convert.ToInt32(tlTrailBalance.FocusedNode["TBLEVEL"]);

            if (e.KeyCode == Keys.Escape)
            {
                if (ledgerlevel > 1)
                    tlTrailBalance.FocusedNode.ParentNode.Collapse();
                else
                    frmSingularMain.Instance.RollbackControl(false);

            }
            else if (e.KeyCode == Keys.Enter)
            {
                tlTrailBalance.FocusedNode.Expand();
            }
        }
    }
}
