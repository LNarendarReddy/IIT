using Repository;
using System;

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
            dtpFromDate.EditValue = Utility.GetConfigValue<DateTime>("FROMDATE");
            dtpTodate.EditValue = Utility.GetConfigValue<DateTime>("TODATE");
            cmbPurposeVisible.EditValue = Utility.GetConfigValue<string>("NARRATIONVISIBLE");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            new LookUpRepository().SaveConfig(dtpFromDate.EditValue,dtpTodate.EditValue,cmbPurposeVisible.EditValue);
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}