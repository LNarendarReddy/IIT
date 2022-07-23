using Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IIT.ReportForms
{
    public partial class ucTrailBalance : NavigationBase
    {
        AdminSettings currentSettings = null;
        ReportRepository reportRepository = new ReportRepository();

        public ucTrailBalance() : base("Trail Balance")
        {
            InitializeComponent();
        }

        private List<ActionText> helpText = new List<ActionText>() {
            new ActionText("Navigate", buildShort: false, shortCut: "Up/Down"),
            new ActionText("F2", buildShort: false, shortCut: "Date Settings"),
            new ActionText("F4", buildShort: false, shortCut: "Display Settings"),
            new ActionText("Expand", buildShort: false, shortCut: "Enter"),
            new ActionText("Collapse", buildShort: false, shortCut: "Esc")
        };

        public override IEnumerable<ActionText> HelpText => helpText;

        public override bool HandlesESC => true;

        private void ucTrailBalance_Load(object sender, EventArgs e)
        {
            Utility.SetTreeListFormatting(tlTrailBalance, tlcTrialBalanceLevel);
            currentSettings = Utility.GetAdminSettings();
            FetchAndBindData();
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
                    frmSingularMain.Instance.RollbackControl();

            }
            else if (e.KeyCode == Keys.Enter && ledgerlevel < 3)
            {
                tlTrailBalance.FocusedNode.Expand();
            }
            else if (e.KeyCode == Keys.Enter && ledgerlevel == 3)
            {
                ucLedgerReport ledgerReport = new ucLedgerReport(tlTrailBalance.FocusedNode["CURRENTID"]
                        , tlTrailBalance.FocusedNode["TBNAME"])
                {
                    CurrentSettings = currentSettings
                };
                Utility.ShowDialog(ledgerReport);
            }
            else if(e.KeyCode == Keys.F2)
            {
                if (Utility.ShowDialog(new frmSettings(currentSettings, true)) == DialogResult.OK)
                    FetchAndBindData();
            }
            else if (e.KeyCode == Keys.F4)
            {
                frmTrialBalanceSettings trialBalanceSettings = new frmTrialBalanceSettings();
                if (Utility.ShowDialog(trialBalanceSettings) == DialogResult.OK)
                {
                    tlcOpeningBalance.Visible = trialBalanceSettings.chkShowOpeningBalance.Checked;
                    tlcClosingBalance.Visible = trialBalanceSettings.chkShowClosingBalances.Checked;
                    if (trialBalanceSettings.chkExpand.Checked) tlTrailBalance.ExpandToLevel(4);
                }
            }
        }

        private void FetchAndBindData()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>() 
            {
                { "FromDate", currentSettings.FromDate },
                { "ToDate", currentSettings.ToDate },
                { "EntityID", Utility.CurrentEntity.ID }
            };

            tlTrailBalance.DataSource = reportRepository.GetReportData("USP_RPT_TRAILBALANCE", parameters);
            tlTrailBalance.KeyFieldName = "TBID";
            tlTrailBalance.ParentFieldName = "PARENTID";
            tlTrailBalance.ExpandToLevel(0);

            lblHeader.Text = $"Statement of Trail balance as on {currentSettings.ToDate.ToShortDateString()}";
        }
    }
}
