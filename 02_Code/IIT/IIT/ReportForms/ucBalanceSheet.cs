
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
            Utility.SetGridFormatting(gvAssets);
            Utility.SetGridFormatting(gvLiabilities);
            DataSet dsBalanceSheet = new ReportRepository().GetReportDataset("USP_RPT_BALANCESHEET", new Dictionary<string, object>());
            gcAssets.DataSource = dsBalanceSheet.Tables[0];
            gcLiabilities.DataSource = dsBalanceSheet.Tables[1]; 
        }
    }
}
