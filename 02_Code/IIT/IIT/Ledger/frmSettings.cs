using DevExpress.XtraEditors;
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
    public partial class frmSettings : DevExpress.XtraEditors.XtraForm
    {
        public bool IsSave = false;
        public object Fromdate() { return dtpFromDate.EditValue; }
        public object Todate() { return dtpTodate.EditValue; }
        public object ISPurposevisible() { return cmbPurposeVisible.Text == "Yes" ? true : false; }
        public object VoucherTypeID() { return cmbVoucherType.EditValue; }
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            Tuple<DateTime, DateTime> dates = Utility.GetFinYear(DateTime.Now);
            dtpFromDate.DateTime = dates.Item1;
            dtpTodate.DateTime = dates.Item2;

            DataTable dt = LookUpUtility.GetVoucherType().Copy();
            DataRow dr = dt.NewRow();
            dr["ENTITYLOOKUPID"] = 0;
            dr["LOOKUPVALUE"] = "All";
            dt.Rows.InsertAt(dr,0);

            cmbVoucherType.Properties.DataSource = dt;
            cmbVoucherType.Properties.DisplayMember = "LOOKUPVALUE";
            cmbVoucherType.Properties.ValueMember = "ENTITYLOOKUPID"; 
            cmbVoucherType.EditValue = 0;
            cmbPurposeVisible.EditValue = "Yes";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            IsSave = true;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}