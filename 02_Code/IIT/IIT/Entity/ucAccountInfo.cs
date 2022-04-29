using DevExpress.XtraEditors;
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
    public partial class ucAccountInfo : NavigationBase
    {
        public ucAccountInfo()
        {
            InitializeComponent();
        }

        private void btnVoucherEntry_Click(object sender, EventArgs e)
        {

        }

        private void btnInventoryEntry_Click(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnLeadgerCreation_Click(object sender, EventArgs e)
        {
            Utility.ShowDialog(new ucLedgerInfo());
        }

        private void btnDayBook_Click(object sender, EventArgs e)
        {
            Utility.ShowDialog(new frmVoucherList());
        }

        private void btnLedgerPrinting_Click(object sender, EventArgs e)
        {

        }
    }
}
