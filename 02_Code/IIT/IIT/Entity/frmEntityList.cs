using DevExpress.XtraGrid.Views.Base;
using Repository;
using System;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmEntityList : DevExpress.XtraEditors.XtraForm
    {
        public frmEntityList()
        {
            InitializeComponent();
        }

        private void frmEntityList_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Escape)
            this.Close();
        }

        private void btnCreateEntity_Click(object sender, EventArgs e)
        {
            frmEntityIndividual  frmEntityIndividual = new frmEntityIndividual();
            Utility.showDialog(frmEntityIndividual);
        }

        private void frmEntityList_Load(object sender, EventArgs e)
        {
            gcEntityList.DataSource = new EntityDataRepository().GetEntityList();
            gvEntityList_FocusedRowChanged(null, new FocusedRowChangedEventArgs(-1, -1));
        }

        private void gvEntityList_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            btnModifyEntity.Enabled = e.FocusedRowHandle >= 0;
        }

        private void btnModifyEntity_Click(object sender, EventArgs e)
        {

        }
    }
}