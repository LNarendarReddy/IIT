using DevExpress.XtraLayout.Utils;
using Repository;
using System;

namespace IIT
{
    public partial class frmSettings : DevExpress.XtraEditors.XtraForm
    {
        readonly bool isApply;
        public AdminSettings SelectedSettings { get; private set; }

        public frmSettings(AdminSettings adminSettings = null, bool _isApply = false)
        {
            InitializeComponent();
            isApply = _isApply;
            SelectedSettings = adminSettings ?? Utility.GetAdminSettings();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            dtpFromDate.EditValue = SelectedSettings.FromDate;
            dtpTodate.EditValue = SelectedSettings.ToDate;
            cmbPurposeVisible.EditValue = SelectedSettings.ShowPurpose;
            lciPurpose.Visibility = isApply ? LayoutVisibility.Never : LayoutVisibility.Always;
            btnOk.Text = isApply ? "Apply" : "Save";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;

            SelectedSettings = new AdminSettings() { FromDate = (DateTime)dtpFromDate.EditValue, ToDate = (DateTime)dtpTodate.EditValue };
            if (!isApply)
            {
                new LookUpRepository().SaveConfig(dtpFromDate.EditValue, dtpTodate.EditValue, cmbPurposeVisible.EditValue);
                Utility.RefreshConfigData();
            }

            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}