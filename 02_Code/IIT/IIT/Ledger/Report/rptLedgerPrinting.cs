using DevExpress.XtraReports.UI;
using Repository;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace IIT
{
    public partial class rptLedgerPrinting : DevExpress.XtraReports.UI.XtraReport
    {
        public rptLedgerPrinting()
        {
            InitializeComponent();
            sqlDataSource1.ConnectionName = SQLCon.connectionString();
        }

    }
}
