using DevExpress.DataAccess.ConnectionParameters;
using Repository;
using System.Data.SqlClient;

namespace IIT
{
    public partial class rptLedgerPrinting : DevExpress.XtraReports.UI.XtraReport
    {
        public rptLedgerPrinting()
        {
            InitializeComponent();
            //SqlConnection sqlCon = SQLCon.Sqlconn();
            //sqlDataSource1.ConnectionParameters = 
            //    new MsSqlConnectionParameters(sqlCon.DataSource, 
            //    sqlCon.Database, string.Empty, string.Empty, MsSqlAuthorizationType.Windows);
        }

    }
}
