
using Repository;
using System;
using System.Collections.Generic;
using System.Data;

namespace IIT.ReportForms
{
    public partial class ucBalanceSheet : NavigationBase
    {
        public ucBalanceSheet() : base("Balance Sheet")
        {
            InitializeComponent();
        }

        private void ucBalanceSheet_Load(object sender, System.EventArgs e)
        {
            Utility.SetTreeListFormatting(tlAssets, tlcBalanceSheetAssetsLevel);
            Utility.SetTreeListFormatting(tlLiabilities, tlcBalanceSheetLiabilitiesLevel);
            lblHeader.Text = $"Balance sheet as on {DateTime.Now.ToShortDateString()}";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "EntityID", Utility.CurrentEntity.ID }
            };

            DataSet dsBalanceSheet = new ReportRepository().GetReportDataset("USP_RPT_BALANCESHEET", parameters);

            tlAssets.DataSource = dsBalanceSheet.Tables[0];
            tlAssets.KeyFieldName = "BSID";
            tlAssets.ParentFieldName = "PARENTID";
            tlAssets.ExpandToLevel(0);

            tlLiabilities.DataSource = dsBalanceSheet.Tables[1];
            tlLiabilities.KeyFieldName = "BSID";
            tlLiabilities.ParentFieldName = "PARENTID";
            tlLiabilities.ExpandToLevel(0);
        }
    }
}
