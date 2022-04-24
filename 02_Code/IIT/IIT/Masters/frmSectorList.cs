using Entity;
using Repository;
using System;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmSectorList : DevExpress.XtraEditors.XtraForm
    {
        SectorRepository sectorRepository = new SectorRepository();
        public frmSectorList()
        {
            InitializeComponent();
        }

        private void frmSector_Load(object sender, EventArgs e)
        {
            Utility.SetGridFormatting(gvSector);
            gcSector.DataSource = sectorRepository.GetSectorList();
            gvSector_FocusedRowChanged(null, null);
        }

        private void gvSector_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnModifySector.Enabled = gvSector.FocusedRowHandle >= 0;
        }

        private void btnCreateSector_Click(object sender, EventArgs e)
        {
            Sector sectorObj = new Sector();
            Utility.ShowDialog(new frmSector(sectorObj));
            if(sectorObj.IsSave)
            {
                gcSector.DataSource = sectorRepository.GetSectorList();
                gvSector.FocusedRowHandle = gvSector.LocateByValue("SECTORID", sectorObj.ID);
            }
        }

        private void btnModifySector_Click(object sender, EventArgs e)
        {
            if (gvSector.FocusedRowHandle < 0) return;

            Sector sectorObj = sectorRepository.Load(gvSector.GetDataRow(gvSector.FocusedRowHandle));
            Utility.ShowDialog(new frmSector(sectorObj));
            if (sectorObj.IsSave)
            {
                gcSector.DataSource = sectorRepository.GetSectorList();
                gvSector.FocusedRowHandle = gvSector.LocateByValue("SECTORID", sectorObj.ID);
            }
        }

        private void frmSectorList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();
            else if (e.KeyData == Keys.C)
                btnCreateSector_Click(null, null);
            else if (e.KeyData == Keys.M && btnModifySector.Enabled)
                btnModifySector_Click(null, null);
        }
    }
}