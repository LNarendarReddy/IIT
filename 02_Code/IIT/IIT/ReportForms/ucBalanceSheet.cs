﻿
using Repository;
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
            DataSet dsBalanceSheet = new ReportRepository().GetReportDataset("USP_RPT_BALANCESHEET", new Dictionary<string, object>());

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