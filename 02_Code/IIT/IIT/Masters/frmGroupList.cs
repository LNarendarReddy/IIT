using DevExpress.XtraEditors;
using Entity;
using Repository;
using System;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmGroupList : XtraForm
    {
        GroupRepository groupRepository = new GroupRepository();

        public frmGroupList()
        {
            InitializeComponent();
        }

        private void frmGroupList_Load(object sender, EventArgs e)
        {
            Utility.SetGridFormatting(gvGroupList);
            gcGroupList.DataSource = groupRepository.GetGroupList(Utility.CurrentEntity.ID);
            gvGroupList_FocusedRowChanged(null, null);
        }

        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            Group groupdObj = new Group();
            Utility.ShowDialog(new frmGroup(groupdObj));
            if(groupdObj.IsSave)
            {
                gcGroupList.DataSource = new GroupRepository().GetGroupList(Utility.CurrentEntity.ID);
                gvGroupList.FocusedRowHandle = gvGroupList.LocateByValue("GROUPID", groupdObj.ID);
            }
        }

        private void btnModifyGroup_Click(object sender, EventArgs e)
        {
            if (gvGroupList.FocusedRowHandle < 0) return;

            Group groupdObj = groupRepository.Load(gvGroupList.GetFocusedDataRow());
            Utility.ShowDialog(new frmGroup(groupdObj));
            if (groupdObj.IsSave)
            {
                gcGroupList.DataSource = new GroupRepository().GetGroupList(Utility.CurrentEntity.ID);
                gvGroupList.FocusedRowHandle = gvGroupList.LocateByValue("GROUPID", groupdObj.ID);
            }
        }

        private void gvGroupList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();
            else if (e.KeyData == Keys.C)
                btnCreateGroup_Click(null, null);
            else if (e.KeyData == Keys.M && btnModifyGroup.Enabled)
                btnModifyGroup_Click(null, null);
        }

        private void gvGroupList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnModifyGroup.Enabled = gvGroupList.FocusedRowHandle >= 0;
        }
    }
}