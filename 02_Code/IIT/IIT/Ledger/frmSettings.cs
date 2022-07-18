using DevExpress.XtraLayout.Utils;
using Repository;
using System;
using System.Windows.Forms;

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

            DateTime fromDate = (DateTime)dtpFromDate.EditValue;
            DateTime toDate = (DateTime)dtpTodate.EditValue;
            DialogResult = SelectedSettings.FromDate != fromDate || SelectedSettings.ToDate != toDate ? DialogResult.OK : DialogResult.Cancel;

            SelectedSettings.FromDate = fromDate;
            SelectedSettings.ToDate = toDate;

            if (!isApply && DialogResult == DialogResult.OK)
            {
                new LookUpRepository().SaveConfig(dtpFromDate.EditValue, dtpTodate.EditValue, cmbPurposeVisible.EditValue);
                Utility.RefreshConfigData();
            }

            this.Close();
        }
    }
}