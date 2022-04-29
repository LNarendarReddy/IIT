using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IIT
{
    public partial class ucLedgerList : NavigationBase
    {
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
            rptLedgerPrinting rpt = new rptLedgerPrinting();
            rpt.Parameters["EntityID"].Value = Utility.CurrentEntity.ID;
            rpt.Parameters["OrgName"].Value = Utility.CurrentEntity.EntityName;
            rpt.Parameters["FromDate"].Value = DateTime.Now.AddDays(-30);
            rpt.Parameters["ToDate"].Value = DateTime.Now;
            rpt.ShowRibbonPreview();

        }

        private void gvLedgerList_KeyPress(object sender, KeyPressEventArgs e)
        {
            gvLedgerList_DoubleClick(null, null);
        }
    }
}
