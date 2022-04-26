using DevExpress.XtraEditors;
using Entity;
using Repository;
using System;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmSubGroupList : XtraForm
    {
        SubGroupRepository subGroupRepository = new SubGroupRepository();

        public frmSubGroupList()
        {
            InitializeComponent();
        }

        private void frmSubGroupList_Load(object sender, EventArgs e)
        {
            Utility.SetGridFormatting(gvSubGroup);
            gcSubGroup.DataSource = subGroupRepository.GetSubGroupList(Utility.CurrentEntity.ID);
            gvSubGroup_FocusedRowChanged(null, null);
        }

        private void gvSubGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();
            else if (e.KeyData == Keys.C)
                btnCreateSubGroup_Click(null, null);
            else if (e.KeyData == Keys.M && btnModifySubGroup.Enabled)
                btnModifySubGroup_Click(null, null);
        }

        private void gvSubGroup_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnModifySubGroup.Enabled = gvSubGroup.FocusedRowHandle >= 0;
        }

        private void btnCreateSubGroup_Click(object sender, EventArgs e)
        {
            SubGroup subGroupdObj = new SubGroup();
            Utility.ShowDialog(new frmSubGroup(subGroupdObj));
            if (subGroupdObj.IsSave)
            {
                gcSubGroup.DataSource = subGroupRepository.GetSubGroupList(Utility.CurrentEntity.ID);
                gvSubGroup.FocusedRowHandle = gvSubGroup.LocateByValue("GROUPID", subGroupdObj.ID);
            }
        }

        private void btnModifySubGroup_Click(object sender, EventArgs e)
        {
            if (gvSubGroup.FocusedRowHandle < 0) return;

            SubGroup subGroupdObj = subGroupRepository.Load(gvSubGroup.GetFocusedDataRow());
            Utility.ShowDialog(new frmSubGroup(subGroupdObj));
            if (subGroupdObj.IsSave)
            {
                gcSubGroup.DataSource = subGroupRepository.GetSubGroupList(Utility.CurrentEntity.ID);
                gvSubGroup.FocusedRowHandle = gvSubGroup.LocateByValue("GROUPID", subGroupdObj.ID);
            }
        }
    }
}