using Repository;
using System;
using System.Collections.Generic;

namespace IIT.ReportForms
{
    public partial class ucTrailBalance : NavigationBase
    {
        public ucTrailBalance() : base("Trail Balance")
        {
            InitializeComponent();
        }

        private void ucTrailBalance_Load(object sender, EventArgs e)
        {
            Utility.SetGridFormatting(gvTrailBalance);
            gcTrailBalance.DataSource = new ReportRepository().GetReportData("USP_RPT_TRAILBALANCE", new Dictionary<string, object>());
        }
    }
}
