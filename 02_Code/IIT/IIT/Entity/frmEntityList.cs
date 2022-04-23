using DevExpress.XtraGrid.Views.Base;
using Repository;
using System;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmEntityList : DevExpress.XtraEditors.XtraForm
    {
        public object EntityID;
        public object EntityName;
        public frmEntityList()
        {
            InitializeComponent();
        }

        private void frmEntityList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();
            else if (e.KeyData == Keys.C)
                btnCreateEntity_Click(null, null);
            else if (e.KeyData == Keys.M && btnModifyEntity.Enabled)
                btnModifyEntity_Click(null, null);
        }

        private void btnCreateEntity_Click(object sender, EventArgs e)
        {
            frmEntityType objEntityType = new frmEntityType();
            Utility.ShowDialog(objEntityType);
            gcEntityList.DataSource = new EntityDataRepository().GetEntityList();
            gvEntityList_FocusedRowChanged(null,null);
        }

        private void frmEntityList_Load(object sender, EventArgs e)
        {
            Utility.SetGridFormatting(gvEntityList);
            gcEntityList.DataSource = new EntityDataRepository().GetEntityList();
            gvEntityList_FocusedRowChanged(null, new FocusedRowChangedEventArgs(-1, -1));
        }

        private void gvEntityList_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            btnModifyEntity.Enabled = gvEntityList.FocusedRowHandle >= 0;
        }

        private void btnModifyEntity_Click(object sender, EventArgs e)
        {
            if(gvEntityList.FocusedRowHandle < 0)
                return;
            if(gvEntityList.GetFocusedRowCellValue("ENTITYTYPEID").Equals(1))
            {
                frmEntityIndividual obj = new frmEntityIndividual(1,
                    Convert.ToInt32(gvEntityList.GetFocusedRowCellValue("ENTITYID")));
                Utility.ShowDialog(obj);
                gcEntityList.DataSource = new EntityDataRepository().GetEntityList();
                gvEntityList_FocusedRowChanged(null, null);
            }
            else
            {
                frmPartnershipFirm obj = new frmPartnershipFirm(Convert.ToInt32(gvEntityList.GetFocusedRowCellValue("ENTITYTYPEID")),
                    Convert.ToInt32(gvEntityList.GetFocusedRowCellValue("ENTITYID")));
                Utility.ShowDialog(obj);
                gcEntityList.DataSource = new EntityDataRepository().GetEntityList();
                gvEntityList_FocusedRowChanged(null, null);
            }
        }

        private void gvEntityList_DoubleClick(object sender, EventArgs e)
        {
            //if(gvEntityList.FocusedRowHandle >= 0)
            //{
            //    EntityID = 0;
            //    EntityName = string.Empty;
            //    this.Close();
            //}
        }
    }
}