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
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            Tuple<DateTime, DateTime> dates = Utility.GetFinYear(DateTime.Now);
            dtpFromDate.DateTime = dates.Item1;
            dtpTodate.DateTime = dates.Item2;
            cmbPurposeVisible.EditValue = "Yes";           
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}